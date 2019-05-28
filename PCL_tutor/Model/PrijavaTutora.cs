using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
   public class PrijavaTutora
    {
        public int PrijavaStudentId { get; set; }
        public int StudentId { get; set; }
        public int TutorId { get; set; }
        public string RazlogPrijave { get; set; }
        public System.DateTime DatumPrijave { get; set; }
        public bool IsRead { get; set; }
    }
}
