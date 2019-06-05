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
    public class TipStudentaController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/TipStudenta
        public List<TipStudenta> GetTipStudentas()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.TipStudentas.ToList();
        }

        // GET: api/TipStudenta/5        
        [ResponseType(typeof(TipStudenta))]
        public IHttpActionResult GetTipStudenta(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            TipStudenta tipStudenta = db.TipStudentas.Find(id);
            if (tipStudenta==null) return NotFound();

            return Ok(tipStudenta);
        }

        
        // GET: api/TipStudenta/5        
        [HttpGet]
        [Route("api/TipStudenta/PreferiraniStudenti/{tutorId}")]
        [ResponseType(typeof(List<TipStudenta>))]
        public IHttpActionResult PreferiraniStudenti(int tutorId)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Tutor tutor = db.Tutors.Find(tutorId);
            if (tutor==null) return NotFound();

            var tipStudenta = from x in db.TipStudentas
                              join s in db.ObimStudents on x.TipoviStudentaId equals s.TipStudentaId
                              where s.TutorId == tutorId
                              select x;
            return Ok(tipStudenta.ToList());
        }

        // PUT: api/TipStudenta/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipStudenta(int id, TipStudenta tipStudenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipStudenta.TipoviStudentaId)
            {
                return BadRequest();
            }

            db.Entry(tipStudenta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipStudentaExists(id))
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

        // POST: api/TipStudenta
        [ResponseType(typeof(TipStudenta))]
        public IHttpActionResult PostTipStudenta(TipStudenta tipStudenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipStudentas.Add(tipStudenta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipStudenta.TipoviStudentaId }, tipStudenta);
        }

        // DELETE: api/TipStudenta/5
        [ResponseType(typeof(TipStudenta))]
        public IHttpActionResult DeleteTipStudenta(int id)
        {
            TipStudenta tipStudenta = db.TipStudentas.Find(id);
            if (tipStudenta == null)
            {
                return NotFound();
            }

            db.TipStudentas.Remove(tipStudenta);
            db.SaveChanges();

            return Ok(tipStudenta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipStudentaExists(int id)
        {
            return db.TipStudentas.Count(e => e.TipoviStudentaId == id) > 0;
        }
    }
}