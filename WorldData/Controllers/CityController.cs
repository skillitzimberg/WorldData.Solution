using Microsoft.AspNetCore.Mvc;
using WorldData.Models;
using System.Collections.Generic;

namespace WorldData.Controllers
{
    public class CityController : Controller
    {
        [HttpGet("/city")]
        public ActionResult Index()
        {
          List<City> allCities = City.GetAll();
          return View(allCities);
        }

    }
}
