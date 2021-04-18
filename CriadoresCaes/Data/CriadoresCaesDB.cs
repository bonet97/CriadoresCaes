using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CriadoresCaes.Models;


namespace CriadoresCaes.Data{

    /// <summary>
    /// Representa a Base de Dados a ser utilizada neste projeto
    /// </summary>
    ///

    public class CriadoresCaesDB : DbContext {


    //construtor
    public CriadoresCaesDB(DbContextOptions<CriadoresCaesDB> options) : base(options) {

        }


        //Representar as Tabelas da BD
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<CriadoresDeCaes> CriadoresCaes { get; set; }
      

    }
}
