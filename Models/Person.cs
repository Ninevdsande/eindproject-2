using System;
using System.ComponentModel.DataAnnotations;

namespace eindproject_2.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
       
        public string? Voornaam { get; set; }

        [Required(ErrorMessage = "Gelieve uw achternaam in te vullen")]
        public string? Achternaam { get; set; }

        [Required(ErrorMessage = "E-mailadres is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        public string? Email { get; set; }
        public string? Telefoonnummer { get; set; }

        [Required(ErrorMessage = "Gelieve uw opmerking of vraag achter te laten")]
        public string? Opmerkingen { get; set; }

    }
}
