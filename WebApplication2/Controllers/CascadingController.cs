using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CascadingController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CascadingController( ApplicationDbContext dbContext )
        {
          _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var viewModel = new CountryCityViewModel
            {
                Countries = _dbContext.Countries.ToList(),
                Cities = new List<City>(),
            }; 
                
            return View(viewModel);
        }

        [HttpGet]
        public async Task<JsonResult> GetCities(int countryId)
        {
            var cities = await _dbContext.Cities.Where(c => c.CountryId == countryId).ToListAsync();
            return new JsonResult(cities);
        }
    }
}
