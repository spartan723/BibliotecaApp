using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace BibliotecaApp.Models
{
    // Tabla HIJA (tiene la llave foránea libro_id -> libros.id)
    [Table("ejemplares")]
    public class Ejemplar : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("libro_id")]
        public long LibroId { get; set; }

        [Column("codigo_inventario")]
        public string CodigoBarras { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        // En la base de datos no existe columna "ubicacion"
        public string Ubicacion { get; set; }
    }
}
