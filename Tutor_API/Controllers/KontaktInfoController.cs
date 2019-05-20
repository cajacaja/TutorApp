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
    public class KontaktInfoController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        

        // GET: api/KontaktInfo/5
        [ResponseType(typeof(KontaktInfo))]
        public IHttpActionResult GetKontaktInfo(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            KontaktInfo kontaktInfo = db.KontaktInfoes.Find(id);
            if (kontaktInfo == null)
            {
                return NotFound();
            }

            return Ok(kontaktInfo);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KontaktInfoExists(int id)
        {
            return db.KontaktInfoes.Count(e => e.KontaktInfoId == id) > 0;
        }
    }
}