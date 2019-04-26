using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        [Route("api/Tutor")]
        public List<Tutor_SelectAll_Result> GetTutor() {

            return db.tsp_Tutor_SelectAll().ToList();
        }

        [HttpGet]
        [Route("api/Tutor/TutorFilter/{searchName?}/{GradId?}/{OblastId?}")]
        public List<Tutor_SearchSelect_Result> TutorFilter(string searchName = "", int GradId=0, int OblastId=0)
        {
            //Magic string(ne vvalja koristit mogo bi biti bug)
            if (searchName == "Empty") searchName = null;
            if (GradId == 0)
            {

                if (OblastId == 0)
                    return db.tps_Tutor_SearchSelect(searchName, null, null).ToList();
                return db.tps_Tutor_SearchSelect(searchName, null, OblastId).ToList();
            }

            else if (OblastId == 0)
            {
                return db.tps_Tutor_SearchSelect(searchName, GradId, null).ToList();
            }



            return db.tps_Tutor_SearchSelect(searchName, GradId, OblastId).ToList();
        }

        [HttpGet]
        [Route("api/Tutor/TutorDetails/{id?}")]
        [ResponseType(typeof(Tutor_Details_Result))]
        public IHttpActionResult TutorDetails(int id) {

            //promjeni ime
            var nesto = db.tsp_Tutor_Details(id).FirstOrDefault();

            if (nesto == null) return NotFound();

            return Ok(nesto);
        }

        [HttpGet]
        [Route("api/Tutor/BanovaniTutori")]
        
        public List<Tutori_SelectBanTutor_Result> BanovaniTutori() {

            return db.tsp_Tutori_SelectBanTutor().ToList();
        }

        [HttpGet]
        public IHttpActionResult GetTutor(int id)
        {

            db.Configuration.LazyLoadingEnabled = false;
            Tutor tutor = db.Tutors.Find(id);

            if (tutor == null) return NotFound();

            return Ok(tutor);
        }

        [HttpPut]
        public IHttpActionResult PutTutor(int id,Tutor tutor)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutor.TutorId)
            {
                return BadRequest();
            }

            db.Entry(tutor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
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


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorExists(int id)
        {
            return db.Tutors.Count(e => e.TutorId == id) > 0;
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
