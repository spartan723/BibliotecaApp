namespace BibliotecaApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabLibros = new TabPage();
            btnGuardarLibro = new Button();
            btnActualizarLibro = new Button();
            btnEliminarLibro = new Button();
            btnLimpiarLibro = new Button();
            dgvLibros = new DataGridView();
            colLibId = new DataGridViewTextBoxColumn();
            colLibTitulo = new DataGridViewTextBoxColumn();
            colLibIsbn = new DataGridViewTextBoxColumn();
            colLibEditorial = new DataGridViewTextBoxColumn();
            colLibAnio = new DataGridViewTextBoxColumn();
            txtEditorial = new TextBox();
            lblEditorial = new Label();
            txtAnio = new TextBox();
            lblAnio = new Label();
            txtIsbn = new TextBox();
            lblIsbn = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            tabEjemplares = new TabPage();
            btnGuardarEjemplar = new Button();
            txtUbicacion = new TextBox();
            lblUbicacion = new Label();
            cmbEstado = new ComboBox();
            lblEstadoEjemplar = new Label();
            txtCodigoBarras = new TextBox();
            lblCodigoBarras = new Label();
            cmbLibro = new ComboBox();
            lblLibro = new Label();
            tabLectores = new TabPage();
            dgvLectores = new DataGridView();
            colLecId = new DataGridViewTextBoxColumn();
            colLecNombre = new DataGridViewTextBoxColumn();
            colLecApellido = new DataGridViewTextBoxColumn();
            colLecCorreo = new DataGridViewTextBoxColumn();
            colLecTelefono = new DataGridViewTextBoxColumn();
            btnGuardarLector = new Button();
            btnActualizarLector = new Button();
            btnEliminarLector = new Button();
            btnLimpiarLector = new Button();
            txtLecTelefono = new TextBox();
            lblLecTelefono = new Label();
            txtLecCorreo = new TextBox();
            lblLecCorreo = new Label();
            txtLecApellido = new TextBox();
            lblLecApellido = new Label();
            txtLecNombre = new TextBox();
            lblLecNombre = new Label();
            tabDisponibles = new TabPage();
            dgvDisponibles = new DataGridView();
            colDisTitulo = new DataGridViewTextBoxColumn();
            colDisIsbn = new DataGridViewTextBoxColumn();
            colDisEditorial = new DataGridViewTextBoxColumn();
            colDisAnio = new DataGridViewTextBoxColumn();
            colDisDisponibles = new DataGridViewTextBoxColumn();
            colDisTotal = new DataGridViewTextBoxColumn();
            btnActualizarDisponibles = new Button();
            chkSoloDisponibles = new CheckBox();
            lblEstadoConexion = new Label();
            tabControl.SuspendLayout();
            tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabEjemplares.SuspendLayout();
            tabLectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLectores).BeginInit();
            tabDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibles).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabLibros);
            tabControl.Controls.Add(tabEjemplares);
            tabControl.Controls.Add(tabLectores);
            tabControl.Controls.Add(tabDisponibles);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(684, 457);
            tabControl.TabIndex = 0;
            // 
            // tabLibros
            // 
            tabLibros.Controls.Add(dgvLibros);
            tabLibros.Controls.Add(btnLimpiarLibro);
            tabLibros.Controls.Add(btnEliminarLibro);
            tabLibros.Controls.Add(btnActualizarLibro);
            tabLibros.Controls.Add(btnGuardarLibro);
            tabLibros.Controls.Add(txtEditorial);
            tabLibros.Controls.Add(lblEditorial);
            tabLibros.Controls.Add(txtAnio);
            tabLibros.Controls.Add(lblAnio);
            tabLibros.Controls.Add(txtIsbn);
            tabLibros.Controls.Add(lblIsbn);
            tabLibros.Controls.Add(txtTitulo);
            tabLibros.Controls.Add(lblTitulo);
            tabLibros.Location = new Point(4, 24);
            tabLibros.Name = "tabLibros";
            tabLibros.Padding = new Padding(3);
            tabLibros.Size = new Size(676, 429);
            tabLibros.TabIndex = 0;
            tabLibros.Text = "Libros";
            tabLibros.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(39, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(150, 20);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(300, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(20, 64);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(35, 15);
            lblIsbn.TabIndex = 2;
            lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(150, 60);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(300, 23);
            txtIsbn.TabIndex = 3;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(20, 104);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(104, 15);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año publicación:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(150, 100);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(300, 23);
            txtAnio.TabIndex = 5;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(20, 144);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(58, 15);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(150, 140);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(300, 23);
            txtEditorial.TabIndex = 7;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.Enabled = false;
            btnGuardarLibro.Location = new Point(150, 180);
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.Size = new Size(120, 30);
            btnGuardarLibro.TabIndex = 8;
            btnGuardarLibro.Text = "Guardar libro";
            btnGuardarLibro.UseVisualStyleBackColor = true;
            btnGuardarLibro.Click += btnGuardarLibro_Click;
            // 
            // btnActualizarLibro
            // 
            btnActualizarLibro.Enabled = false;
            btnActualizarLibro.Location = new Point(280, 180);
            btnActualizarLibro.Name = "btnActualizarLibro";
            btnActualizarLibro.Size = new Size(110, 30);
            btnActualizarLibro.TabIndex = 9;
            btnActualizarLibro.Text = "Actualizar";
            btnActualizarLibro.UseVisualStyleBackColor = true;
            btnActualizarLibro.Click += btnActualizarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Enabled = false;
            btnEliminarLibro.Location = new Point(400, 180);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(110, 30);
            btnEliminarLibro.TabIndex = 10;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnLimpiarLibro
            // 
            btnLimpiarLibro.Location = new Point(520, 180);
            btnLimpiarLibro.Name = "btnLimpiarLibro";
            btnLimpiarLibro.Size = new Size(110, 30);
            btnLimpiarLibro.TabIndex = 11;
            btnLimpiarLibro.Text = "Limpiar";
            btnLimpiarLibro.UseVisualStyleBackColor = true;
            btnLimpiarLibro.Click += btnLimpiarLibro_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { colLibId, colLibTitulo, colLibIsbn, colLibEditorial, colLibAnio });
            dgvLibros.Location = new Point(20, 225);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(636, 185);
            dgvLibros.TabIndex = 12;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            // 
            // colLibId
            // 
            colLibId.DataPropertyName = "Id";
            colLibId.FillWeight = 30F;
            colLibId.HeaderText = "ID";
            colLibId.Name = "colLibId";
            colLibId.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo.DataPropertyName = "Titulo";
            colLibTitulo.FillWeight = 150F;
            colLibTitulo.HeaderText = "Título";
            colLibTitulo.Name = "colLibTitulo";
            colLibTitulo.ReadOnly = true;
            // 
            // colLibIsbn
            // 
            colLibIsbn.DataPropertyName = "Isbn";
            colLibIsbn.FillWeight = 80F;
            colLibIsbn.HeaderText = "ISBN";
            colLibIsbn.Name = "colLibIsbn";
            colLibIsbn.ReadOnly = true;
            // 
            // colLibEditorial
            // 
            colLibEditorial.DataPropertyName = "Editorial";
            colLibEditorial.FillWeight = 100F;
            colLibEditorial.HeaderText = "Editorial";
            colLibEditorial.Name = "colLibEditorial";
            colLibEditorial.ReadOnly = true;
            // 
            // colLibAnio
            // 
            colLibAnio.DataPropertyName = "AnioPublicacion";
            colLibAnio.FillWeight = 50F;
            colLibAnio.HeaderText = "Año";
            colLibAnio.Name = "colLibAnio";
            colLibAnio.ReadOnly = true;
            //
            // tabEjemplares
            //
            tabEjemplares.Controls.Add(btnGuardarEjemplar);
            tabEjemplares.Controls.Add(txtUbicacion);
            tabEjemplares.Controls.Add(lblUbicacion);
            tabEjemplares.Controls.Add(cmbEstado);
            tabEjemplares.Controls.Add(lblEstadoEjemplar);
            tabEjemplares.Controls.Add(txtCodigoBarras);
            tabEjemplares.Controls.Add(lblCodigoBarras);
            tabEjemplares.Controls.Add(cmbLibro);
            tabEjemplares.Controls.Add(lblLibro);
            tabEjemplares.Location = new Point(4, 24);
            tabEjemplares.Name = "tabEjemplares";
            tabEjemplares.Padding = new Padding(3);
            tabEjemplares.Size = new Size(676, 429);
            tabEjemplares.TabIndex = 1;
            tabEjemplares.Text = "Ejemplares";
            tabEjemplares.UseVisualStyleBackColor = true;
            //
            // lblLibro
            //
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(20, 24);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(36, 15);
            lblLibro.TabIndex = 0;
            lblLibro.Text = "Libro:";
            //
            // cmbLibro
            //
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(150, 20);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(300, 23);
            cmbLibro.TabIndex = 1;
            //
            // lblCodigoBarras
            //
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Location = new Point(20, 64);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(104, 15);
            lblCodigoBarras.TabIndex = 2;
            lblCodigoBarras.Text = "Código de barras:";
            //
            // txtCodigoBarras
            //
            txtCodigoBarras.Location = new Point(150, 60);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(300, 23);
            txtCodigoBarras.TabIndex = 3;
            //
            // lblEstadoEjemplar
            //
            lblEstadoEjemplar.AutoSize = true;
            lblEstadoEjemplar.Location = new Point(20, 104);
            lblEstadoEjemplar.Name = "lblEstadoEjemplar";
            lblEstadoEjemplar.Size = new Size(45, 15);
            lblEstadoEjemplar.TabIndex = 4;
            lblEstadoEjemplar.Text = "Estado:";
            //
            // cmbEstado
            //
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "Prestado", "Dañado", "Perdido" });
            cmbEstado.Location = new Point(150, 100);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(300, 23);
            cmbEstado.TabIndex = 5;
            //
            // lblUbicacion
            //
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(20, 144);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(62, 15);
            lblUbicacion.TabIndex = 6;
            lblUbicacion.Text = "Ubicación:";
            //
            // txtUbicacion
            //
            txtUbicacion.Location = new Point(150, 140);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(300, 23);
            txtUbicacion.TabIndex = 7;
            //
            // btnGuardarEjemplar
            //
            btnGuardarEjemplar.Enabled = false;
            btnGuardarEjemplar.Location = new Point(150, 190);
            btnGuardarEjemplar.Name = "btnGuardarEjemplar";
            btnGuardarEjemplar.Size = new Size(140, 30);
            btnGuardarEjemplar.TabIndex = 8;
            btnGuardarEjemplar.Text = "Guardar ejemplar";
            btnGuardarEjemplar.UseVisualStyleBackColor = true;
            btnGuardarEjemplar.Click += btnGuardarEjemplar_Click;
            //
            // tabLectores
            //
            tabLectores.Controls.Add(dgvLectores);
            tabLectores.Controls.Add(btnLimpiarLector);
            tabLectores.Controls.Add(btnEliminarLector);
            tabLectores.Controls.Add(btnActualizarLector);
            tabLectores.Controls.Add(btnGuardarLector);
            tabLectores.Controls.Add(txtLecTelefono);
            tabLectores.Controls.Add(lblLecTelefono);
            tabLectores.Controls.Add(txtLecCorreo);
            tabLectores.Controls.Add(lblLecCorreo);
            tabLectores.Controls.Add(txtLecApellido);
            tabLectores.Controls.Add(lblLecApellido);
            tabLectores.Controls.Add(txtLecNombre);
            tabLectores.Controls.Add(lblLecNombre);
            tabLectores.Location = new Point(4, 24);
            tabLectores.Name = "tabLectores";
            tabLectores.Padding = new Padding(3);
            tabLectores.Size = new Size(676, 429);
            tabLectores.TabIndex = 2;
            tabLectores.Text = "Lectores";
            tabLectores.UseVisualStyleBackColor = true;
            //
            // lblLecNombre
            //
            lblLecNombre.AutoSize = true;
            lblLecNombre.Location = new Point(20, 24);
            lblLecNombre.Name = "lblLecNombre";
            lblLecNombre.Size = new Size(54, 15);
            lblLecNombre.TabIndex = 0;
            lblLecNombre.Text = "Nombre:";
            //
            // txtLecNombre
            //
            txtLecNombre.Location = new Point(150, 20);
            txtLecNombre.Name = "txtLecNombre";
            txtLecNombre.Size = new Size(300, 23);
            txtLecNombre.TabIndex = 1;
            //
            // lblLecApellido
            //
            lblLecApellido.AutoSize = true;
            lblLecApellido.Location = new Point(20, 64);
            lblLecApellido.Name = "lblLecApellido";
            lblLecApellido.Size = new Size(54, 15);
            lblLecApellido.TabIndex = 2;
            lblLecApellido.Text = "Apellido:";
            //
            // txtLecApellido
            //
            txtLecApellido.Location = new Point(150, 60);
            txtLecApellido.Name = "txtLecApellido";
            txtLecApellido.Size = new Size(300, 23);
            txtLecApellido.TabIndex = 3;
            //
            // lblLecCorreo
            //
            lblLecCorreo.AutoSize = true;
            lblLecCorreo.Location = new Point(20, 104);
            lblLecCorreo.Name = "lblLecCorreo";
            lblLecCorreo.Size = new Size(46, 15);
            lblLecCorreo.TabIndex = 4;
            lblLecCorreo.Text = "Correo:";
            //
            // txtLecCorreo
            //
            txtLecCorreo.Location = new Point(150, 100);
            txtLecCorreo.Name = "txtLecCorreo";
            txtLecCorreo.Size = new Size(300, 23);
            txtLecCorreo.TabIndex = 5;
            //
            // lblLecTelefono
            //
            lblLecTelefono.AutoSize = true;
            lblLecTelefono.Location = new Point(20, 144);
            lblLecTelefono.Name = "lblLecTelefono";
            lblLecTelefono.Size = new Size(56, 15);
            lblLecTelefono.TabIndex = 6;
            lblLecTelefono.Text = "Teléfono:";
            //
            // txtLecTelefono
            //
            txtLecTelefono.Location = new Point(150, 140);
            txtLecTelefono.Name = "txtLecTelefono";
            txtLecTelefono.Size = new Size(300, 23);
            txtLecTelefono.TabIndex = 7;
            //
            // btnGuardarLector
            //
            btnGuardarLector.Enabled = false;
            btnGuardarLector.Location = new Point(150, 180);
            btnGuardarLector.Name = "btnGuardarLector";
            btnGuardarLector.Size = new Size(120, 30);
            btnGuardarLector.TabIndex = 8;
            btnGuardarLector.Text = "Registrar lector";
            btnGuardarLector.UseVisualStyleBackColor = true;
            btnGuardarLector.Click += btnGuardarLector_Click;
            // 
            // btnActualizarLector
            // 
            btnActualizarLector.Enabled = false;
            btnActualizarLector.Location = new Point(280, 180);
            btnActualizarLector.Name = "btnActualizarLector";
            btnActualizarLector.Size = new Size(110, 30);
            btnActualizarLector.TabIndex = 9;
            btnActualizarLector.Text = "Actualizar";
            btnActualizarLector.UseVisualStyleBackColor = true;
            btnActualizarLector.Click += btnActualizarLector_Click;
            // 
            // btnEliminarLector
            // 
            btnEliminarLector.Enabled = false;
            btnEliminarLector.Location = new Point(400, 180);
            btnEliminarLector.Name = "btnEliminarLector";
            btnEliminarLector.Size = new Size(110, 30);
            btnEliminarLector.TabIndex = 10;
            btnEliminarLector.Text = "Eliminar";
            btnEliminarLector.UseVisualStyleBackColor = true;
            btnEliminarLector.Click += btnEliminarLector_Click;
            // 
            // btnLimpiarLector
            // 
            btnLimpiarLector.Location = new Point(520, 180);
            btnLimpiarLector.Name = "btnLimpiarLector";
            btnLimpiarLector.Size = new Size(110, 30);
            btnLimpiarLector.TabIndex = 11;
            btnLimpiarLector.Text = "Limpiar";
            btnLimpiarLector.UseVisualStyleBackColor = true;
            btnLimpiarLector.Click += btnLimpiarLector_Click;
            //
            // dgvLectores
            //
            dgvLectores.AllowUserToAddRows = false;
            dgvLectores.AllowUserToDeleteRows = false;
            dgvLectores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLectores.AutoGenerateColumns = false;
            dgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLectores.Columns.AddRange(new DataGridViewColumn[] { colLecId, colLecNombre, colLecApellido, colLecCorreo, colLecTelefono });
            dgvLectores.Location = new Point(20, 225);
            dgvLectores.Name = "dgvLectores";
            dgvLectores.ReadOnly = true;
            dgvLectores.RowHeadersVisible = false;
            dgvLectores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLectores.Size = new Size(636, 185);
            dgvLectores.TabIndex = 12;
            dgvLectores.SelectionChanged += dgvLectores_SelectionChanged;
            //
            // colLecId
            //
            colLecId.DataPropertyName = "Id";
            colLecId.FillWeight = 30F;
            colLecId.HeaderText = "ID";
            colLecId.Name = "colLecId";
            colLecId.ReadOnly = true;
            //
            // colLecNombre
            //
            colLecNombre.DataPropertyName = "Nombre";
            colLecNombre.HeaderText = "Nombre";
            colLecNombre.Name = "colLecNombre";
            colLecNombre.ReadOnly = true;
            //
            // colLecApellido
            //
            colLecApellido.DataPropertyName = "Apellido";
            colLecApellido.HeaderText = "Apellido";
            colLecApellido.Name = "colLecApellido";
            colLecApellido.ReadOnly = true;
            //
            // colLecCorreo
            //
            colLecCorreo.DataPropertyName = "Correo";
            colLecCorreo.FillWeight = 130F;
            colLecCorreo.HeaderText = "Correo";
            colLecCorreo.Name = "colLecCorreo";
            colLecCorreo.ReadOnly = true;
            //
            // colLecTelefono
            //
            colLecTelefono.DataPropertyName = "Telefono";
            colLecTelefono.HeaderText = "Teléfono";
            colLecTelefono.Name = "colLecTelefono";
            colLecTelefono.ReadOnly = true;
            //
            // tabDisponibles
            //
            tabDisponibles.Controls.Add(dgvDisponibles);
            tabDisponibles.Controls.Add(btnActualizarDisponibles);
            tabDisponibles.Controls.Add(chkSoloDisponibles);
            tabDisponibles.Location = new Point(4, 24);
            tabDisponibles.Name = "tabDisponibles";
            tabDisponibles.Padding = new Padding(3);
            tabDisponibles.Size = new Size(676, 429);
            tabDisponibles.TabIndex = 3;
            tabDisponibles.Text = "Libros disponibles";
            tabDisponibles.UseVisualStyleBackColor = true;
            //
            // chkSoloDisponibles
            //
            chkSoloDisponibles.AutoSize = true;
            chkSoloDisponibles.Checked = true;
            chkSoloDisponibles.CheckState = CheckState.Checked;
            chkSoloDisponibles.Location = new Point(20, 20);
            chkSoloDisponibles.Name = "chkSoloDisponibles";
            chkSoloDisponibles.Size = new Size(285, 19);
            chkSoloDisponibles.TabIndex = 0;
            chkSoloDisponibles.Text = "Mostrar solo libros con ejemplares disponibles";
            chkSoloDisponibles.UseVisualStyleBackColor = true;
            chkSoloDisponibles.CheckedChanged += chkSoloDisponibles_CheckedChanged;
            //
            // btnActualizarDisponibles
            //
            btnActualizarDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizarDisponibles.Enabled = false;
            btnActualizarDisponibles.Location = new Point(516, 14);
            btnActualizarDisponibles.Name = "btnActualizarDisponibles";
            btnActualizarDisponibles.Size = new Size(140, 30);
            btnActualizarDisponibles.TabIndex = 1;
            btnActualizarDisponibles.Text = "Actualizar lista";
            btnActualizarDisponibles.UseVisualStyleBackColor = true;
            btnActualizarDisponibles.Click += btnActualizarDisponibles_Click;
            //
            // dgvDisponibles
            //
            dgvDisponibles.AllowUserToAddRows = false;
            dgvDisponibles.AllowUserToDeleteRows = false;
            dgvDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisponibles.AutoGenerateColumns = false;
            dgvDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisponibles.Columns.AddRange(new DataGridViewColumn[] { colDisTitulo, colDisIsbn, colDisEditorial, colDisAnio, colDisDisponibles, colDisTotal });
            dgvDisponibles.Location = new Point(20, 55);
            dgvDisponibles.Name = "dgvDisponibles";
            dgvDisponibles.ReadOnly = true;
            dgvDisponibles.RowHeadersVisible = false;
            dgvDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisponibles.Size = new Size(636, 355);
            dgvDisponibles.TabIndex = 2;
            //
            // colDisTitulo
            //
            colDisTitulo.DataPropertyName = "Titulo";
            colDisTitulo.FillWeight = 160F;
            colDisTitulo.HeaderText = "Título";
            colDisTitulo.Name = "colDisTitulo";
            colDisTitulo.ReadOnly = true;
            //
            // colDisIsbn
            //
            colDisIsbn.DataPropertyName = "Isbn";
            colDisIsbn.HeaderText = "ISBN";
            colDisIsbn.Name = "colDisIsbn";
            colDisIsbn.ReadOnly = true;
            //
            // colDisEditorial
            //
            colDisEditorial.DataPropertyName = "Editorial";
            colDisEditorial.HeaderText = "Editorial";
            colDisEditorial.Name = "colDisEditorial";
            colDisEditorial.ReadOnly = true;
            //
            // colDisAnio
            //
            colDisAnio.DataPropertyName = "AnioPublicacion";
            colDisAnio.FillWeight = 60F;
            colDisAnio.HeaderText = "Año";
            colDisAnio.Name = "colDisAnio";
            colDisAnio.ReadOnly = true;
            //
            // colDisDisponibles
            //
            colDisDisponibles.DataPropertyName = "Disponibles";
            colDisDisponibles.FillWeight = 70F;
            colDisDisponibles.HeaderText = "Disponibles";
            colDisDisponibles.Name = "colDisDisponibles";
            colDisDisponibles.ReadOnly = true;
            //
            // colDisTotal
            //
            colDisTotal.DataPropertyName = "TotalEjemplares";
            colDisTotal.FillWeight = 60F;
            colDisTotal.HeaderText = "Total";
            colDisTotal.Name = "colDisTotal";
            colDisTotal.ReadOnly = true;
            //
            // lblEstadoConexion
            //
            lblEstadoConexion.Dock = DockStyle.Bottom;
            lblEstadoConexion.Location = new Point(0, 457);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(684, 24);
            lblEstadoConexion.TabIndex = 1;
            lblEstadoConexion.Text = "Conectando...";
            lblEstadoConexion.TextAlign = ContentAlignment.MiddleLeft;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 481);
            Controls.Add(tabControl);
            Controls.Add(lblEstadoConexion);
            MinimumSize = new Size(640, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Bibliotecaria";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabLibros.ResumeLayout(false);
            tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabEjemplares.ResumeLayout(false);
            tabEjemplares.PerformLayout();
            tabLectores.ResumeLayout(false);
            tabLectores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLectores).EndInit();
            tabDisponibles.ResumeLayout(false);
            tabDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabLibros;
        private TabPage tabEjemplares;
        private TabPage tabLectores;
        private TabPage tabDisponibles;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private Label lblAnio;
        private TextBox txtAnio;
        private Label lblEditorial;
        private TextBox txtEditorial;
        private Button btnGuardarLibro;
        private Button btnActualizarLibro;
        private Button btnEliminarLibro;
        private Button btnLimpiarLibro;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn colLibId;
        private DataGridViewTextBoxColumn colLibTitulo;
        private DataGridViewTextBoxColumn colLibIsbn;
        private DataGridViewTextBoxColumn colLibEditorial;
        private DataGridViewTextBoxColumn colLibAnio;
        private Label lblLibro;
        private ComboBox cmbLibro;
        private Label lblCodigoBarras;
        private TextBox txtCodigoBarras;
        private Label lblEstadoEjemplar;
        private ComboBox cmbEstado;
        private Label lblUbicacion;
        private TextBox txtUbicacion;
        private Button btnGuardarEjemplar;
        private Label lblLecNombre;
        private TextBox txtLecNombre;
        private Label lblLecApellido;
        private TextBox txtLecApellido;
        private Label lblLecCorreo;
        private TextBox txtLecCorreo;
        private Label lblLecTelefono;
        private TextBox txtLecTelefono;
        private Button btnGuardarLector;
        private Button btnActualizarLector;
        private Button btnEliminarLector;
        private Button btnLimpiarLector;
        private DataGridView dgvLectores;
        private DataGridViewTextBoxColumn colLecId;
        private DataGridViewTextBoxColumn colLecNombre;
        private DataGridViewTextBoxColumn colLecApellido;
        private DataGridViewTextBoxColumn colLecCorreo;
        private DataGridViewTextBoxColumn colLecTelefono;
        private CheckBox chkSoloDisponibles;
        private Button btnActualizarDisponibles;
        private DataGridView dgvDisponibles;
        private DataGridViewTextBoxColumn colDisTitulo;
        private DataGridViewTextBoxColumn colDisIsbn;
        private DataGridViewTextBoxColumn colDisEditorial;
        private DataGridViewTextBoxColumn colDisAnio;
        private DataGridViewTextBoxColumn colDisDisponibles;
        private DataGridViewTextBoxColumn colDisTotal;
        private Label lblEstadoConexion;
    }
}
