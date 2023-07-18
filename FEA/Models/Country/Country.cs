namespace FEA.Models.Country;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }

    public static readonly List<Country> Data = new List<Country>
    {
        new Country { Id = 1, Name = "Canada" },
        new Country { Id = 2, Name = "Albania" },
        new Country { Id = 3, Name = "Cuba"}
    };
}