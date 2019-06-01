using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class KorisnickiNalog
    {
        public int KorisnickiNalogId { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }
    }
}
