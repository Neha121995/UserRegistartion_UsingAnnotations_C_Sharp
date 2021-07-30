using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&#])[A-Za-z0-9@$!%*?&]{8,}$", ErrorMessage = "Please enter one special character")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
