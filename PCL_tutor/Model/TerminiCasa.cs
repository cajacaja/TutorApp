using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
   public class TerminiCasa
    {

        public int TerminId { get; set; }
        public int ZahtjevId { get; set; }
        public System.DateTime DatumCasa { get; set; }
        public System.TimeSpan VrijemePocetka { get; set; }
        public string DanNaziv { get; set; }
    }
}
