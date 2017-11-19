using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Kandidaat
{
    [Route("[controller]")]
    public class KandidaatController : Controller
    {
        private List<Kandidaat> _fakeKandidaten = new List<Kandidaat> {
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/500/500/face/all",
                VolledigeNaam = "Jonas Dierckx",
                Diplomas = new List<string> { "Bachelor Lager Onderwijs", "Master Onderwijskunde" },
                Leeftijd = 35,
                Geslacht = "Man"
            },
            new Kandidaat {
                AfbeeldingsBron = "https://loremflickr.com/g/500/500/face/all",
                VolledigeNaam = "Jean-Marie D'Hondt",
                Diplomas = new List<string> { "Master Criminologie" },
                Leeftijd = 48,
                Geslacht = "Man"
            },
        };

        [Route("alle")]
        public IActionResult AlleKandidaten(string volledigeNaam) => View(_fakeKandidaten);

        [Route("{volledigeNaam}")]
        public IActionResult Kandidaat(string volledigeNaam)
            => View(_fakeKandidaten.FirstOrDefault(k => k.ConverteerVolledigeNaamNaarSlug(volledigeNaam) == k.Slug));
    }
}
