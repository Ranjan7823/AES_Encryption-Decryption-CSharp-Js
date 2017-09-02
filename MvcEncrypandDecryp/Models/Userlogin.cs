using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcEncrypandDecryp.Models
{
    public class Userlogin
    {
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string HDUser { get; set; }
        // hidden fields for username
        public string HDpass { get; set; }
        // hidden fields for password
    }
}