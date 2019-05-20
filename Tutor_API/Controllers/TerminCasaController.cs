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
    public class TerminCasaController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/TerminCasa
        public IQueryable<TerminCasa> GetTerminCasas()
        {
            return db.TerminCasas;
        }

        // GET: api/TerminCasa/5
        [ResponseType(typeof(List<TerminCasa>))]
        public IHttpActionResult GetTerminCasa(int id)
        {
            //lista termina zavisno od zahtjevId
            db.Configuration.LazyLoadingEnabled = false;
            Zahtjev zahtjev = db.Zahtjevs.FirstOrDefault(x=>x.ZahtjevId==id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            return Ok(db.TerminCasas.Where(x=>x.ZahtjevId.Equals(id)).ToList());
        }

        [HttpGet]
        [ResponseType(typeof(List<TerminCas_SelectTermins_Result>))]
        [Route("api/TerminCasa/AcceptedTermini/{tutorId}")]
        public IHttpActionResult AcceptedTermini(int tutorId)
        {
            Tutor tutor = db.Tutors.Find(tutorId);
            if (tutor == null) return NotFound();

            return Ok(db.tsp_TerminCas_SelectTermins(tutorId).ToList());
        }
        // PUT: api/TerminCasa/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTerminCasa(int id, TerminCasa terminCasa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != terminCasa.TerminId)
            {
                return BadRequest();
            }

            db.Entry(terminCasa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerminCasaExists(id))
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

        // POST: api/TerminCasa
        [ResponseType(typeof(TerminCasa))]
        public IHttpActionResult PostTerminCasa(TerminCasa terminCasa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TerminCasas.Add(terminCasa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = terminCasa.TerminId }, terminCasa);
        }

        // DELETE: api/TerminCasa/5
        [ResponseType(typeof(TerminCasa))]
        public IHttpActionResult DeleteTerminCasa(int id)
        {
            TerminCasa terminCasa = db.TerminCasas.Find(id);
            if (terminCasa == null)
            {
                return NotFound();
            }

            db.TerminCasas.Remove(terminCasa);
            db.SaveChanges();

            return Ok(terminCasa);
        }
        [HttpGet]
        [Route("api/TerminCasa/DeleteTermine/{tutorId}")]
        public IHttpActionResult DeleteTermine(int tutorId)
        {
            var juce = DateTime.Today.AddDays(-1);
            var lstObrisani = from x in db.Zahtjevs
                              join s in db.TerminCasas on x.ZahtjevId equals s.ZahtjevId
                              where s.DatumCasa<juce
                              select s.TerminId;

            if (lstObrisani == null) return NotFound();

            foreach (var item in lstObrisani)
            {
                var termin = db.TerminCasas.Find(item);
                db.TerminCasas.Remove(termin);
            }
            db.SaveChanges();

            return Ok(lstObrisani);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TerminCasaExists(int id)
        {
            return db.TerminCasas.Count(e => e.TerminId == id) > 0;
        }
    }
}