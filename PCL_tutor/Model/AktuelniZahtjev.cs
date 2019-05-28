using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
   public  class AktuelniZahtjev
    {
        public int ZahtjevId { get; set; }
        public int TutorId { get; set; }
        public string Tutor { get; set; }
        public byte[] TutorTumbnail { get; set; }
        public string Predmet { get; set; }
        public double CijenaCasa { get; set; }
        public System.DateTime DatumOd { get; set; }
        public System.DateTime DatumDo { get; set; }
        public System.DateTime DatumSlanja { get; set; }
        public Nullable<int> Ocjena { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odbijeno { get; set; }
    }
}
