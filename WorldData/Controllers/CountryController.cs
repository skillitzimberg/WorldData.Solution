using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldData.Models;

namespace WorldData.Controllers
{
  public class CountryController : Controller
  {
    [HttpGet("/Country")]
    public ActionResult Index()
    {
      List<Country> allCountries = Country.GetAll();
      return View(allCountries);
    }

    [HttpGet("/Country/{code}/Show")]
    public ActionResult Show(string code)
    {
      List<Country> allCountries = Country.GetAll();
      Country foundCountry = allCountries.Find(code);
      return View(foundCountry);
    }

    // POTENTIALLY FOR ASSOCIATING COUNTRIES AND CITIES
    // [HttpGet("/country/{code}")]
    // public ActionResult Show(string countryCode)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Country selectedCountry = Country.Find(countryCode);
    //   List<City> countryCities = foundCountry.GetCity();
    //
    //   City newCity = new City(itemDescription);
    //   foundCountry.AddCity(newCity);
    //   model.Add("city", categoryCity);
    //   model.Add("country", foundCountry);
    //   return View("Show", model);
    // }

  }
}
