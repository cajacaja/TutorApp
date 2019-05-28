using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class CountModel
    {
        public int TutorId { get; set; }
        public byte[] TutorTumbnail { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public System.DateTime DatumDodavanja { get; set; }
        public string Grad { get; set; }
        public string Predmet { get; set; }
    }
}
