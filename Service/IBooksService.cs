using PruebaNewTechBlazor.Models;

public interface IBooksService
{
    Task<IEnumerable<Book>> GetBooks();
    Task<Book> GetBooksId(int id);
    Task<Book> PostBooks(Book book);
    Task<Book> PutBooks(Book book);
    Task DeleteBooksId(Book book);
}