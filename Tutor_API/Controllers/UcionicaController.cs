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
            Ucionica ucionica = db.Ucionicas.Find(id);
            if (ucionica == null)
            {
                return NotFound();
            }

            return Ok(ucionica);
        }

        [HttpGet]
        [ResponseType(typeof(List<Ucionica_SelectTutorUcionica_Result>))]
        [Route("api/Ucionica/TutorUcionice/{id}")]
        public IHttpActionResult TutorUcionice(int id) {

            var listaUcionica = db.tsp_Ucionica_SelectTutorUcionica(id).ToList();

            if (listaUcionica == null) return NotFound();


            return Ok(listaUcionica);
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ucionicas.Add(ucionica);
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