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
    public class KorisnickiNalogController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/KorisnickiNalog
        public IQueryable<KorisnickiNalog> GetKorisnickiNalogs()
        {
            return db.KorisnickiNalogs;
        }

        // GET: api/KorisnickiNalog/5
        [ResponseType(typeof(KorisnickiNalog))]
        public IHttpActionResult GetKorisnickiNalog(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            KorisnickiNalog korisnickiNalog = db.KorisnickiNalogs.Find(id);
            if (korisnickiNalog == null)
            {
                return NotFound();
            }

            return Ok(korisnickiNalog);
        }

        // PUT: api/KorisnickiNalog/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnickiNalog(int id, KorisnickiNalog korisnickiNalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnickiNalog.KorisnickiNalogId)
            {
                return BadRequest();
            }

            db.Entry(korisnickiNalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisnickiNalogExists(id))
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

        // POST: api/KorisnickiNalog
        [ResponseType(typeof(KorisnickiNalog))]
        public IHttpActionResult PostKorisnickiNalog(KorisnickiNalog korisnickiNalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KorisnickiNalogs.Add(korisnickiNalog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisnickiNalog.KorisnickiNalogId }, korisnickiNalog);
        }

        // DELETE: api/KorisnickiNalog/5
        [ResponseType(typeof(KorisnickiNalog))]
        public IHttpActionResult DeleteKorisnickiNalog(int id)
        {
            KorisnickiNalog korisnickiNalog = db.KorisnickiNalogs.Find(id);
            if (korisnickiNalog == null)
            {
                return NotFound();
            }

            db.KorisnickiNalogs.Remove(korisnickiNalog);
            db.SaveChanges();

            return Ok(korisnickiNalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisnickiNalogExists(int id)
        {
            return db.KorisnickiNalogs.Count(e => e.KorisnickiNalogId == id) > 0;
        }
    }
}