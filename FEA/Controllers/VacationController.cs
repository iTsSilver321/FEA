using FEA.Models.City;
using FEA.Models.Country;
using FEA.Models.Hotel;
using Microsoft.AspNetCore.Mvc;

namespace FEA.Controllers;

[ApiController]
[Route("/api/vacation")]

public class VacationController : ControllerBase
{
    [HttpGet("countries")]
    public IActionResult GetCountries()
    {
        return Ok(Country.Data);
    }
    
    [HttpPost("countries")]
    public IActionResult CreateCountry(Country country)
    {
        country.Id = Country.Data.Count + 1;
        Country.Data.Add(country);
        return CreatedAtAction(nameof(GetCountries), new { id = country.Id }, country);
    }
    
    [HttpGet("countries/{countryId}/cities")]
    public IActionResult GetCities(int countryId)
    {
        var cities = City.Data.FindAll(c => c.CountryId == countryId);
        return Ok(cities);
    }
    
    [HttpPost("cities")]
    public IActionResult CreateCity(City city)
    {
        city.Id = City.Data.Count + 1;
        City.Data.Add(city);
        return CreatedAtAction(nameof(GetCities), new { countryId = city.CountryId }, city);
    }
    
    [HttpGet("cities/{cityId}/hotels")]
    public IActionResult GetHotels(int cityId)
    {
        var hotels = Hotel.Data.FindAll(h => h.CityId == cityId);
        return Ok(hotels);
    }
    
    [HttpPost("hotels")]
    public IActionResult CreateHotel(Hotel hotel)
    {
        hotel.Id = Hotel.Data.Count + 1;
        Hotel.Data.Add(hotel);
        return CreatedAtAction(nameof(GetHotels), new { cityId = hotel.CityId }, hotel);
    }
}