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
    public class TutorTitulaController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/TutorTitula
        public List<TutorTitula> GetTutorTitulas()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.TutorTitulas.ToList();
        }

        // GET: api/TutorTitula/5
        [ResponseType(typeof(TutorTitula))]
        public IHttpActionResult GetTutorTitula(int id)
        {
            TutorTitula tutorTitula = db.TutorTitulas.Find(id);
            if (tutorTitula == null)
            {
                return NotFound();
            }

            return Ok(tutorTitula);
        }

        // PUT: api/TutorTitula/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTutorTitula(int id, TutorTitula tutorTitula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tutorTitula.TutorTitulaId)
            {
                return BadRequest();
            }

            db.Entry(tutorTitula).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorTitulaExists(id))
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

        // POST: api/TutorTitula
        [ResponseType(typeof(TutorTitula))]
        public IHttpActionResult PostTutorTitula(TutorTitula tutorTitula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TutorTitulas.Add(tutorTitula);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tutorTitula.TutorTitulaId }, tutorTitula);
        }

        // DELETE: api/TutorTitula/5
        [ResponseType(typeof(TutorTitula))]
        public IHttpActionResult DeleteTutorTitula(int id)
        {
            TutorTitula tutorTitula = db.TutorTitulas.Find(id);
            if (tutorTitula == null)
            {
                return NotFound();
            }

            db.TutorTitulas.Remove(tutorTitula);
            db.SaveChanges();

            return Ok(tutorTitula);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TutorTitulaExists(int id)
        {
            return db.TutorTitulas.Count(e => e.TutorTitulaId == id) > 0;
        }
    }
}