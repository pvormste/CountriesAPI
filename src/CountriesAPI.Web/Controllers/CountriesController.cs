using CountriesAPI.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CountriesAPI.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController
{
    [HttpGet(Name = "GetCountries")]
    public List<Country?> GetCountries()
    {
        var countriesFromDb = Maddalena.Country.All;
        return countriesFromDb.Select(Country.FromDbModel).ToList();
    }
}