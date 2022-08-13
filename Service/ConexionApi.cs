using Microsoft.AspNetCore.Components;
using PruebaNewTechBlazor.Models;

namespace PruebaNewTechBlazor.Service
{
    public class ConexionApi : IBooksService
    {
        public readonly HttpClient httpClient;

        public ConexionApi(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            
        }

        public Task DeleteBooksId(Book book)
        {
            return httpClient.DeleteAsync($"api/Books/{book.BookId}");
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await httpClient.GetJsonAsync<Book[]>("api/Books");
        }

        public async Task<Book> GetBooksId(int id)
        {
            return await httpClient.GetJsonAsync<Book>($"api/Books/{id}");
        }
      
        public async Task<Book> PostBooks(Book book)
        {
            return await httpClient.PostJsonAsync<Book>($"api/Books",book);
        }
       
        public async Task<Book> PutBooks(Book book)
        {
            await httpClient.PutAsJsonAsync($"api/Books/{book.BookId}",book);
            return book;
        }

        

        
    }
}