using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroImoveis.Models
{
    [Table("Imoveis")]
    public class Imovel
    {
        public int Id { get; set; }

        [Required]
        public TipoNegocio Tipo { get; set; }

        [Required]
        public double Valor { get; set; }


        [MaxLength(200)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}