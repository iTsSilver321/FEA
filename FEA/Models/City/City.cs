namespace FEA.Models.City;

public class City
{
    public static readonly List<City> Data = new()
    {
        new() { Id = 1, Name = "Vancouver", CountryId = 1 },
        new() { Id = 2, Name = "Ottawa", CountryId = 1 },
        new() { Id = 3, Name = "Tirana", CountryId = 2 },
        new() { Id = 4, Name = "Havana", CountryId = 3 }
    };

    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }
}