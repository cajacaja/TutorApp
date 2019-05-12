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
    public class PodkategorijaController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Podkategorija
        public List<Podkategorija> GetPodkategorijas()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.Podkategorijas.ToList();
        }

        // GET: api/Podkategorija/5
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult GetPodkategorija(int id)
        {
            Podkategorija podkategorija = db.Podkategorijas.Find(id);
            if (podkategorija == null)
            {
                return NotFound();
            }

            return Ok(podkategorija);
        }

        [HttpGet]
        [ResponseType(typeof(List<Predmet_Report_Result>))]
        [Route("api/Podkategorija/Report/{GradId?}/{DatumOd?}/{DatumDo?}")]
        public IHttpActionResult Report(int GradId,DateTime DatumOd,DateTime DatumDo) {

            if (GradId == 0)
            {
               return Ok(db.tps_Predmet_Report(null, DatumOd, DatumDo).ToList());
            }

           return Ok(db.tps_Predmet_Report(GradId, DatumOd, DatumDo).ToList());
        }

        

        // PUT: api/Podkategorija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPodkategorija(int id, Podkategorija podkategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != podkategorija.PodKategorijaId)
            {
                return BadRequest();
            }

            db.Entry(podkategorija).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PodkategorijaExists(id))
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

        // POST: api/Podkategorija
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult PostPodkategorija(Podkategorija podkategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Podkategorijas.Add(podkategorija);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = podkategorija.PodKategorijaId }, podkategorija);
        }

        // DELETE: api/Podkategorija/5
        [ResponseType(typeof(Podkategorija))]
        public IHttpActionResult DeletePodkategorija(int id)
        {
            Podkategorija podkategorija = db.Podkategorijas.Find(id);
            if (podkategorija == null)
            {
                return NotFound();
            }

            db.Podkategorijas.Remove(podkategorija);
            db.SaveChanges();

            return Ok(podkategorija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PodkategorijaExists(int id)
        {
            return db.Podkategorijas.Count(e => e.PodKategorijaId == id) > 0;
        }
    }
}