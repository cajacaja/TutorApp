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
    public class BanPrijavaTutorsController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/BanPrijavaTutors
        public List<BanTutor_Select_Result> GetBanPrijavaTutors()
        {
            return db.tsp_BanPrijavaTutor_Select().ToList();
        }

        // GET: api/BanPrijavaTutors/5
        [ResponseType(typeof(BanPrijavaTutor_SelectOne_Result))]
        public IHttpActionResult GetBanPrijavaTutor(int id)
        {
            var banPrijavaTutor = db.tsp_BanPrijavaTutor_SelectOne(id).FirstOrDefault();
            if (banPrijavaTutor == null)
            {
                return NotFound();
            }

            return Ok(banPrijavaTutor);
        }

        // PUT: api/BanPrijavaTutors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBanPrijavaTutor(int id, BanPrijavaTutor banPrijavaTutor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != banPrijavaTutor.PrijavaTutorId)
            {
                return BadRequest();
            }

            db.Entry(banPrijavaTutor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BanPrijavaTutorExists(id))
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

        // POST: api/BanPrijavaTutors
        [ResponseType(typeof(BanPrijavaTutor))]
        public IHttpActionResult PostBanPrijavaTutor(BanPrijavaTutor banPrijavaTutor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BanPrijavaTutors.Add(banPrijavaTutor);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BanPrijavaTutorExists(banPrijavaTutor.PrijavaTutorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = banPrijavaTutor.PrijavaTutorId }, banPrijavaTutor);
        }

        // DELETE: api/BanPrijavaTutors/5
        [ResponseType(typeof(BanPrijavaTutor))]
        public IHttpActionResult DeleteBanPrijavaTutor(int id)
        {
            BanPrijavaTutor banPrijavaTutor = db.BanPrijavaTutors.Find(id);
            if (banPrijavaTutor == null)
            {
                return NotFound();
            }

            db.BanPrijavaTutors.Remove(banPrijavaTutor);
            db.SaveChanges();

            return Ok(banPrijavaTutor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BanPrijavaTutorExists(int id)
        {
            return db.BanPrijavaTutors.Count(e => e.PrijavaTutorId == id) > 0;
        }
    }
}