using System;
using System.ComponentModel.DataAnnotations;

namespace Wervingsreserve.Website.Features.Kandidaat
{
    public class KandidaatToevoegen
    {
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime Geboortedatum { get; set; }
        [Required]
        public string Geslacht { get; set; }
    }
}
