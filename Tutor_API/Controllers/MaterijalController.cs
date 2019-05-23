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
    public class MaterijalController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Materijal
        public List<Materijal> GetMaterijals()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.Materijals.ToList();
        }

        // GET: api/Materijal/5
        [ResponseType(typeof(Materijal))]
        public IHttpActionResult GetMaterijal(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Materijal materijal = db.Materijals.Find(id);
            if (materijal == null)
            {
                return NotFound();
            }

            return Ok(materijal);
        }
        [HttpGet]
        [ResponseType(typeof(List<Materijal_Select_Result>))]
        [Route("api/Materijal/GetMaterijale/{ucionicaId}")]
        public IHttpActionResult GetMaterijale(int ucionicaId)
        {
            Ucionica ucionica = db.Ucionicas.Find(ucionicaId);
            if (ucionica == null)
            {
                return NotFound();
            }

            var materijali = db.tsp_Materijal_Select(ucionicaId).ToList();

            return Ok(materijali);
        }

        // PUT: api/Materijal/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMaterijal(int id, Materijal materijal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != materijal.MaterijalId)
            {
                return BadRequest();
            }

            db.Entry(materijal).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterijalExists(id))
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

        // POST: api/Materijal
        [ResponseType(typeof(Materijal))]
        public IHttpActionResult PostMaterijal(Materijal materijal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Materijals.Add(materijal);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = materijal.MaterijalId }, materijal);
        }

        // DELETE: api/Materijal/5
        [ResponseType(typeof(Materijal))]
        public IHttpActionResult DeleteMaterijal(int id)
        {
            Materijal materijal = db.Materijals.Find(id);
            if (materijal == null)
            {
                return NotFound();
            }

            db.Materijals.Remove(materijal);
            db.SaveChanges();

            return Ok(materijal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MaterijalExists(int id)
        {
            return db.Materijals.Count(e => e.MaterijalId == id) > 0;
        }
    }
}