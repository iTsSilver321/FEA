using FEA.Data;
using FEA.Models.City;
using FEA.Models.Country;
using FEA.Models.Hotel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FEA.Controllers;

[ApiController]
[Route("/api/vacation")]
public class VacationController : ControllerBase
{
    [HttpGet("countries")]
    public IActionResult GetCountries([FromServices] ApplicationDbContext context)
    {
        var countries = context.Countries.ToList();
        return Ok(countries);
    }

    [HttpPost("countries")]
    public IActionResult CreateCountry(Country country, [FromServices] ApplicationDbContext context)
    {
        context.Countries.Add(country);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetCountries), new { Country = country.Name }, country);
    }

    [HttpGet("countries/{countryId}/cities")]
    public IActionResult GetCities(int countryId)
    {
        var cities = City.Data.FindAll(c => c.CountryId == countryId);
        return Ok(cities);
    }

    [HttpPost("cities")]
    public IActionResult CreateCity([FromServices] ApplicationDbContext context, City city)
    {
        context.Cities.Add(city);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetCities), new { countryId = city.CountryId }, city);
    }

    [HttpGet("cities/{cityId}/hotels")]
    public IActionResult GetHotels(int cityId)
    {
        var hotels = Hotel.Data.FindAll(h => h.CityId == cityId);
        return Ok(hotels);
    }

    [HttpPost("hotels")]
    public IActionResult CreateHotel([FromServices] ApplicationDbContext context, Hotel hotel)
    {
        context.Hotels.Add(hotel);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetHotels), new { cityId = hotel.CityId }, hotel);
    }
    
    [Authorize(Roles = "Admin")]
        [HttpPut("countries/{id}")]
        public IActionResult EditCountry(int id, Country country)
        {
            // Find the country with the specified id
            var existingCountry = Country.Data.FirstOrDefault(c => c.Id == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            // Update the country details
            existingCountry.Name = country.Name;

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("cities/{id}")]
        public IActionResult EditCity(int id, City city)
        {
            // Find the city with the specified id
            var existingCity = City.Data.FirstOrDefault(c => c.Id == id);
            if (existingCity == null)
            {
                return NotFound();
            }

            // Update the city details
            existingCity.Name = city.Name;
            existingCity.CountryId = city.CountryId;

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("hotels/{id}")]
        public IActionResult EditHotel(int id, Hotel hotel)
        {
            // Find the hotel with the specified id
            var existingHotel = Hotel.Data.FirstOrDefault(h => h.Id == id);
            if (existingHotel == null)
            {
                return NotFound();
            }

            // Update the hotel details
            existingHotel.Name = hotel.Name;
            existingHotel.CityId = hotel.CityId;
            existingHotel.Price = hotel.Price;
            existingHotel.Description = hotel.Description;
            existingHotel.Rating = hotel.Rating;
            existingHotel.FreeWifi = hotel.FreeWifi;
            existingHotel.HotTub = hotel.HotTub;
            existingHotel.PetFriendly = hotel.PetFriendly;
            existingHotel.Spa = hotel.Spa;
            existingHotel.Restaurant = hotel.Restaurant;

            return NoContent();
        }
}