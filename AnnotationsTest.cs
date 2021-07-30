using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistration_UsingAnnotations
{
    class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine("User Registration Email Validations");
            Console.WriteLine("===============================");
            User objUser = new User();
            objUser.Email = "jagtapneha12@gmail.com";
            ValidationContext context = new ValidationContext(objUser, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objUser, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Email is :: {0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg :: {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Email :: " + objUser.Email);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
