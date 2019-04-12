using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;

namespace Tutor_API.Controllers
{
    public class TutorController : ApiController
    {
        private TutorEntities db = new TutorEntities();


        [HttpGet]
        [Route("api/Tutor/TutorFilter/{searchName?}/{GradId?}/{OblastId?}")]
        public List<Tutor_SearchSelect_Result> TutorFilter(string searchName="",int GradId=0,int OblastId=0)
        {
            if (searchName == "Empty") searchName ="";

            return db.tps_Tutor_SearchSelect(searchName,GradId,OblastId).ToList();
        }

        [HttpGet]
        [Route("api/Tutor/{id?}")]
        [ResponseType(typeof(Tutor_Details_Result))]
        public IHttpActionResult GetTutor(int id) {

            var nesto = db.tsp_Tutor_Details(id).FirstOrDefault();

            if (nesto == null) return NotFound();

            return Ok(nesto);
        }

        [HttpGet]
        [Route("api/Tutor/Picture/{id}")]
        [ResponseType(typeof(byte[]))]
        public IHttpActionResult Picture(int id) {

            var slika = db.Tutors.FirstOrDefault(x => x.TutorId == id);

            if (slika == null) return NotFound();

            return Ok(slika.SlikaOdobrenja);
        }

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
