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
    public class ZahtjevController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Zahtjev
        public IQueryable<Zahtjev> GetZahtjevs()
        {
            return db.Zahtjevs;
        }

        // GET: api/Zahtjev/5
        [ResponseType(typeof(List<Zahtjev_SelectByTutorId_Result>))]
        public IHttpActionResult GetZahtjev(int id)
        {
            var zahtjev = db.tps_Zahtjev_SelectByTutorId(id).ToList();
            if (zahtjev == null)
            {
                return NotFound();
            }

            return Ok(zahtjev);
        }

        // PUT: api/Zahtjev/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZahtjev(int id, Zahtjev zahtjev)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zahtjev.ZahtjevId)
            {
                return BadRequest();
            }

            db.Entry(zahtjev).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZahtjevExists(id))
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

        // POST: api/Zahtjev
        [ResponseType(typeof(Zahtjev))]
        public IHttpActionResult PostZahtjev(Zahtjev zahtjev)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zahtjevs.Add(zahtjev);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zahtjev.ZahtjevId }, zahtjev);
        }

        // DELETE: api/Zahtjev/5
        [ResponseType(typeof(Zahtjev))]
        public IHttpActionResult DeleteZahtjev(int id)
        {
            Zahtjev zahtjev = db.Zahtjevs.Find(id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            db.Zahtjevs.Remove(zahtjev);
            db.SaveChanges();

            return Ok(zahtjev);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZahtjevExists(int id)
        {
            return db.Zahtjevs.Count(e => e.ZahtjevId == id) > 0;
        }
    }
}