using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroImoveis.Models
{
    public class CadastroContext:DbContext
    {
        public CadastroContext() : base("CadastroImoveis")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}