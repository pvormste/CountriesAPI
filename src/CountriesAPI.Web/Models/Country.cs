namespace CountriesAPI.Web.Models;

public class Country
{
    public required string Name { get; set; }
    public required string OfficialName { get; set; }
    public required string[] Tld { get; set; }
    public required string[] Currencies { get; set; }

    public static Country? FromDbModel(Maddalena.Country countryFromDb)
    {
        return new Country()
        {
            Name = countryFromDb.CommonName,
            OfficialName = countryFromDb.OfficialName,
            Tld = countryFromDb.TLD,
            Currencies = countryFromDb.Currencies
        };
    }
}