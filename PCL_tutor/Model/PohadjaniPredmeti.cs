using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
   public class PohadjaniPredmeti
    {
        public Nullable<int> BrojCasova { get; set; }
        public string Naziv { get; set; }
        public string Tutor { get; set; }
        public int TutorId { get; set; }
    }
}
