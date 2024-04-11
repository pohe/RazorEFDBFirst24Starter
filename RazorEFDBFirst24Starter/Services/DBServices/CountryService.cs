using RazorEFDBFirst24Starter.Interfaces;
using RazorEFDBFirst24Starter.Models;

namespace RazorEFDBFirst24Starter.Services.DBServices
{
    public class CountryService : ICountryService
    {
        private EventMakerDB24Context _context;

        public CountryService(EventMakerDB24Context context)
        {
            _context = context;
        }

        public void AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void DeleteCountry(string code)
        {
            Country countryToRemove =_context.Countries.Find(code);
            if (countryToRemove != null)
            {
                _context.Countries.Remove(countryToRemove);
                _context.SaveChanges();
            }
        }

        public List<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(string code)
        {
            throw new NotImplementedException();
        }
    }
}
