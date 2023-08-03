namespace FEA.Models.Country;

public class Country
{
    public static readonly List<Country> Data = new()
    {
        new() { Id = 1, Name = "Canada" },
        new() { Id = 2, Name = "Albania" },
        new() { Id = 3, Name = "Cuba" }
    };

    public int Id { get; set; }
    public string Name { get; set; }
}