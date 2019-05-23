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
        public double Cijena { get; set; }
        public Nullable<int> Ocjena { get; set; }
        public byte[] TutorTumbnail { get; set; }
    }
}
