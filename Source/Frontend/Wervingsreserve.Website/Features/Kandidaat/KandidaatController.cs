using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Kandidaat
{
    [Route("[controller]")]
    public class KandidaatController : Controller
    {
        private static List<Kandidaat> _fakeKandidaten = new List<Kandidaat> {
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/400/400/face/all",
                VolledigeNaam = "Jonas Dierckx",
                Diplomas = new List<string> { "Bachelor Lager Onderwijs", "Master Onderwijskunde" },
                Leeftijd = 35,
                Geslacht = "Man"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/500/500/eye/all",
                VolledigeNaam = "Jean-Marie D'Hondt",
                Diplomas = new List<string> { "Master Criminologie" },
                Leeftijd = 48,
                Geslacht = "Man"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/250/250/person/all",
                VolledigeNaam = "Jefferson Lafit",
                Diplomas = new List<string> { "Onderhoud" },
                Leeftijd = 19,
                Geslacht = "Man"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/500/500/female/all",
                VolledigeNaam = "Tania Goossen",
                Diplomas = new List<string> { "Master Onderwijskunde" },
                Leeftijd = 28,
                Geslacht = "Vrouw"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/500/500/male/all",
                VolledigeNaam = "Bart Loosgeiter",
                Diplomas = new List<string> { "Secundair Hout & Bewerking" },
                Leeftijd = 19,
                Geslacht = "Man"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/300/300/person/all",
                VolledigeNaam = "Dina Lafit",
                Diplomas = new List<string> { "Bachelor Personeelswerk" },
                Leeftijd = 33,
                Geslacht = "Vrouw"
            },
        };

        [HttpGet]
        [Route("alle")]
        public IActionResult AlleKandidaten(string volledigeNaam) => View(_fakeKandidaten);

        [HttpGet]
        [Route("{volledigeNaam}")]
        public IActionResult Kandidaat(string volledigeNaam)
            => View(_fakeKandidaten.FirstOrDefault(k => k.ConverteerVolledigeNaamNaarSlug(volledigeNaam) == k.Slug));

        [HttpGet]
        public IActionResult Toevoegen()
            => View(new KandidaatToevoegen());

        [HttpPost]
        public IActionResult Toevoegen(KandidaatToevoegen toeTeVoegenKandidaat) {
            if (ModelState.IsValid) {
                _fakeKandidaten.Add(new Kandidaat {
                    VolledigeNaam = $"{toeTeVoegenKandidaat.Voornaam} {toeTeVoegenKandidaat.Achternaam}",
                    Geslacht = toeTeVoegenKandidaat.Geslacht,
                    Diplomas = new List<string>()
                });

                return RedirectToAction("AlleKandidaten");
            }

            return View(toeTeVoegenKandidaat);
        }
    }
}
