using Komis1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Komis1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;
        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;            
        }
        public IActionResult Index()
        {
            ViewBag.Tytul = "Przegląd Samochowów";

            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            return View(samochody);
        }
    }
}
