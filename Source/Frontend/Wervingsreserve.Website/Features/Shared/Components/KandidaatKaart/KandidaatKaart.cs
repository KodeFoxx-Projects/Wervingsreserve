using Wervingsreserve.Website.Features.Kandidaat;

namespace Wervingsreserve.Website.Features.Shared.Components.KandidaatKaart
{
    public class KandidaatKaart
    {        
        public KandidaatKaart(Kandidaat.Kandidaat kandidaat, bool toonDetailsLink = true) {
            ToonDetailsLink = toonDetailsLink;
            Kandidaat = kandidaat;
        }

        public bool ToonDetailsLink { get; }

        public Kandidaat.Kandidaat Kandidaat { get; }
    }
}
