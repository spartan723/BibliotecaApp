namespace BibliotecaApp.Models
{
    // Modelo solo de lectura para la lista de "Libros disponibles".
    // No es una tabla: se arma combinando libros + ejemplares.
    public class LibroDisponible
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }
        public int Disponibles { get; set; }
        public int TotalEjemplares { get; set; }
    }
}
