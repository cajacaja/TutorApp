using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class Prijava
    {
        public int PrijavaId { get; set; }
        public System.DateTime DatumPrijave { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odbijeno { get; set; }
        public int StudentId { get; set; }
        public int UcionicaId { get; set; }
    }
}
