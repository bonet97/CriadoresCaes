using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class CriadoresDeCaes
    {

        //FK para os Caes
        [ForeignKey(nameof(Cao))]
        public int CaesFK { get; set; }
        public Caes Cao { get; set; }


    }
}
