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
    public class RadnoStanjeController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/RadnoStanje
        public List<RadnoStanje> GetRadnoStanjes()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.RadnoStanjes.ToList();
        }

        // GET: api/RadnoStanje/5
        [ResponseType(typeof(RadnoStanje))]
        public IHttpActionResult GetRadnoStanje(int id)
        {
            RadnoStanje radnoStanje = db.RadnoStanjes.Find(id);
            if (radnoStanje == null)
            {
                return NotFound();
            }

            return Ok(radnoStanje);
        }

        // PUT: api/RadnoStanje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRadnoStanje(int id, RadnoStanje radnoStanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != radnoStanje.RadnoStanjeId)
            {
                return BadRequest();
            }

            db.Entry(radnoStanje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RadnoStanjeExists(id))
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

        // POST: api/RadnoStanje
        [ResponseType(typeof(RadnoStanje))]
        public IHttpActionResult PostRadnoStanje(RadnoStanje radnoStanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RadnoStanjes.Add(radnoStanje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = radnoStanje.RadnoStanjeId }, radnoStanje);
        }

        // DELETE: api/RadnoStanje/5
        [ResponseType(typeof(RadnoStanje))]
        public IHttpActionResult DeleteRadnoStanje(int id)
        {
            RadnoStanje radnoStanje = db.RadnoStanjes.Find(id);
            if (radnoStanje == null)
            {
                return NotFound();
            }

            db.RadnoStanjes.Remove(radnoStanje);
            db.SaveChanges();

            return Ok(radnoStanje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RadnoStanjeExists(int id)
        {
            return db.RadnoStanjes.Count(e => e.RadnoStanjeId == id) > 0;
        }
    }
}