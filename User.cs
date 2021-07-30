using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class User
    {
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Please enter valid mobile number")]
        [DataType(DataType.PhoneNumber)]
        public string mobileNumber { get; set; }
    }
}
