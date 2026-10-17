using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace BibliotecaApp.Models
{
    // Tabla PADRE
    [Table("libros")]
    public class Libro : BaseModel
    {
        // false = el id lo genera la base de datos (identity), no se envía en el INSERT
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("isbn")]
        public string Isbn { get; set; }

        [Column("anio_publicacion")]
        public int AnioPublicacion { get; set; }

        [Column("editorial")]
        public string Editorial { get; set; }

        // Para mostrarlo en el ComboBox
        public override string ToString() => $"{Titulo} ({Isbn})";
    }
}
