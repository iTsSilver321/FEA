using System.ComponentModel.DataAnnotations.Schema;

namespace FEA.Models.City;

public class City
{
    public static readonly List<City> Data = new()
    {
        new() { Name = "Vancouver", CountryId = 1 },
        new() { Name = "Ottawa", CountryId = 1 },
        new() { Name = "Tirana", CountryId = 2 },
        new() { Name = "Havana", CountryId = 3 }
    };
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }
}
