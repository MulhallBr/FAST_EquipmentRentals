using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastEquipmentRental.Models
{
    public class EquipmentRequest
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("[0-9][0-9][0-9]\\-[0-9][0-9][0-9]\\-[0-9][0-9][0-9][0-9]", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }

        public string Role { get; set; }
        
        public string EqType { get; set; }

        [Required(ErrorMessage = "Please enter rental details")]
        public string Details { get; set; }

        [Range(0, 999, ErrorMessage = "Please enter a positive number")]
        public int Days { get; set; }

    }
}
