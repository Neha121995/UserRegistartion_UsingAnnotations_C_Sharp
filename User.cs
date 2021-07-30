using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should have minimum of 2 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
