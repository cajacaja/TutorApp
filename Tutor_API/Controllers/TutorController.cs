using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tutor_API.Models;

namespace Tutor_API.Controllers
{
    public class TutorController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        [HttpPost]
        public IHttpActionResult PostTutor(Tutor t)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            KorisnickiNalog kNalog = new KorisnickiNalog()
            {
                KorisnickoIme=t.KorisnickoIme,
                LozinkaSalt=t.LozinkaSalt,
                LozinkaHash=t.LozinkaHash
            };
            db.KorisnickiNalogs.Add(kNalog);

            KontaktInfo kontak = new KontaktInfo() {
                Email=t.Email,
                Telefon=t.Telefon,
                Adresa=t.Adresa
            };
            db.KontaktInfoes.Add(kontak);

            Tutor noviTutor = new Tutor() {
                Ime=t.Ime,
                Prezime=t.Prezime,
                DatumDodavanja=DateTime.Today,
                DatumRodjenja=t.DatumRodjenja,
                NazivUstanove=t.NazivUstanove,
                SpolId=t.SpolId,
                GradId=t.GradId,
                RadnoStanjeId=t.RadnoStanjeId,
                TutorTitulaId=t.TutorTitulaId,
                PodKategorijaId=t.PodKategorijaId,
                CijenaCasa=t.CijenaCasa,
                TutorSlika=t.TutorSlika,
                TutorTumbnail=t.TutorTumbnail,
                SlikaOdobrenja=t.SlikaOdobrenja,
                StatusKorisnickoRacunaId=t.StatusKorisnickoRacunaId
            };

            db.Tutors.Add(noviTutor);

            foreach (var vrstaSudenta in t.ObimStudents)
            {
                ObimStudent tipStudenta = new ObimStudent()
                {
                    TutorId=noviTutor.TutorId,
                    TipStudentaId=vrstaSudenta.TipStudentaId
                };

                db.ObimStudents.Add(tipStudenta);
                
            }
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException greska = ex.InnerException.InnerException as SqlException;

                if (greska!=null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));                    
                }

                
            }
            


            return CreatedAtRoute("DefaultApi", new { id = noviTutor.TutorId}, t);
        }

        private HttpResponseException CreateHttpResponseException(string reason)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.Conflict,
                ReasonPhrase=reason,
                Content=new StringContent(reason)
               
            };

            return new HttpResponseException(msg);
        
        }
    }
}
