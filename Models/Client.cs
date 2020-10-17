using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    [Table("clients")]
    public class Client
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string company_name { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string fantasy_name { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        [MinLength(18, ErrorMessage = "CNPJ inválido.")]
        public string cnpj { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        [DataType(DataType.Date)]
        public DateTime foundation_date { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string manager { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        [MinLength(14, ErrorMessage = "Telefone inválido.")]
        public string phone { get; set; }
        public string website { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        [MinLength(9, ErrorMessage = "CEP inválido.")]
        public string cep { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string address { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string address_number { get; set; }
        public string complement { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string neighborhood { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string city { get; set; }

        [Required(ErrorMessage = "Preencha este campo.")]
        public string state { get; set; }
    }
}