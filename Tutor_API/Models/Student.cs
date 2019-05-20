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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.OcjenaTutors = new HashSet<OcjenaTutor>();
            this.Prijavas = new HashSet<Prijava>();
            this.Zahtjevs = new HashSet<Zahtjev>();
            this.BanPrijavaStudents = new HashSet<BanPrijavaStudent>();
            this.BanPrijavaTutors = new HashSet<BanPrijavaTutor>();
            this.OcjenaStudents = new HashSet<OcjenaStudent>();
        }
    
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumDodavanja { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public byte[] StudentskaSlika { get; set; }
        public string NazivUstanove { get; set; }
        public int KorisnickiNalogId { get; set; }
        public int KontaktInfoId { get; set; }
        public int GradId { get; set; }
        public int TipoviStudentaId { get; set; }
        public int StatusKorisnickoRacunaId { get; set; }
        public Nullable<int> SpolId { get; set; }
    
        public virtual Grad Grad { get; set; }
        public virtual KontaktInfo KontaktInfo { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OcjenaTutor> OcjenaTutors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prijava> Prijavas { get; set; }
        public virtual StatusKorisnickogRacuna StatusKorisnickogRacuna { get; set; }
        public virtual TipStudenta TipStudenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zahtjev> Zahtjevs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanPrijavaStudent> BanPrijavaStudents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanPrijavaTutor> BanPrijavaTutors { get; set; }
        public virtual Spol Spol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OcjenaStudent> OcjenaStudents { get; set; }
    }
}
