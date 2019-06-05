using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;

namespace Tutor_API.Controllers
{
    public class UcionicaController : ApiController
    {
        private TutorEntities db = new TutorEntities();


        // GET: api/Ucionica
        public IQueryable<Ucionica> GetUcionicas()
        {
            return db.Ucionicas;
        }

        // GET: api/Ucionica/5
        [ResponseType(typeof(Ucionica))]
        public IHttpActionResult GetUcionica(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Ucionica ucionica = db.Ucionicas.Find(id);
            if (ucionica == null)
            {
                return NotFound();
            }

            return Ok(ucionica);
        }

        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectActive_Result>))]
        [Route("api/Ucionica/AktivneUcionice/{OblastId?}/{GradId?}")]
        public IHttpActionResult AktivneUcionice(int OblastId = 0, int GradId = 0) {

            if (OblastId == 0) {

                if (GradId == 0) {

                    return Ok(db.tsp_Ucionica_SelectActive(null, null).ToList());
                }
                return Ok(db.tsp_Ucionica_SelectActive(null, GradId).ToList());
            }

            if (GradId == 0) {
                return Ok(db.tsp_Ucionica_SelectActive(OblastId, null).ToList());
            }

            return Ok(db.tsp_Ucionica_SelectActive(OblastId, GradId).ToList());
        }


        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectStaro_Result>))]
        [Route("api/Ucionica/StareUcionice/{OblastId?}/{GradId?}")]
        public IHttpActionResult StareUcionice(int OblastId = 0, int GradId = 0)
        {

            if (OblastId == 0)
            {

                if (GradId == 0)
                {

                    return Ok(db.tsp_Ucionica_SelectStaro(null, null).ToList());
                }
                return Ok(db.tsp_Ucionica_SelectStaro(null, GradId).ToList());
            }

            if (GradId == 0)
            {
                return Ok(db.tsp_Ucionica_SelectStaro(OblastId, null).ToList());
            }

            return Ok(db.tsp_Ucionica_SelectStaro(OblastId, GradId).ToList());
        }

        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectTutorUcionica_Result>))]
        [Route("api/Ucionica/TutorUcionice/{id}")]
        public IHttpActionResult TutorUcionice(int id) {

            var listaUcionica = db.tsp_Ucionica_SelectTutorUcionica(id).ToList();

            if (listaUcionica == null) return NotFound();


            return Ok(listaUcionica);
        }

        [HttpGet]
        [ResponseType(typeof(Ucionica_Details_Result))]
        [Route("api/Ucionica/UcionicaDetails/{id}")]
        public IHttpActionResult UcionicaDetails(int id) {

            var ucionica = db.Ucionicas.Find(id);

            if (ucionica == null) return NotFound();



            return Ok(db.tsp_Ucionica_Details(id).FirstOrDefault());
        }

        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectUcenici_Result>))]
        [Route("api/Ucionica/StudentiUcionice/{id}")]
        public IHttpActionResult StudentiUcionice(int id)
        {

            var ucionica = db.Ucionicas.Find(id);

            if (ucionica == null) return NotFound();



            return Ok(db.tsp_Ucionica_SelectUcenici(id).ToList());
        }

        [HttpGet]
        [ResponseType(typeof(Ucionica_SelectDetails_Result))]
        [Route("api/Ucionica/Details/{ucionicaId}")]
        public IHttpActionResult Details(int ucionicaId)
        {
            var ucionica = db.Ucionicas.Find(ucionicaId);
            if (ucionica==null) return NotFound();

            return Ok(db.tsp_Ucionica_SelectDetails(ucionicaId).FirstOrDefault());
        }

        [HttpGet]
        [ResponseType(typeof(List<Termin>))]
        [Route("api/Ucionica/Termini/{ucionicaId}")]
        public IHttpActionResult Termini(int ucionicaId)
        {
            db.Configuration.LazyLoadingEnabled = false;

            var ucionica = db.Ucionicas.Find(ucionicaId);
            if (ucionica==null) return NotFound();

            var lstTermina = db.Termins.Where(x => x.UcionicaId==ucionicaId).ToList();

            return Ok(lstTermina);
        }


        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectByOblast_Result>))]
        [Route("api/Ucionica/selectMobile/{oblastId}/{gradId}/{tipStudentaId}/{page}/{pageSize}")]
        public IHttpActionResult selectMobile(int oblastId, int gradId, int tipStudentaId, int page, int pageSize)
        {
            return Ok(db.tsp_Ucionica_SelectByOblast(oblastId, gradId, tipStudentaId, page, pageSize).ToList());
        }

        [HttpGet]
        [ResponseType(typeof(int))]
        [Route("api/Ucionica/selectMobileNum/{oblastId}/{gradId}/{tipStudentaId}")]
        public IHttpActionResult selectMobileNum(int oblastId, int gradId, int tipStudentaId)
        {
            var brojUcionica = from u in db.Ucionicas
                               join t in db.Tutors on u.TutorId equals t.TutorId
                               join p in db.Podkategorijas on t.PodKategorijaId equals p.PodKategorijaId
                               join o in db.Oblasts on p.OblastId equals o.OblastId
                               join ob in db.ObimStudents on t.TutorId equals ob.TutorId
                               where o.OblastId == oblastId && t.GradId == gradId && ob.TipStudentaId == tipStudentaId && u.Aktivna==true && u.DatumPocetka>DateTime.Today
                               select u.UcionicaId;

           return Ok(brojUcionica.Count());
         }
        // PUT: api/Ucionica/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUcionica(int id, Ucionica ucionica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ucionica.UcionicaId)
            {
                return BadRequest();
            }

            db.Entry(ucionica).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UcionicaExists(id))
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

        // POST: api/Ucionica
        [ResponseType(typeof(Ucionica))]
        public IHttpActionResult PostUcionica(Ucionica ucionica)
        {
            Ucionica novaUcionica = new Ucionica()
            {
                TutorId=ucionica.TutorId,
                Naslov = ucionica.Naslov,
                Opis = ucionica.Opis,
                Slika = ucionica.Slika,
                AdresaUcionice = ucionica.AdresaUcionice,
                NivoTezineId = ucionica.NivoTezineId,
                Cijena = ucionica.Cijena,
                BrojCasova = ucionica.BrojCasova,
                MaxBrojPolaznika = ucionica.MaxBrojPolaznika,
                DatumPocetka = ucionica.DatumPocetka,
                DatumZavrsetka = ucionica.DatumZavrsetka,
                Aktivna=true

            };

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ucionicas.Add(novaUcionica);
            db.SaveChanges();

            foreach (var termin in ucionica.Termini)
            {
                Termin noviTermin = new Termin
                {
                    UcionicaId = novaUcionica.UcionicaId,
                    PocetakCasa = termin.PocetakCasa,
                    Dan = termin.Dan
                };

                db.Termins.Add(noviTermin);
            }

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ucionica.UcionicaId }, ucionica);
        }

        // DELETE: api/Ucionica/5
        [ResponseType(typeof(Ucionica))]
        public IHttpActionResult DeleteUcionica(int id)
        {
            Ucionica ucionica = db.Ucionicas.Find(id);
            if (ucionica == null)
            {
                return NotFound();
            }

            db.Ucionicas.Remove(ucionica);
            db.SaveChanges();

            return Ok(ucionica);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UcionicaExists(int id)
        {
            return db.Ucionicas.Count(e => e.UcionicaId == id) > 0;
        }
    }
}