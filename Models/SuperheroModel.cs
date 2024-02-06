namespace MySuperheroRazorApp.Models
{
    public class SuperheroModel
    {
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Power { get; set; }
        public int Age { get; set; }
        public string? ImageUrl { get; set; }
    }
}
