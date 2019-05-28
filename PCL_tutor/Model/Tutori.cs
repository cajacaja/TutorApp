using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class Tutori
    {
        public int TutorId { get; set; }
        public string Tutor { get; set; }
        public string Predmet { get; set; }
        public double CijenaCasa { get; set; }
        public Nullable<int> Ocjena { get; set; }
        public byte[] TutorTumbnail { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string RadnoStanje { get; set; }
        public string NazivUstanove { get; set; }
        public string Spol { get; set; }
        
    }
}
