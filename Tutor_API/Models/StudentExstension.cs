using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutor_API.Models
{
    public partial class Student
    {
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public string KorisnickoIme { get; set; }

        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}