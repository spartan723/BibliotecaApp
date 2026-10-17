using System.Net.Mail;
using BibliotecaApp.Models;

namespace BibliotecaApp
{
    // La interfaz (controles) se edita desde el diseñador: MainForm.cs [Design]
    // Aquí solo está la lógica.
    public partial class MainForm : Form
    {
        private long? _libroSeleccionadoId = null;
        private bool _cargandoLibros = false;

        private long? _lectorSeleccionadoId = null;
        private bool _cargandoLectores = false;

        public MainForm()
        {
            InitializeComponent();
        }

        // ---------- Conexión y carga inicial ----------
        private async void MainForm_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;

            try
            {
                await SupabaseService.InitializeAsync();
                await CargarLibrosAsync();
                await CargarLectoresAsync();
                await CargarDisponiblesAsync();

                btnGuardarLibro.Enabled = true;
                btnGuardarEjemplar.Enabled = true;
                btnGuardarLector.Enabled = true;
                btnActualizarDisponibles.Enabled = true;
                lblEstadoConexion.Text = "Conectado a Supabase.";
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = "Error de conexión.";
                MessageBox.Show("No se pudo conectar a Supabase:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Cargas de datos ----------

        // Carga (o recarga) los libros en el ComboBox y en el DataGridView de Libros
        private async Task CargarLibrosAsync()
        {
            _cargandoLibros = true;
            try
            {
                var seleccionado = (cmbLibro.SelectedItem as Libro)?.Id;

                var respuesta = await SupabaseService.Client.From<Libro>().Get();
                var libros = respuesta.Models.OrderBy(l => l.Titulo).ToList();

                // Combo de la pestaña Ejemplares
                cmbLibro.DataSource = null;
                cmbLibro.DataSource = libros;
                cmbLibro.DisplayMember = nameof(Libro.Titulo);
                cmbLibro.ValueMember = nameof(Libro.Id);

                if (seleccionado.HasValue)
                    cmbLibro.SelectedValue = seleccionado.Value;
                else
                    cmbLibro.SelectedIndex = -1;

                // DataGridView de la pestaña Libros
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = libros;
                dgvLibros.ClearSelection();
                LimpiarFormularioLibro();
            }
            finally
            {
                _cargandoLibros = false;
            }
        }

        // Lista de lectores registrados
        private async Task CargarLectoresAsync()
        {
            _cargandoLectores = true;
            try
            {
                var respuesta = await SupabaseService.Client.From<Lector>().Get();
                var lista = respuesta.Models.Select(l =>
                {
                    if (string.IsNullOrEmpty(l.Apellido) && !string.IsNullOrEmpty(l.Nombre))
                    {
                        var parts = l.Nombre.Trim().Split(' ', 2);
                        l.Nombre = parts[0];
                        l.Apellido = parts.Length > 1 ? parts[1] : "";
                    }
                    return l;
                }).OrderBy(l => l.Apellido).ThenBy(l => l.Nombre).ToList();

                dgvLectores.DataSource = null;
                dgvLectores.DataSource = lista;
                dgvLectores.ClearSelection();
                LimpiarFormularioLector();
            }
            finally
            {
                _cargandoLectores = false;
            }
        }

        // Lista de libros con la cantidad de ejemplares disponibles
        private async Task CargarDisponiblesAsync()
        {
            var libros = (await SupabaseService.Client.From<Libro>().Get()).Models;
            var ejemplares = (await SupabaseService.Client.From<Ejemplar>().Get()).Models;

            var lista = libros.Select(l =>
            {
                var propios = ejemplares.Where(e => e.LibroId == l.Id).ToList();
                return new LibroDisponible
                {
                    Titulo = l.Titulo,
                    Isbn = l.Isbn,
                    Editorial = l.Editorial,
                    AnioPublicacion = l.AnioPublicacion,
                    TotalEjemplares = propios.Count,
                    Disponibles = propios.Count(e =>
                        string.Equals(e.Estado, "Disponible", StringComparison.OrdinalIgnoreCase))
                };
            });

            if (chkSoloDisponibles.Checked)
                lista = lista.Where(x => x.Disponibles > 0);

            dgvDisponibles.DataSource = lista.OrderBy(x => x.Titulo).ToList();
        }

        // ---------- Insertar en tabla padre (libros) ----------
        private async void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string isbn = txtIsbn.Text.Trim();
            string editorial = txtEditorial.Text.Trim();

            if (titulo == "" || isbn == "" || editorial == "" || txtAnio.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos del libro.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAnio.Text.Trim(), out int anio) || anio < 1000 || anio > DateTime.Now.Year)
            {
                MessageBox.Show("Ingrese un año de publicación válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardarLibro.Enabled = false;

                var libro = new Libro
                {
                    Titulo = titulo,
                    Isbn = isbn,
                    AnioPublicacion = anio,
                    Editorial = editorial
                };

                await SupabaseService.Client.From<Libro>().Insert(libro);

                MessageBox.Show("Libro registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitulo.Clear(); txtIsbn.Clear(); txtAnio.Clear(); txtEditorial.Clear();

                // Actualiza automáticamente el ComboBox de la pestaña hija y la lista
                await CargarLibrosAsync();
                await CargarDisponiblesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardarLibro.Enabled = true;
            }
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargandoLibros) return;

            if (dgvLibros.CurrentRow?.DataBoundItem is Libro libro)
            {
                _libroSeleccionadoId = libro.Id;
                txtTitulo.Text = libro.Titulo ?? "";
                txtIsbn.Text = libro.Isbn ?? "";
                txtAnio.Text = libro.AnioPublicacion.ToString();
                txtEditorial.Text = libro.Editorial ?? "";

                btnActualizarLibro.Enabled = true;
                btnEliminarLibro.Enabled = true;
                btnGuardarLibro.Enabled = false;
            }
        }

        private void LimpiarFormularioLibro()
        {
            _libroSeleccionadoId = null;
            txtTitulo.Clear();
            txtIsbn.Clear();
            txtAnio.Clear();
            txtEditorial.Clear();
            btnActualizarLibro.Enabled = false;
            btnEliminarLibro.Enabled = false;
            btnGuardarLibro.Enabled = true;
            dgvLibros.ClearSelection();
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            LimpiarFormularioLibro();
        }

        // ---------- Actualizar libro ----------
        private async void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (!_libroSeleccionadoId.HasValue)
            {
                MessageBox.Show("Seleccione un libro de la lista para actualizar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titulo = txtTitulo.Text.Trim();
            string isbn = txtIsbn.Text.Trim();
            string editorial = txtEditorial.Text.Trim();

            if (titulo == "" || isbn == "" || editorial == "" || txtAnio.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos del libro.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAnio.Text.Trim(), out int anio) || anio < 1000 || anio > DateTime.Now.Year)
            {
                MessageBox.Show("Ingrese un año de publicación válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnActualizarLibro.Enabled = false;
                btnEliminarLibro.Enabled = false;

                var libro = new Libro
                {
                    Id = _libroSeleccionadoId.Value,
                    Titulo = titulo,
                    Isbn = isbn,
                    AnioPublicacion = anio,
                    Editorial = editorial
                };

                await SupabaseService.Client.From<Libro>().Update(libro);

                MessageBox.Show("Libro actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CargarLibrosAsync();
                await CargarDisponiblesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el libro:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarFormularioLibro();
            }
        }

        // ---------- Eliminar libro ----------
        private async void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (!_libroSeleccionadoId.HasValue)
            {
                MessageBox.Show("Seleccione un libro de la lista para eliminar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el libro '{txtTitulo.Text}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                btnActualizarLibro.Enabled = false;
                btnEliminarLibro.Enabled = false;

                // Verificar si tiene ejemplares asociados
                var respEjemplares = await SupabaseService.Client.From<Ejemplar>()
                    .Where(x => x.LibroId == _libroSeleccionadoId.Value).Get();

                if (respEjemplares.Models.Count > 0)
                {
                    var respuesta = MessageBox.Show(
                        $"Este libro tiene {respEjemplares.Models.Count} ejemplar(es) asociado(s). Si continúa, se eliminarán también dichos ejemplares.\n¿Desea continuar?",
                        "Ejemplares asociados",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (respuesta != DialogResult.Yes) return;

                    await SupabaseService.Client.From<Ejemplar>()
                        .Where(x => x.LibroId == _libroSeleccionadoId.Value).Delete();
                }

                await SupabaseService.Client.From<Libro>()
                    .Where(x => x.Id == _libroSeleccionadoId.Value).Delete();

                MessageBox.Show("Libro eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CargarLibrosAsync();
                await CargarDisponiblesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarFormularioLibro();
            }
        }

        // ---------- Insertar en tabla hija (ejemplares) ----------
        private async void btnGuardarEjemplar_Click(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedItem is not Libro libroSel)
            {
                MessageBox.Show("Seleccione un libro.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoBarras.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();

            if (codigo == "" || ubicacion == "" || cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos del ejemplar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardarEjemplar.Enabled = false;

                var ejemplar = new Ejemplar
                {
                    LibroId = libroSel.Id,
                    CodigoBarras = codigo,
                    Estado = cmbEstado.SelectedItem.ToString(),
                    Ubicacion = ubicacion
                };

                await SupabaseService.Client.From<Ejemplar>().Insert(ejemplar);

                MessageBox.Show("Ejemplar registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoBarras.Clear(); txtUbicacion.Clear();
                cmbEstado.SelectedIndex = 0;

                await CargarDisponiblesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el ejemplar:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardarEjemplar.Enabled = true;
            }
        }

        // ---------- Registrar lectores ----------
        private async void btnGuardarLector_Click(object sender, EventArgs e)
        {
            string nombre = txtLecNombre.Text.Trim();
            string apellido = txtLecApellido.Text.Trim();
            string correo = txtLecCorreo.Text.Trim();
            string telefono = txtLecTelefono.Text.Trim();

            if (nombre == "" || apellido == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Complete todos los campos del lector.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefono.Count(char.IsDigit) < 7)
            {
                MessageBox.Show("Ingrese un número de teléfono válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardarLector.Enabled = false;

                var lector = new Lector
                {
                    Nombre = $"{nombre} {apellido}".Trim(),
                    Correo = correo,
                    Telefono = telefono
                };

                await SupabaseService.Client.From<Lector>().Insert(lector);

                MessageBox.Show("Lector registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLecNombre.Clear(); txtLecApellido.Clear();
                txtLecCorreo.Clear(); txtLecTelefono.Clear();

                await CargarLectoresAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el lector:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardarLector.Enabled = true;
            }
        }

        private void dgvLectores_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargandoLectores) return;

            if (dgvLectores.CurrentRow?.DataBoundItem is Lector lector)
            {
                _lectorSeleccionadoId = lector.Id;
                txtLecNombre.Text = lector.Nombre ?? "";
                txtLecApellido.Text = lector.Apellido ?? "";
                txtLecCorreo.Text = lector.Correo ?? "";
                txtLecTelefono.Text = lector.Telefono ?? "";

                btnActualizarLector.Enabled = true;
                btnEliminarLector.Enabled = true;
                btnGuardarLector.Enabled = false;
            }
        }

        private void LimpiarFormularioLector()
        {
            _lectorSeleccionadoId = null;
            txtLecNombre.Clear();
            txtLecApellido.Clear();
            txtLecCorreo.Clear();
            txtLecTelefono.Clear();
            btnActualizarLector.Enabled = false;
            btnEliminarLector.Enabled = false;
            btnGuardarLector.Enabled = true;
            dgvLectores.ClearSelection();
        }

        private void btnLimpiarLector_Click(object sender, EventArgs e)
        {
            LimpiarFormularioLector();
        }

        // ---------- Actualizar lector ----------
        private async void btnActualizarLector_Click(object sender, EventArgs e)
        {
            if (!_lectorSeleccionadoId.HasValue)
            {
                MessageBox.Show("Seleccione un lector de la lista para actualizar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtLecNombre.Text.Trim();
            string apellido = txtLecApellido.Text.Trim();
            string correo = txtLecCorreo.Text.Trim();
            string telefono = txtLecTelefono.Text.Trim();

            if (nombre == "" || apellido == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Complete todos los campos del lector.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CorreoValido(correo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefono.Count(char.IsDigit) < 7)
            {
                MessageBox.Show("Ingrese un número de teléfono válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnActualizarLector.Enabled = false;
                btnEliminarLector.Enabled = false;

                var lector = new Lector
                {
                    Id = _lectorSeleccionadoId.Value,
                    Nombre = $"{nombre} {apellido}".Trim(),
                    Correo = correo,
                    Telefono = telefono
                };

                await SupabaseService.Client.From<Lector>().Update(lector);

                MessageBox.Show("Lector actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CargarLectoresAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el lector:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarFormularioLector();
            }
        }

        // ---------- Eliminar lector ----------
        private async void btnEliminarLector_Click(object sender, EventArgs e)
        {
            if (!_lectorSeleccionadoId.HasValue)
            {
                MessageBox.Show("Seleccione un lector de la lista para eliminar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al lector '{txtLecNombre.Text.Trim()} {txtLecApellido.Text.Trim()}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                btnActualizarLector.Enabled = false;
                btnEliminarLector.Enabled = false;

                await SupabaseService.Client.From<Lector>()
                    .Where(l => l.Id == _lectorSeleccionadoId.Value).Delete();

                MessageBox.Show("Lector eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CargarLectoresAsync();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("foreign key") || ex.Message.Contains("violates"))
                {
                    MessageBox.Show("No se puede eliminar el lector porque tiene registros relacionados (préstamos) en el sistema.",
                        "Restricción de integridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el lector:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                LimpiarFormularioLector();
            }
        }

        private static bool CorreoValido(string correo)
        {
            try
            {
                var m = new MailAddress(correo);
                return m.Address == correo && correo.Contains('.');
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // ---------- Lista de libros disponibles ----------
        private async void btnActualizarDisponibles_Click(object sender, EventArgs e)
        {
            await ActualizarDisponiblesSeguroAsync();
        }

        private async void chkSoloDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            // Se dispara al construir el formulario; solo actuamos si ya hay conexión.
            if (SupabaseService.Client == null) return;
            await ActualizarDisponiblesSeguroAsync();
        }

        private async Task ActualizarDisponiblesSeguroAsync()
        {
            try
            {
                await CargarDisponiblesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de libros:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
