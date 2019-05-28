using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class Materijal
    {
        public int MaterijalId { get; set; }
        public int UcionicaId { get; set; }
        public string Naslov { get; set; }
        public System.DateTime DatumPostavljanja { get; set; }
        public byte[] Materijal1 { get; set; }
        public string TipFila { get; set; }
    }
}
