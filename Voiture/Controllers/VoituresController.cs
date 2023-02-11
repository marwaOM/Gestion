using Microsoft.AspNetCore.Mvc;

namespace Voiture.Controllers
{
    public class VoituresController : Controller
    {
        public String Index()
        {
            return "liste des Voitures";
        }
        public IActionResult ListeCollectionneurs(string marque, int annee)
        {
            ViewData["Marque"] = marque;
            ViewData["Annee"] = annee;
            return View();
        }
    }
}
