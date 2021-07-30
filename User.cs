using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter valid email address")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
       // public string Email { get; internal set; }
    }
}
