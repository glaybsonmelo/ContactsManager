﻿using Newtonsoft.Json.Serialization;
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
        [Range(2, 255, ErrorMessage = "{0} field should be beetwen 2 and 255")]
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
        public string? ConfirmPassword { get; set; }
    }
}