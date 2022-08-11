namespace PruebaNewTechBlazor.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreAutor { get; set; } = string.Empty;
        public string Edicion { get; set; } = string.Empty;
        public Decimal Precio { get; set; } = 0;
    }
}