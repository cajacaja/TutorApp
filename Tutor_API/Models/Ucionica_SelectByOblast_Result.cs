//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutor_API.Models
{
    using System;
    
    public partial class Ucionica_SelectByOblast_Result
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
    }
}
