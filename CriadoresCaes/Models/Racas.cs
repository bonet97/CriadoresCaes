using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    /// <summary>
    /// Raça atribuída a um cão
    /// </summary>
    public class Racas {

        public  Racas() {
            //Procurar os Cães de cada Raça e criar uma lista com esses cães
            ListaDeCaes = new HashSet<Caes>;


        }
        /// <summary>
        /// Identificar cada uma das Raças
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificar o nome da Raça
        /// </summary>
        public string Designacao { get; set; } //prop + tab


        //**************************************************************
        // Uma raça está associada a muitos cães
        // uma raça tem uma lista de cães
        /// <summary>
        /// Lista dos Cães que são da raça
        /// </summary>

        public ICollection<Caes> ListaDeCaes { get; set; }
       /*SELECT*
        *FROM Caes c
         Where c.RacaFK = ))
       */
    }
}