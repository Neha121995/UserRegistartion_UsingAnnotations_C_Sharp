using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression(@"^[A-Z][A-Za-z0-9]{7,}$", ErrorMessage = "Please enter at least one UpperCase ")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
