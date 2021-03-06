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
    using System.Collections.Generic;
    
    public partial class Ucionica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ucionica()
        {
            this.Materijals = new HashSet<Materijal>();
            this.Prijavas = new HashSet<Prijava>();
            this.Termins = new HashSet<Termin>();
        }
    
        public int UcionicaId { get; set; }
        public int TutorId { get; set; }
        public string Naslov { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public System.DateTime DatumPocetka { get; set; }
        public System.DateTime DatumZavrsetka { get; set; }
        public int MaxBrojPolaznika { get; set; }
        public string AdresaUcionice { get; set; }
        public double Cijena { get; set; }
        public int BrojCasova { get; set; }
        public bool Aktivna { get; set; }
        public int NivoTezineId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijal> Materijals { get; set; }
        public virtual NivoTezine NivoTezine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prijava> Prijavas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termin> Termins { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
