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
    public class OcjenaTutorController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/OcjenaTutor
        public IQueryable<OcjenaTutor> GetOcjenaTutors()
        {
            return db.OcjenaTutors;
        }

        // GET: api/OcjenaTutor/5
        [ResponseType(typeof(OcjenaTutor))]
        public IHttpActionResult GetOcjenaTutor(int id)
        {
            OcjenaTutor ocjenaTutor = db.OcjenaTutors.Find(id);
            if (ocjenaTutor == null)
            {
                return NotFound();
            }

            return Ok(ocjenaTutor);
        }

        [HttpGet]
        [ResponseType(typeof(Tutor_ReviewsSelect_Result))]
        [Route("api/OcjenaTutor/TutorReview/{id}")]
        public IHttpActionResult TutorReview(int id)
        {
            var checkTutor = db.OcjenaTutors.FirstOrDefault(x => x.TutorId == id);
            var listReviews = db.tsp_Tutor_ReviewsSelect(id).ToList();
            if (checkTutor == null)
            {
                return NotFound();
            }

            return Ok(listReviews);
        }


        [HttpGet]
        [ResponseType(typeof(double))]
        [Route("api/OcjenaTutor/OcjenaAvg/{id}")]
        public IHttpActionResult OcjenaAvg(int id) {

            var checkTutor = db.OcjenaTutors.FirstOrDefault(x => x.TutorId == id);
            if (checkTutor == null) return NotFound();

            var Ocjena = db.OcjenaTutors.Where(x => x.TutorId == id).Average(x => x.Ocjena);

            return Ok(Ocjena);
        }


        // PUT: api/OcjenaTutor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjenaTutor(int id, OcjenaTutor ocjenaTutor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjenaTutor.OcjenaTutorId)
            {
                return BadRequest();
            }

            db.Entry(ocjenaTutor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjenaTutorExists(id))
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

        // POST: api/OcjenaTutor
        [ResponseType(typeof(OcjenaTutor))]
        public IHttpActionResult PostOcjenaTutor(OcjenaTutor ocjenaTutor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OcjenaTutors.Add(ocjenaTutor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjenaTutor.OcjenaTutorId }, ocjenaTutor);
        }

        // DELETE: api/OcjenaTutor/5
        [ResponseType(typeof(OcjenaTutor))]
        public IHttpActionResult DeleteOcjenaTutor(int id)
        {
            OcjenaTutor ocjenaTutor = db.OcjenaTutors.Find(id);
            if (ocjenaTutor == null)
            {
                return NotFound();
            }

            db.OcjenaTutors.Remove(ocjenaTutor);
            db.SaveChanges();

            return Ok(ocjenaTutor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjenaTutorExists(int id)
        {
            return db.OcjenaTutors.Count(e => e.OcjenaTutorId == id) > 0;
        }
    }
}