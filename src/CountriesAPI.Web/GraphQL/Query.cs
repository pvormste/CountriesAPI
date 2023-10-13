using CountriesAPI.Web.Models;

namespace CountriesAPI.Web.GraphQL;

public class Query
{
    public List<Country?> GetCountries()
    {
        var countriesFromDb = Maddalena.Country.All;
        return countriesFromDb.Select(Country.FromDbModel).ToList();
    }
    
    public Country? GetCountry(string code)
    {
        var countryFromDb = Maddalena.Country.All.FirstOrDefault(x => code.ToUpper() == x.CountryCode.ToString());
        if (countryFromDb == null)
        {
            return null;
        }
        return Country.FromDbModel(countryFromDb);
    }
}