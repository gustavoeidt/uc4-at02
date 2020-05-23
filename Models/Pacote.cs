using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace at02.Models
{
    public class Pacote
    {
        [ScaffoldColumn(false)]
        [Key]
        public int id {get;set;}

        [ScaffoldColumn(false)]
        public string autor {get;set;}

        [Display(Name = "Nome do Pacote")]
        [Required]
        public string nome {get;set;}

        
        [Display(Name = "Origem")]
        [Required]
        public string origem {get;set;}

        [Display(Name = "Destino")]
        [Required]
        public string destino {get;set;}

        [Display(Name = "Atrativo")]
        [Required]
        public string atrativo {get;set;}

        [Display(Name = "Data de Saída")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime saida {get;set;}

        [Display(Name = "Data de Retorno")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime retorno {get;set;}

        [ScaffoldColumn(false)]
        public int id_usuario {get;set;}

    }
}