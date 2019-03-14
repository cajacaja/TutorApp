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
    public class GradController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Grad
        public List<Grad_Result> GetGrads()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.tsp_Grad_SelectAll().ToList();
        }

        // GET: api/Grad/5
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetGrad(int id)
        {
            Grad grad = db.Grads.Find(id);
            if (grad == null)
            {
                return NotFound();
            }

            return Ok(grad);
        }

        // PUT: api/Grad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGrad(int id, Grad grad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grad.GradId)
            {
                return BadRequest();
            }

            db.Entry(grad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradExists(id))
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

        // POST: api/Grad
        [ResponseType(typeof(Grad))]
        public IHttpActionResult PostGrad(Grad grad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Grads.Add(grad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = grad.GradId }, grad);
        }

        // DELETE: api/Grad/5
        [ResponseType(typeof(Grad))]
        public IHttpActionResult DeleteGrad(int id)
        {
            Grad grad = db.Grads.Find(id);
            if (grad == null)
            {
                return NotFound();
            }

            db.Grads.Remove(grad);
            db.SaveChanges();

            return Ok(grad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GradExists(int id)
        {
            return db.Grads.Count(e => e.GradId == id) > 0;
        }
    }
}