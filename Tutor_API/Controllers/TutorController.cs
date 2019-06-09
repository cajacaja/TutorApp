using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;
using Tutor_API.Util;

namespace Tutor_API.Controllers
{
    public class TutorController : ApiController
    {
        private TutorEntities db = new TutorEntities();



        [HttpGet]
        [Route("api/Tutor")]
        public List<Tutor> GetTutor()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.Tutors.ToList();
        }

        [HttpGet]
        [Route("api/Tutor/TutorCount/{oblastId}/{gradId}/{tipStudentaId}")]
        public int TutorCount( int oblastId,int gradId,int tipStudentaId)
        {
            var lst = from x in db.Tutors
                      join p in db.Podkategorijas on x.PodKategorijaId equals p.PodKategorijaId
                      join o in db.Oblasts on p.OblastId equals o.OblastId
                      join os in db.ObimStudents on x.TutorId equals os.TutorId
                      where o.OblastId == oblastId && x.GradId == gradId && os.TipStudentaId == tipStudentaId
                      select x.TutorId;

            return lst.Count();
        }

        [HttpGet]
        [Route("api/Tutor/TutorFilter/{searchName?}/{GradId?}/{OblastId?}")]
        public List<Tutor_SearchSelect_Result> TutorFilter(string searchName = "", int GradId = 0, int OblastId = 0)
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
        public IHttpActionResult TutorDetails(int id)
        {

            //promjeni ime
            var nesto = db.tsp_Tutor_Details(id).FirstOrDefault();

            if (nesto == null) return NotFound();

            return Ok(nesto);
        }

        [HttpGet]
        [Route("api/Tutor/BanovaniTutori")]

        public List<Tutori_SelectBanTutor_Result> BanovaniTutori()
        {

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



        [HttpGet]
        [Route("api/Tutor/Picture/{id}")]
        [ResponseType(typeof(byte[]))]
        public IHttpActionResult Picture(int id)
        {

            var slika = db.Tutors.FirstOrDefault(x => x.TutorId == id);

            if (slika == null) return NotFound();

            return Ok(slika.SlikaOdobrenja);
        }

        [HttpGet]
        [Route("api/Tutor/SelectBest/{GradId?}/{OblastId?}/{DatumOd}/{DatumDo}")]
        [ResponseType(typeof(List<Tutor_SelectBest_Result>))]
        public IHttpActionResult SelectBest(int GradId, int OblastId, DateTime DatumOd, DateTime DatumDo)
        {
            if (GradId == 0)
            {
                if (OblastId == 0)
                {
                    return Ok(db.tsp_Tutor_SelectBest(null, null, DatumOd, DatumDo).ToList());
                }
                return Ok(db.tsp_Tutor_SelectBest(null, OblastId, DatumOd, DatumDo).ToList());
            }

            if (OblastId == 0)
            {
                return Ok(db.tsp_Tutor_SelectBest(GradId, null, DatumOd, DatumDo).ToList());
            }

            return Ok(db.tsp_Tutor_SelectBest(GradId, OblastId, DatumOd, DatumDo).ToList());
        }
        [HttpGet]
        [Route("api/Tutor/SelectOne/{TutorId}")]
        [ResponseType(typeof(Tutor_UpdateSelect_Result))]
        public IHttpActionResult SelectOne(int TutorId)
        {

            var tutor = db.Tutors.Find(TutorId);
            if (tutor==null) return NotFound();

            return Ok(db.tsp_Tutor_UpdateSelect(TutorId).FirstOrDefault());
        }

        [HttpGet]
        [Route("api/Tutor/LoginCheck/{username}/{password}")]
        [ResponseType(typeof(Tutor))]
        public IHttpActionResult LoginCheck(string username, string password)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var korisnickiNalog = db.KorisnickiNalogs.FirstOrDefault(x => x.KorisnickoIme == username);
            if (korisnickiNalog == null) return NotFound();

            var passwordHash = PasswordCheck.GenerateHash(korisnickiNalog.LozinkaSalt, password);
            if (passwordHash != korisnickiNalog.LozinkaHash) return NotFound();

            var tutor = db.Tutors.FirstOrDefault(x => x.KorisnickiNalogId == korisnickiNalog.KorisnickiNalogId);
            if (tutor == null) return NotFound();


            return Ok(tutor);
        }

        [HttpGet]
        [Route("api/Tutor/ActiveUcionica/{tutorId}/{naslov?}")]
        [ResponseType(typeof(List<Tutor_SelectActiveUcionica_Result>))]
        public IHttpActionResult ActiveUcionica(int tutorId,string naslov="")
        {
            var tutor = db.Tutors.Find(tutorId);
            if (tutor==null) return NotFound();

            var lstUcionica = db.tsp_Tutor_SelectActiveUcionica(naslov, tutorId).ToList();

            return Ok(lstUcionica);
        }

        [HttpGet]
        [Route("api/Tutor/NonActiveUcionica/{tutorId}/{naslov?}")]
        [ResponseType(typeof(List<Ucionica_SelectNonActive_Result>))]
        public IHttpActionResult NonActiveUcionica(int tutorId, string naslov="")
        {
            var tutor = db.Tutors.Find(tutorId);
            if (tutor==null) return NotFound();

            var lstUcionica = db.tsp_Ucionica_SelectNonActive(naslov, tutorId).ToList();

            return Ok(lstUcionica);
        }

        [HttpGet]
        [Route("api/Tutor/SelectByOblast/{oblastId}/{gradId}/{tipStudentaId}/{page}/{PageSize}")]
        [ResponseType(typeof(List<Tutor_SelectByOblast_Result>))]
        public IHttpActionResult SelectByOblast(int oblastId,int gradId,int tipStudentaId, int page,int PageSize)
        {          

            return Ok(db.tsp_Tutor_SelectByOblast(oblastId,gradId,tipStudentaId,page,PageSize).ToList());
        }

