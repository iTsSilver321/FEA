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
    
    public static readonly List<Hotel> Data = new()
    {
        new()
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
        },
        
        new()
        {
            Id = 2,
            CityId = 2,
            Name = "The Grand Hotel",
            Price = 299.99,
            Description = "The Grand Hotel is located in the heart of Ottawa, " +
                          "and is within walking distance of many popular attractions. " +
                         "Parliament Hill and the National Gallery of Canada are notable landmarks, " +
                        "and travelers looking to shop may want to visit ByWard Market. " +
                         "Looking to enjoy an event or a game? See what's going on at TD Place Stadium, " +
                         "or consider Canadian Tire Centre for a night out. " +
                          "Spend some time exploring the area's activities, including golfing.",
            Rating = 9.5,
            FreeWifi = true,
            HotTub = true,
            Restaurant = true,
            PetFriendly = true,
            Spa = true 
        }, 
        
        new() 
        {
            Id = 3,
            CityId = 3,
            Name = "Tirana Palace",
            Price = 149.99,
            Description = "Tirana Palace is located in the heart of Tirana, " +
                        "and is within walking distance of many popular attractions. " +
                        "Skanderbeg Square and the National Museum of History are notable landmarks, " +
                         "and travelers looking to shop may want to visit Toptani Shopping Center. " +
                          "Looking to enjoy an event or a game? See what's going on at Selman Stermasi Stadium, " +
                       "or consider Mother Teresa Square for a night out. " +
                       "Spend some time exploring the area's activities, including golfing.",
            Rating = 8.9,
            FreeWifi = true,
            HotTub = false,
            Restaurant = true,
            PetFriendly = false,
            Spa = false
        }, 
        
        new() 
        {
            Id = 4,
            CityId = 4,
            Name = "Havana Resort",
            Price = 249.99,
            Description = "Havana Resort is located on the beach in Havana, " +
                         "and is within walking distance of many popular attractions. " +
                         "The Malecón and the Museum of the Revolution are notable landmarks, " + 
                         "and travelers looking to shop may want to visit San Rafael Boulevard. " +
                         "Looking to enjoy an event or a game? See what's going on at Estadio Latinoamericano, " +
                         "or consider Gran Teatro de La Habana for a night out. " +
                         "Spend some time exploring the area's activities, including golfing.",
            Rating = 9.1,
            FreeWifi = false,
            HotTub = true,
            Restaurant = true,
            PetFriendly = false,
            Spa = true 
        }
    };
}