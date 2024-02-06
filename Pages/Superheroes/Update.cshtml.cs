using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySuperheroRazorApp.Database;
using MySuperheroRazorApp.Models;

namespace MySuperheroRazorApp.Pages.Superheroes
{
    public class UpdateModel : PageModel
    {
        public SuperheroModel? Superhero { get; set; }

        public IActionResult OnGet(string name)
        {
            Superhero = SuperheroDatabase.Superheroes.FirstOrDefault(s => s.Name == name);
            if (Superhero == null)
            {
                return NotFound();
            }
            return Page();
        }


    }
}