        [HttpGet]
        [Route("api/Tutor/SelectStudents/{tutorId}")]
        [ResponseType(typeof(List<Tutor_SelectTutorStudents_Result>))]
        public IHttpActionResult SelectStudents(int tutorId)
        {
            var tutor = db.Tutors.Find(tutorId);

            if (tutor==null) return NotFound();

            return Ok(db.tsp_Tutor_SelectTutorStudents(tutorId).ToList());
        }


        [HttpGet]
        [Route("api/Tutor/RecommendTutor/{tutorId}/{tipStudentaId}")]       
        public List<Tutor> RecommendTutor(int tutorId,int tipStudentaId)
        {
            db.Configuration.LazyLoadingEnabled = false;
            TutorRecommender r = new TutorRecommender();

            return r.GetSlicneTutore(tutorId, tipStudentaId);
        }

        [HttpGet]
        [Route("api/Tutor/ReportTitula/{GradId}/{DatumOd}/{DatumDo}")]
        [ResponseType(typeof(List<Report_TipoviStudenta_Result>))]
        public IHttpActionResult ReportTitula(int GradId, DateTime DatumOd, DateTime DatumDo)
        {
            if (GradId == 0)
                return Ok(db.tsp_Report_TipoviStudenta(DatumOd, DatumDo, null).ToList());

            return Ok(db.tsp_Report_TipoviStudenta(DatumOd, DatumDo, GradId).ToList());
        }

        [Route("api/Tutor")]//(Fix) dodan iz razloga jer odjednom post za tutora je prestao da radi(Magija)
        [HttpPost]
        public IHttpActionResult PostTutor(Tutor t)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            KorisnickiNalog kNalog = new KorisnickiNalog()
            {
                KorisnickoIme = t.KorisnickoIme,
                LozinkaSalt = t.LozinkaSalt,
                LozinkaHash = t.LozinkaHash
            };
            db.KorisnickiNalogs.Add(kNalog);
            try { db.SaveChanges(); }
            catch (DbUpdateException ex)
            {
                SqlException greska = ex.InnerException.InnerException as SqlException;

                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }

            KontaktInfo kontak = new KontaktInfo()
            {
                Email = t.Email,
                Telefon = t.Telefon,
                Adresa = t.Adresa
            };
            try
            {
                db.KontaktInfoes.Add(kontak);
            }

            catch (DbUpdateException ex)
            {
                db.KorisnickiNalogs.Remove(kNalog);
                SqlException greska = ex.InnerException.InnerException as SqlException;

                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }

            Tutor noviTutor = new Tutor()
            {
                Ime = t.Ime,
                Prezime = t.Prezime,
                DatumDodavanja = DateTime.Today,
                DatumRodjenja = t.DatumRodjenja,
                NazivUstanove = t.NazivUstanove,
                SpolId = t.SpolId,
                GradId = t.GradId,
                RadnoStanjeId = t.RadnoStanjeId,
                TutorTitulaId = t.TutorTitulaId,
                PodKategorijaId = t.PodKategorijaId,
                CijenaCasa = t.CijenaCasa,
                TutorSlika = t.TutorSlika,
                TutorTumbnail = t.TutorTumbnail,
                SlikaOdobrenja = t.SlikaOdobrenja,
                StatusKorisnickoRacunaId = t.StatusKorisnickoRacunaId,
                KorisnickiNalogId = kNalog.KorisnickiNalogId,
                KontaktInfoId = kontak.KontaktInfoId

            };
            try { db.Tutors.Add(noviTutor); }
            catch (DbUpdateException ex)
            {
                db.KorisnickiNalogs.Remove(kNalog);
                db.KontaktInfoes.Remove(kontak);
                SqlException greska = ex.InnerException.InnerException as SqlException;

                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }
            foreach (var vrstaSudenta in t.TipStudenta)
            {
                ObimStudent tipStudenta = new ObimStudent()
                {
                    TutorId = noviTutor.TutorId,
                    TipStudentaId = vrstaSudenta.TipoviStudentaId
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

                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }




            return Created("api/Tutor", noviTutor);//koricenje Creted radi neobicnog ponasanja API

        }


        [HttpPut]
        public IHttpActionResult PutTutor(int id, Tutor tutor)
        {

            var checkTutor = db.Tutors.Find(id);
            if (checkTutor==null) return NotFound();

            try
            {
                db.tsp_Tutor_Update(id, tutor.GradId, tutor.RadnoStanjeId, tutor.TutorTitulaId,
                                    tutor.NazivUstanove, tutor.CijenaCasa, tutor.TutorTumbnail, tutor.TutorSlika, tutor.LozinkaSalt, tutor.LozinkaHash,
                                    tutor.Email, tutor.Telefon, tutor.Adresa);
            }
            catch (EntityCommandExecutionException ex)
            {
                
                SqlException greska = ex.InnerException as SqlException;
                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }
            }
            var lst = db.ObimStudents.Where(x => x.TutorId == id);

            if (lst != null)
            {
                foreach (var item in lst)
                {
                    db.ObimStudents.Remove(item);
                }
               
            }

            foreach (var vrstaSudenta in tutor.TipStudenta)
            {
                ObimStudent tipStudenta = new ObimStudent()
                {
                    TutorId = checkTutor.TutorId,
                    TipStudentaId = vrstaSudenta.TipoviStudentaId
                };

                db.ObimStudents.Add(tipStudenta);

            }

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
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
                ReasonPhrase = reason,
                Content = new StringContent(reason)

            };

            return new HttpResponseException(msg);

        }
    }
}
