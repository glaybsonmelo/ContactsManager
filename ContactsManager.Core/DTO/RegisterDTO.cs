using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Core.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "{0} can't be blank")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [EmailAddress( ErrorMessage = "Email should be in a proper email address format")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} should contain only numbers")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password don't match")]
        public string? ConfirmPassword { get; set; }
    }
}
