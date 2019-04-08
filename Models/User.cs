using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
      [Required]
      [MinLength(4)]
      // [MinLength(4, ErrorMessage="First Name must be at least 4 characters")]
      public string FirstName { get; set; }

      [Required]
      [MinLength(4)]
      // [MinLength(4, ErrorMessage="First Name must be at least 4 characters")]
      public string LastName { get; set; }

      [Required]
      [Range(0, 120)]
      // [Range(0, 120, ErrorMessage="Your age doesn't exist. Try again!")]
      public int Age { get; set; }

      [Required]
      [EmailAddress]
      // [EmailAddress(ErrorMessage="Please enter a valid email")]
      public string Email { get; set; }

      [Required]
      [MinLength(8)]
      // [MinLength(8, ErrorMessage = "Password must be at least 8 characters!")]
      [DataType(DataType.Password, ErrorMessage="Password invalid!")]
      public string Password { get; set; }
    }
}