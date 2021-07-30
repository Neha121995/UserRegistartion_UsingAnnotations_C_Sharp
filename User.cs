using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression(@"^[A-Za-z]{8,}", ErrorMessage = "Please enter minimum 8 character")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
