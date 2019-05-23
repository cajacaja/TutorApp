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
    public class PrijavaController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Prijava
        public IQueryable<Prijava> GetPrijavas()
        {
            return db.Prijavas;
        }

        // GET: api/Prijava/5
        [ResponseType(typeof(Prijava))]
        public IHttpActionResult GetPrijava(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Prijava prijava = db.Prijavas.Find(id);
            if (prijava == null)
            {
                return NotFound();
            }

            return Ok(prijava);
        }
        [HttpGet]
        [ResponseType(typeof(List<Prijava_SelectUcionica_Result>))]
        [Route("api/Prijava/PrijaveUcionica/{ucionicaId}")]
        public IHttpActionResult PrijaveUcionica(int ucionicaId)
        {
            Ucionica prijava = db.Ucionicas.Find(ucionicaId);
            if (prijava == null)
            {
                return NotFound();
            }

            var lstPrijava = db.tsp_Prijava_SelectUcionica(ucionicaId).ToList();


            return Ok(lstPrijava);
        }

        [HttpGet]
        [ResponseType(typeof(List<Prijave_SelectAccepted_Result>))]
        [Route("api/Prijava/SelectAccepted/{ucionicaId}")]
        public IHttpActionResult SelectAccepted(int ucionicaId)
        {
            Ucionica ucionica = db.Ucionicas.Find(ucionicaId);
            if (ucionica == null)
            {
                return NotFound();
            }

            return Ok(db.tsp_Prijave_SelectAccepted(ucionicaId).ToList());
        }


        // PUT: api/Prijava/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPrijava(int id, Prijava prijava)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prijava.PrijavaId)
            {
                return BadRequest();
            }

            db.Entry(prijava).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrijavaExists(id))
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

        // POST: api/Prijava
        [ResponseType(typeof(Prijava))]
        public IHttpActionResult PostPrijava(Prijava prijava)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Prijavas.Add(prijava);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = prijava.PrijavaId }, prijava);
        }

        // DELETE: api/Prijava/5
        [ResponseType(typeof(Prijava))]
        public IHttpActionResult DeletePrijava(int id)
        {
            Prijava prijava = db.Prijavas.Find(id);
            if (prijava == null)
            {
                return NotFound();
            }

            db.Prijavas.Remove(prijava);
            db.SaveChanges();

            return Ok(prijava);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PrijavaExists(int id)
        {
            return db.Prijavas.Count(e => e.PrijavaId == id) > 0;
        }
    }
}