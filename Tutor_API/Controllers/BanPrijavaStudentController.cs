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
    public class BanPrijavaStudentController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/BanPrijavaStudent
        public List<BanStudente_Select_Result> GetBanPrijavaStudents()
        {
            return db.tsp_BanPrijavaStudente_Select().ToList();
        }

        // GET: api/BanPrijavaStudent/5
        [ResponseType(typeof(BanPrijavaStudente_SelectOne_Result))]
        public IHttpActionResult GetBanPrijavaStudent(int id)
        {
            var Prijava = db.tsp_BanPrijavaStudente_SelectOne(id).FirstOrDefault();

            if (Prijava == null) return NotFound();

            return Ok(Prijava);
        }

        //PUT: api/BanPrijavaStudent/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBanPrijavaStudent(int id, BanPrijavaStudent banPrijavaStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != banPrijavaStudent.PrijavaStudentId)
            {
                return BadRequest();
            }

            db.Entry(banPrijavaStudent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BanPrijavaStudentExists(id))
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

       
        // POST: api/BanPrijavaStudent
        [ResponseType(typeof(BanPrijavaStudent))]
        public IHttpActionResult PostBanPrijavaStudent(BanPrijavaStudent banPrijavaStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BanPrijavaStudents.Add(banPrijavaStudent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = banPrijavaStudent.PrijavaStudentId }, banPrijavaStudent);
        }

        // DELETE: api/BanPrijavaStudent/5
        [ResponseType(typeof(BanPrijavaStudent))]
        public IHttpActionResult DeleteBanPrijavaStudent(int id)
        {
            BanPrijavaStudent banPrijavaStudent = db.BanPrijavaStudents.Find(id);
            if (banPrijavaStudent == null)
            {
                return NotFound();
            }

            db.BanPrijavaStudents.Remove(banPrijavaStudent);
            db.SaveChanges();

            return Ok(banPrijavaStudent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BanPrijavaStudentExists(int id)
        {
            return db.BanPrijavaStudents.Count(e => e.PrijavaStudentId == id) > 0;
        }
    }
}