using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace at02.Models
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        [Key]
        public int id {get;set;}

        [Display(Name = "Nome do Usuário")]
        [Required]
        public string nome {get;set;}

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime nascimento {get;set;}

        [Display(Name = "Login")]
        [Required]
        public string login {get;set;}

        [Display(Name = "Senha")]
        [Required]
        public string senha {get;set;}

        [Display(Name = "Não é Administrador")]
        [Required]
        public bool tipo {get;set;} 
    }
}