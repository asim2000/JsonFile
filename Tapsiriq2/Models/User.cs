using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tapsiriq2.Models
{
    public class User
    {
        [Required(ErrorMessage ="Zehmet olmasa Adinizi daxil edin")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa Soyadinizi daxil edin")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa Emailinizi daxil edin")]
        [EmailAddress(ErrorMessage = "Email formatinda daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa parolunuzu daxil edin")]
        [MinLength(6,ErrorMessage ="Parolun uzunlugu min. 6 olmalidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa dogum tarixinizi daxil edin")]
        [DataType(DataType.Date,ErrorMessage ="Zehmet olmasa duzgun format daxil edin")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa olkenizi daxil edin")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Zehmet olmasa sheherinizi daxil edin")]
        public string City { get; set; }
    }
}
