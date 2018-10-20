using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać nr telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę określić czy wezmiesz udział w przyjęciu")]
        public bool? WillAttend { get; set; }

    }
}