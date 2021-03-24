using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Criadores {

        public Criadores(){
            //inicializar a lista de Cães
            ListaDeCaes = new HashSet<CriadoresCaes>();
        }
    
        /// <summary>
        /// Identificador do Criador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do Criador
        /// </summary>
        public int CodPostal { get; set; }

        /// <summary>
        /// Número de telemóvel do Criador
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do Criador
        /// </summary>
        public string Email { get; set; }

        //############################################################

        //Lista de Cães associados ao criador

        public ICollection<CriadoresCaes> ListaDeCaes { get; set; }

    }
}