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
    public class TerminController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Termin
        public IQueryable<Termin> GetTermins()
        {
            return db.Termins;
        }

        // GET: api/Termin/5
        [ResponseType(typeof(Termin))]
        public IHttpActionResult GetTermin(int id)
        {
            Termin termin = db.Termins.Find(id);
            if (termin == null)
            {
                return NotFound();
            }

            return Ok(termin);
        }

        [HttpGet]
        [ResponseType(typeof(List<Termin>))]
        [Route("api/Termin/Termini/{ucionicaId}")]
        public IHttpActionResult Termini(int ucionicaId)
        {
            db.Configuration.LazyLoadingEnabled = false;

            var ucionica = db.Ucionicas.Find(ucionicaId);
            if (ucionica.Equals(null)) return NotFound();

            var lstTermina = db.Termins.Where(x => x.UcionicaId.Equals(ucionicaId)).ToList();

            return Ok(lstTermina);
        }

        // PUT: api/Termin/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTermin(int id, Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termin.TerminId)
            {
                return BadRequest();
            }

            db.Entry(termin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerminExists(id))
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

        // POST: api/Termin
        [ResponseType(typeof(Termin))]
        public IHttpActionResult PostTermin(Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Termins.Add(termin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = termin.TerminId }, termin);
        }

        // DELETE: api/Termin/5
        [ResponseType(typeof(Termin))]
        public IHttpActionResult DeleteTermin(int id)
        {
            Termin termin = db.Termins.Find(id);
            if (termin == null)
            {
                return NotFound();
            }

            db.Termins.Remove(termin);
            db.SaveChanges();

            return Ok(termin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TerminExists(int id)
        {
            return db.Termins.Count(e => e.TerminId == id) > 0;
        }
    }
}