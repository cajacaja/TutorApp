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
        [ResponseType(typeof(Zahtjev))]
        public IHttpActionResult GetZahtjev(int id)
        {

            db.Configuration.LazyLoadingEnabled = false;
            var zahtjev = db.Zahtjevs.Find(id);
            if (zahtjev==null) return NotFound();

            return Ok(zahtjev);
        }

        
        [HttpGet]
        [ResponseType(typeof(List<Zahtjev_SelectUnread_Result>))]
        [Route("api/Zahtjev/UnreadZahtjev/{id}")]
        public IHttpActionResult UnreadZahtjev(int id)
        {
            var tutor = db.Tutors.Find(id);

            if (tutor == null) return NotFound();

            var lstZahtjeva = db.tsp_Zahtjev_SelectUnread(id).ToList();

            return Ok(lstZahtjeva);
        }


        [HttpGet]
        [ResponseType(typeof(Zahtjev_SelectDetail_Result))]
        [Route("api/Zahtjev/ZahtjevDetail/{id}")]
        public IHttpActionResult ZahtjevDetail(int id)
        {
            var zahtjev = db.Zahtjevs.Find(id);

            if (zahtjev == null) return NotFound();

            var zahtjevDetail = db.tsp_Zahtjev_SelectDetail(id).FirstOrDefault();

            return Ok(zahtjevDetail);
        }

        [HttpGet]
        [ResponseType(typeof(List<Zahtjevi_SelectAktuelne>))]
        [Route("api/Zahtjev/Aktuelni/{studentId}")]
        public IHttpActionResult Aktuelni(int studentId)
        {
            var student = db.Students.Find(studentId);

            if (student==null) return NotFound();

            

            return Ok(db.tsp_Zahtjevi_SelectAktulne(studentId).ToList());
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