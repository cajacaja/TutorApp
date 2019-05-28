using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class Ucionica
    {
        public int UcionicaId { get; set; }
        public byte[] Slika { get; set; }
        public string Naslov { get; set; }
        public System.DateTime DatumPocetka { get; set; }
        public System.DateTime DatumZavrsetka { get; set; }
        public double Cijena { get; set; }
        public int MaxBrojPolaznika { get; set; }
        public Nullable<int> BrojPrijavljenih { get; set; }
        public int BrojCasova { get; set; }
        public string Opis { get; set; }
        public string Predmet { get; set; }
        public string Tezina { get; set; }

        public int TutorId { get; set; }
        public string Tutor { get; set; }
        public string Grad { get; set; }
        public string AdresaUcionice { get; set; }
        public bool Aktivna { get; set; }
    }
}
