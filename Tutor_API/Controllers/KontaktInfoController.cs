using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

        // PUT: api/KorisnickiNalog/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnickiNalog(int id, KontaktInfo kontaktInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kontaktInfo.KontaktInfoId)
            {
                return BadRequest();
            }

            db.Entry(kontaktInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!KontaktInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    var nesto = ex.GetType().ToString();
                    SqlException greska = ex.InnerException as SqlException;
                    if (greska != null)
                    {
                        return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                    }
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
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