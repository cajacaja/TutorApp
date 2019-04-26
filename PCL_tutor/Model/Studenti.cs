using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class Studenti
    {
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumDodavanja { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public byte[] StudentskaSlika { get; set; }
        public string NazivUstanove { get; set; }
        public int KorisnickiNalogId { get; set; }
        public int KontaktInfoId { get; set; }
        public int GradId { get; set; }
        public int TipoviStudentaId { get; set; }
        public int StatusKorisnickoRacunaId { get; set; }
    }
}
