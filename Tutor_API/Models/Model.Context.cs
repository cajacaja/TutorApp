﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TutorEntities : DbContext
    {
        public TutorEntities()
            : base("name=TutorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Dan> Dans { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<KontaktInfo> KontaktInfoes { get; set; }
        public virtual DbSet<KorisnickiNalog> KorisnickiNalogs { get; set; }
        public virtual DbSet<Materijal> Materijals { get; set; }
        public virtual DbSet<NivoTezine> NivoTezines { get; set; }
        public virtual DbSet<ObimStudent> ObimStudents { get; set; }
        public virtual DbSet<Oblast> Oblasts { get; set; }
        public virtual DbSet<OcjenaStudent> OcjenaStudents { get; set; }
        public virtual DbSet<OcjenaTutor> OcjenaTutors { get; set; }
        public virtual DbSet<Podkategorija> Podkategorijas { get; set; }
        public virtual DbSet<Prijava> Prijavas { get; set; }
        public virtual DbSet<RadnoStanje> RadnoStanjes { get; set; }
        public virtual DbSet<Spol> Spols { get; set; }
        public virtual DbSet<StatusKorisnickogRacuna> StatusKorisnickogRacunas { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<TipStudenta> TipStudentas { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }
        public virtual DbSet<TutorTitula> TutorTitulas { get; set; }
        public virtual DbSet<Ucionica> Ucionicas { get; set; }
        public virtual DbSet<Zahtjev> Zahtjevs { get; set; }
    
        public virtual int tsp_Administrator_Insert(string ime, string prezime, Nullable<System.DateTime> datumDodavanja, string email, string telefon, string korisnickoIme, string lozinkaHash, string lozinkaSalt)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var datumDodavanjaParameter = datumDodavanja.HasValue ?
                new ObjectParameter("DatumDodavanja", datumDodavanja) :
                new ObjectParameter("DatumDodavanja", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("tsp_Administrator_Insert", imeParameter, prezimeParameter, datumDodavanjaParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaHashParameter, lozinkaSaltParameter);
        }
    
        public virtual ObjectResult<Administrator_SelectAll> tsp_Administrator_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Administrator_SelectAll>("tsp_Administrator_SelectAll");
        }
    
        public virtual ObjectResult<Administrator_NameSelect> tsp_Administrator_SelectByImePrezime(string imePrezime)
        {
            var imePrezimeParameter = imePrezime != null ?
                new ObjectParameter("ImePrezime", imePrezime) :
                new ObjectParameter("ImePrezime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Administrator_NameSelect>("tsp_Administrator_SelectByImePrezime", imePrezimeParameter);
        }
    
        public virtual ObjectResult<Administrator_SelectOne> tsp_Administrator_SelectOne(Nullable<int> administratorId)
        {
            var administratorIdParameter = administratorId.HasValue ?
                new ObjectParameter("AdministratorId", administratorId) :
                new ObjectParameter("AdministratorId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Administrator_SelectOne>("tsp_Administrator_SelectOne", administratorIdParameter);
        }
    
        public virtual int tsp_Administrator_Update(Nullable<int> administratorId, string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaHash, string lozinkaSalt)
        {
            var administratorIdParameter = administratorId.HasValue ?
                new ObjectParameter("AdministratorId", administratorId) :
                new ObjectParameter("AdministratorId", typeof(int));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("tsp_Administrator_Update", administratorIdParameter, imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaHashParameter, lozinkaSaltParameter);
        }
    
        public virtual ObjectResult<Grad_Result> tsp_Grad_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Grad_Result>("tsp_Grad_SelectAll");
        }
    }
}