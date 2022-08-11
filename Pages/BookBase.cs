using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using PruebaNewTechBlazor.Models;

namespace PruebaNewTechBlazor.Pages
{
    public class BookBase : ComponentBase
    {
        [Inject]
        public IToastService? ToastService { get; set; }
        [Inject]
        public IBooksService? BooksService { get; set; }
        public List<Book>? BooksList { get; set; }
        public int BookId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            BooksList = (await BooksService!.GetBooks()).ToList();
        }

        public async void Buscar()
        {
            try
            {
                BooksList = new List<Book> {(await BooksService!.GetBooksId(BookId))};
                ToastService!.ShowInfo("encontrado");
            }
            catch (Exception exe)
            {
                ToastService!.ShowError("No se encotro el Book Id "+ BookId.ToString());
            }
        }
    }
}