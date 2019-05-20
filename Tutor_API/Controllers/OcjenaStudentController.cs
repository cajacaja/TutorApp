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
    public class OcjenaStudentController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/OcjenaStudent
        public IQueryable<OcjenaStudent> GetOcjenaStudents()
        {
            return db.OcjenaStudents;
        }

        [HttpGet]
        [Route("api/OcjenaStudent/GetOcjene/{id}")]
        [ResponseType(typeof(List<OcjenaStudent_SelectComments_Result>))]
        public IHttpActionResult GetOcjene(int id) {

           
            Student ocjenaStudent = db.Students.Find(id);
            if (ocjenaStudent == null)
            {
                return NotFound();
            }


            return Ok(db.tsp_OcjenaStudent_SelectComments(id).ToList());
        }

        // GET: api/OcjenaStudent/5
        [ResponseType(typeof(OcjenaStudent))]
        public IHttpActionResult GetOcjenaStudent(int id)
        {
            OcjenaStudent ocjenaStudent = db.OcjenaStudents.Find(id);
            if (ocjenaStudent == null)
            {
                return NotFound();
            }

            return Ok(ocjenaStudent);
        }

        [HttpGet]
        [Route("api/OcjenaStudent/checkTutor/{tutorId}/{studentId}")]
        public IHttpActionResult checkTutor (int tutorId,int studentId)
        {
            var ocjena = db.OcjenaStudents.FirstOrDefault(x => x.TutorId == tutorId && x.StudentId==studentId);
            if (ocjena == null) return NotFound();

            return Ok();
        }
        // PUT: api/OcjenaStudent/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjenaStudent(int id, OcjenaStudent ocjenaStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjenaStudent.OcjenaStudentId)
            {
                return BadRequest();
            }

            db.Entry(ocjenaStudent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjenaStudentExists(id))
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

        // POST: api/OcjenaStudent
        [ResponseType(typeof(OcjenaStudent))]
        public IHttpActionResult PostOcjenaStudent(OcjenaStudent ocjenaStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OcjenaStudents.Add(ocjenaStudent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjenaStudent.OcjenaStudentId }, ocjenaStudent);
        }

        // DELETE: api/OcjenaStudent/5
        [ResponseType(typeof(OcjenaStudent))]
        public IHttpActionResult DeleteOcjenaStudent(int id)
        {
            OcjenaStudent ocjenaStudent = db.OcjenaStudents.Find(id);
            if (ocjenaStudent == null)
            {
                return NotFound();
            }

            db.OcjenaStudents.Remove(ocjenaStudent);
            db.SaveChanges();

            return Ok(ocjenaStudent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjenaStudentExists(int id)
        {
            return db.OcjenaStudents.Count(e => e.OcjenaStudentId == id) > 0;
        }
    }
}