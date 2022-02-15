using System.Threading.Tasks;
using livraria.Books;
using livraria.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Web.Pages.Books
{
    public class CreateModalModel : livrariaPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}