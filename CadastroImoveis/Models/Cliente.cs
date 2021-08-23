using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroImoveis.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Cliente")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required] 
        public bool Ativo { get; set; }
    }
}