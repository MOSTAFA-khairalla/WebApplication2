namespace WebApplication2.Models
{
    public class CountryCityViewModel
    {

        public int SelectedCountryId { get; set; }
        public int SelectedCityId { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }

    }
}
