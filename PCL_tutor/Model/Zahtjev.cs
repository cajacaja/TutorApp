using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
   public class Zahtjev
    {
        public int ZahtjevId { get; set; }
        public System.DateTime DatumSlanja { get; set; }
        public System.DateTime DatumOd { get; set; }
        public int BrojCasova { get; set; }
        public System.TimeSpan VrijemeOd { get; set; }
        public System.TimeSpan VrijemeDo { get; set; }
        public bool Prihvaceno { get; set; }
        public bool Odbijeno { get; set; }
        public int TutorId { get; set; }
        public int StudentId { get; set; }
        public System.DateTime DatumDo { get; set; }        
    }
}
