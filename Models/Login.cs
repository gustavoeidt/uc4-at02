using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace at02.Models
{
    public class Login
    {
        [Display(Name = "Login")]
        [Required]
        public string login {get;set;}

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required]
        public string senha {get;set;}
    }
}