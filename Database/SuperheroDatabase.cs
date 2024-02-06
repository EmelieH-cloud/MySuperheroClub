using MySuperheroRazorApp.Models;

namespace MySuperheroRazorApp.Database
{
    public static class SuperheroDatabase
    {
        public static List<SuperheroModel> Superheroes { get; } = new List<SuperheroModel>
        {
            new SuperheroModel { Name = "Clark Kent", Alias = "Superman", Power = "superhuman strength, speed, and durability", Age = 35 },
            new SuperheroModel { Name = "Bruce Wayne", Alias = "Batman", Power = "genius-level intellect, martial arts skills, gadgets", Age = 40 },
            new SuperheroModel { Name = "Diana Prince", Alias = "Wonder Woman", Power = "superhuman strength, agility, and combat prowess", Age = 3000 },
            new SuperheroModel { Name = "Peter Parker", Alias = "Spider-Man", Power = "wall-crawling, superhuman strength, spider-sense", Age = 25 },
            new SuperheroModel { Name = "Tony Stark", Alias = "Iron Man", Power = "powered armor suit, genius-level intellect", Age = 45 },
            new SuperheroModel { Name = "Barry Allen", Alias = "The Flash", Power = "superhuman speed, time manipulation", Age = 30 },
            new SuperheroModel { Name = "Arthur Curry", Alias = "Aquaman", Power = "superhuman strength, underwater adaptation, telepathic control of marine life", Age = 35 },
            new SuperheroModel { Name = "Jean Grey", Alias = "Phoenix", Power = "telepathy, telekinesis, cosmic entity", Age = 30 },
            new SuperheroModel { Name = "Bruce Banner", Alias = "The Hulk", Power = "superhuman strength, durability, regeneration", Age = 40 },
            new SuperheroModel { Name = "Steve Rogers", Alias = "Captain America", Power = "peak human strength, agility, shield mastery", Age = 100 }

        };
    }
}