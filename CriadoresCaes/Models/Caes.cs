using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    /// 
    public class Caes {

        public Caes()
        {
            //inicializar a lista de Fotografias de cada um dos cães 
            ListaDeFotografias = new HashSet<Fotografias>();
            //inicializar a lista de Criadores de cada um dos cães 
            ListaDeCriadores = new HashSet<CriadoresDeCaes>();
        }
       
        /// <summary>
        /// Identificador de cada Cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do Cão
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do Cão
        /// </summary>
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Data de compra do Cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do Cão no Livro de Origens Português (LOP)
        /// </summary>
        public string LOP { get; set; }

        //**//

        /// <summary>
        /// FK para a Raça do Cão
        /// </summary>

        [ForeignKey(nameof(Raca))] //esta anotação indica que o atributo 'RacaFK' está a executar o .....
                             //e que representa uma FK para a classe Raca
        public int RacaFK { get; set; } //atributo para ser usado na SGBD e no C#. Representa a FK para a Raça do Cão

        public Racas Raca { get; set; } //atributo para ser usado no C#. Representa a FK para a Raça do Cão


        /*Se estivésse-mps a criar a tabela 'Caes' em SQL
         * CREATE TABLE Caes(
         * Id INT PRIMARY KEY,
         * Nome VARCHAR(30) NOT NULL,
         * LOP varchar (20),
         * RacaFK INT NOT NULL,
         * FOREIGN KEY (RacaFK) REFERENCE Racas(Id),
         * )
         *
         */

        //###################################################
        // associar os cães às suas fotografias
        /// <summary>
        /// Lista das Fotografias do cão
        /// </summary>

        public ICollection<Fotografias> ListaDeFotografias { get; set; }


        //###################################################
        // associar os cães aos seus Criadores
        /// <summary>
        /// 
        /// Lista de criadores associados ao cão
        /// 
        /// </summary>

        public ICollection <CriadoresDeCaes> ListaDeCriadores { get; set; }

        //fodassseeeee





























    }
}