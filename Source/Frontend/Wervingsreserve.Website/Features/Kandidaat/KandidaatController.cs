using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Kandidaat
{
    [Route("[controller]")]
    public class KandidaatController : Controller
    {
        [Route("alle")]
        public IActionResult AlleKandidaten(string volledigeNaam) => View();

        [Route("{volledigeNaam}")]
        public IActionResult Kandidaat(string volledigeNaam) => View(new Kandidaat {
            AfbeeldingsBron = "https://loremflickr.com/g/500/500/face/all",
            VolledigeNaam = volledigeNaam.Replace("+", " "),
            Diplomas = new List<string> { "Bachelor Lager Onderwijs", "Master Onderwijskunde" },
            Leeftijd = 35,
            Geslacht = "Man"
        });
    }
}
