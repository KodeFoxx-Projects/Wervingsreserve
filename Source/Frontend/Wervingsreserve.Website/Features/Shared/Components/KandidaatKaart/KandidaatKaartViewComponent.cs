using Microsoft.AspNetCore.Mvc;

namespace Wervingsreserve.Website.Features.Shared.Components.KandidaatKaart
{
    public class KandidaatKaartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Kandidaat.Kandidaat kandidaat, bool toonDetailsLink = false)
            => View(new KandidaatKaart(kandidaat, toonDetailsLink));
    }
}
