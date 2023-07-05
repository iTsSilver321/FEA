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
        return Ok(Country.Countries);
    }
    
    [HttpGet("countries/{countryId}/cities")]
    public IActionResult GetCities(int countryId)
    {
        var cities = City.Cities.FindAll(c => c.CountryId == countryId);
        return Ok(cities);
    }
    
    [HttpGet("cities/{cityId}/hotels")]
    public IActionResult GetHotels(int cityId)
    {
        var hotels = Hotel.Hotels.FindAll(h => h.CityId == cityId);
        return Ok(hotels);
    }
}