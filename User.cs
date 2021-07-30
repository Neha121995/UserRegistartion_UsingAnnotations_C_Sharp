using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression(@"^((?=.*[A-Z])(?=.*[0-9])(?=.{8,}))", ErrorMessage = "Please enter at least one UpperCase ")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
