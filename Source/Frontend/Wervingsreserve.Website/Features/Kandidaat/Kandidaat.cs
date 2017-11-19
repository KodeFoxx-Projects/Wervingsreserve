using System;
using System.Collections.Generic;

namespace Wervingsreserve.Website.Features.Kandidaat
{
    public class Kandidaat
    {
        public string AfbeeldingsBron { get; set; }
        public string VolledigeNaam { get; set; }
        public string Slug => ConverteerVolledigeNaamNaarSlug(VolledigeNaam);
        public List<string> Diplomas { get; set; }
        public int Leeftijd { get; set; }
        public string Geslacht { get; set; }

        public string ConverteerVolledigeNaamNaarSlug(string volledigeNaam)
            => String.IsNullOrWhiteSpace(volledigeNaam) ? "" : volledigeNaam.Replace(" ", "+").Trim().ToLower();
    }
}
