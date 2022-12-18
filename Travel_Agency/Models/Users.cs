using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Travel_Agency.Models;

namespace Travel_Agency.Models
{
    public class Users
    {
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "user name must be between 2 and 30 letters")]
        public string userName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "first name must be between 2 and 30 letters")]
        public string firstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "last name must be between 2 and 30 letters")]
        public string lastName { get; set; }
        [Key]
        [Required]
        [RegularExpression("[0-9]{9}$", ErrorMessage = "id must contain 9 digits")]
        public string id { get; set; }
        [Required]
        [RegularExpression("^[A-Z0-9a-z._%+-@[A-Z0-9.-]+\\.[A-Za-z]{2,64}$", ErrorMessage = "email is not valid")]
        public string email { get; set; }
        [Required]
        [RegularExpression("[0-9]{9}$", ErrorMessage = "passport must contain 9 digits")]
        public string passport { get; set; }
        public string card { get; set; }
        [Required]
        //[RegularExpression("^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$",
          //  ErrorMessage = "password has minimum 8 characters, at least 1 uppercase English letter, at least 1 lowercase English letter, At least 1 digit and at least 1 special character")]
        public string password { get; set; }
        [Required]
        [RegularExpression("[0-9]{10}$", ErrorMessage = "phone must contain 10 digits")]
        public string phone { get; set; }


    }
}