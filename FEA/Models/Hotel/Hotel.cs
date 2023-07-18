namespace FEA.Models.Hotel;

public class Hotel
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public bool FreeWifi { get; set; }
    public bool HotTub { get; set; }
    public bool PetFriendly { get; set; }
    public bool Spa { get; set; }
    public bool Restaurant { get; set; }

    public static readonly List<Hotel> Data = new List<Hotel>
    {
        new Hotel
        {
            Id = 1,
            CityId = 1,
            Name = "Mirage Hotel",
            Price = 199.99,
            Description = "The Mirage Hotel & Casino is located in Vancouver Strip, " +
                          "a neighborhood in Las Vegas, " +
                          "and is on the Strip and near the airport. " +
                          "Mirage Volcano and Fountains of Bellagio are notable landmarks, " +
                          "and travelers looking to shop may want to visit Fashion Show Mall. " +
                          "Looking to enjoy an event or a game? See what's going on at MGM Grand Garden Arena, " +
                          "or consider Michelob Ultra Arena for a night out. " +
                          "Spend some time exploring the area's activities, including golfing.",
            Rating = 9.2,
            FreeWifi = true,
            HotTub = false,
            Restaurant = true,
            PetFriendly = false,
            Spa = true
        }
    };
}