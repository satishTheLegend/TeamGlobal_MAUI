using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGlobal.Models.UIBinding
{
    public class Login
    {
        [EmailAddress(ErrorMessage = "Not valid email address")]
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [StringLength(64, MinimumLength = 8,
            ErrorMessage = "The password should contain at least 8 characters.")]
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }
    }
}
