using Microsoft.AspNetCore.Mvc;
using WorldData.Models;

namespace WorldData.Controllers
{
    public class LanguageController : Controller
    {
        [Route("/Language")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
