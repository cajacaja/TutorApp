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
    public class OblastController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Oblast
        public List<Oblast> GetOblasts()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.Oblasts.ToList();
        }

        // GET: api/Oblast/5
        [ResponseType(typeof(Oblast))]
        public IHttpActionResult GetOblast(int id)
        {
            Oblast oblast = db.Oblasts.Find(id);
            if (oblast == null)
            {
                return NotFound();
            }

            return Ok(oblast);
        }

        // PUT: api/Oblast/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOblast(int id, Oblast oblast)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oblast.OblastId)
            {
                return BadRequest();
            }

            db.Entry(oblast).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OblastExists(id))
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

        // POST: api/Oblast
        [ResponseType(typeof(Oblast))]
        public IHttpActionResult PostOblast(Oblast oblast)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Oblasts.Add(oblast);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oblast.OblastId }, oblast);
        }

        // DELETE: api/Oblast/5
        [ResponseType(typeof(Oblast))]
        public IHttpActionResult DeleteOblast(int id)
        {
            Oblast oblast = db.Oblasts.Find(id);
            if (oblast == null)
            {
                return NotFound();
            }

            db.Oblasts.Remove(oblast);
            db.SaveChanges();

            return Ok(oblast);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OblastExists(int id)
        {
            return db.Oblasts.Count(e => e.OblastId == id) > 0;
        }
    }
}