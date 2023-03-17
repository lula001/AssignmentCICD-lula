using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Auckland_Institute_of_Studies.Data
{
    public class AppUser:IdentityUser
    {
        [Required]
        [StringLength(25, ErrorMessage = "Max characters is 25.")]
        public string FirstName{ get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Max characters is 25.")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
