using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.Model
{
    public class OcjenaTutor
    {
        public byte[] StudentskaSlika { get; set; }
        public string Student { get; set; }
        public string Komentar { get; set; }
        public int Ocjena { get; set; }
        public System.DateTime Datum { get; set; }
        public int OcjenaTutorId { get; set; }
        public int TutorId { get; set; }
        public int StudentId { get; set; }
    }
}
