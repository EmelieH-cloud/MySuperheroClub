using Microsoft.AspNetCore.Mvc.RazorPages;
using MySuperheroRazorApp.Database;
using MySuperheroRazorApp.Models;

namespace MySuperheroRazorApp.Pages.Superheroes
{
    public class IndexModel : PageModel
    {
        public List<SuperheroModel> Superheroes { get; set; } = null!;
        public void OnGet()
        {
            Superheroes = SuperheroDatabase.Superheroes;
        }
    }
}
