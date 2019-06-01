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
    public class SpolController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Spol
        public List<Spol> GetSpols()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.Spols.ToList();
        }

        //GET: api/Spol/5
        [ResponseType(typeof(Spol))]
        public IHttpActionResult GetSpol(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Spol spol = db.Spols.Find(id);
            if (spol == null)
            {
                return NotFound();
            }

            return Ok(spol);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SpolExists(int id)
        {
            return db.Spols.Count(e => e.SpolId == id) > 0;
        }
    }
}