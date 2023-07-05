namespace FEA.Models.City;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }

    public static readonly List<City> Cities = new List<City>
    {
        new City { Id = 1, Name = "Vancouver", CountryId = 1 },
        new City { Id = 2, Name = "Ottawa", CountryId = 1 },
        new City { Id = 3, Name = "Tirana", CountryId = 2},
        new City { Id = 4, Name = "Havana", CountryId = 3}
    };
}