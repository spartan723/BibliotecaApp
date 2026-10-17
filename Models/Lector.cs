using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace BibliotecaApp.Models
{
    [Table("lectores")]
    public class Lector : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        // En la base de datos no existe columna "apellido"; se mantiene para la interfaz y DataGridView
        public string Apellido { get; set; }

        [Column("correo")]
        public string Correo { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }
    }
}
