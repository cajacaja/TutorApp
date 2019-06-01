using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class PohadjaneUcionice
    {
        public int UcionicaId { get; set; }
        public string Tutor { get; set; }
        public string Naslov { get; set; }
        public System.DateTime DatumZavrsetka { get; set; }
        public string Predmet { get; set; }
        public string NivoTezine { get; set; }
        public int BrojCasova { get; set; }
        public double Cijena { get; set; }
        public int TutorId { get; set; }
    }
}
