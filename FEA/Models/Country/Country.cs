namespace FEA.Models.Country;

public class Country
{
    public static readonly List<Country> Data = new()
    {
        new() { Name = "Canada" },
        new() { Name = "Albania" },
        new() { Name = "Cuba" }
    };

    public int Id { get; set; }
    public string Name { get; set; }
}
