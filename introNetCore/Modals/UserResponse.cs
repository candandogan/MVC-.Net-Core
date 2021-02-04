using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace introNetCore.Modals
{
    public class UserResponse
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Lütfen E-postanızı giriniz!")]
        [EmailAddress(ErrorMessage ="E-posta formatı doğru değil!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen katılım durumunu belirtiniz!")]
        public bool IsAccepted { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
