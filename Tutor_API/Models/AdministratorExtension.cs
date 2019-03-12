using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutor_API.Models
{
    public partial class Administrator
    {
        public string Email { get; set; }

        public string Telefon { get; set; }

        public string KoriniskoIme { get; set; }

        public string LozinkaHash { get; set; }

        public string  LozinkaSalt { get; set; }
    }
}