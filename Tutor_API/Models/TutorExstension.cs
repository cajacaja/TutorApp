using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutor_API.Models
{
    public partial class Tutor
    {
        public List<TipStudenta> TipStudenta { get; set; }

        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public string KorisnickoIme { get; set; }

        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}