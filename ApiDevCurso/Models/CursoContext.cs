using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDevCurso.Models
{
    public class CursoContext:DbContext
    {
        public CursoContext() : base("CursoLocal")
        {
          //  Database.Log = d => System.Diagnostics.Debug.WriteLine(d); 
          //monitorando a saída do banco e ver os gargalos no sql server ok:)
        }
        public DbSet<Curso> Cursos { get; set; }
    }
}