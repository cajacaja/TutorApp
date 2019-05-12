using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;
using Tutor_API.Util;

namespace Tutor_API.Controllers
{
    public class AdministratorController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        [HttpGet]
        [ResponseType(typeof(List<Administrator_SelectAll>))]
        public List<Administrator_SelectAll> GetAdministrator()
        {

            return db.tsp_Administrator_SelectAll().ToList();
        }

        [HttpGet]
        public IHttpActionResult GetAdministrator(int id)
        {
            Administrator_SelectOne admin = db.tsp_Administrator_SelectOne(id).FirstOrDefault();
            if (admin == null)
            {
                return NotFound();
            }

            return Ok(admin);
        }

        [HttpGet]
        [Route("api/Administrator/SearchByName/{name?}")]
        public List<Administrator_NameSelect> SearchByName(string name = "")
        {
            return db.tsp_Administrator_SelectByImePrezime(name).ToList();
        }

        [HttpGet]
        [Route("api/Administrator/LoginCheck/{username}/{password}")]
        [ResponseType(typeof(Tutor))]
        public IHttpActionResult LoginCheck(string username, string password)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var korisnickiNalog = db.KorisnickiNalogs.FirstOrDefault(x => x.KorisnickoIme == username);
            if (korisnickiNalog == null) return NotFound();

            var passwordHash = PasswordCheck.GenerateHash(korisnickiNalog.LozinkaSalt, password);
            if (passwordHash != korisnickiNalog.LozinkaHash) return NotFound();

            var administrator = db.Administrators.FirstOrDefault(x => x.KorisnickiNalogId == korisnickiNalog.KorisnickiNalogId);
            if (administrator == null) return NotFound();


            return Ok(administrator);
        }

        [HttpPost]
        public IHttpActionResult PostAdministrator(Administrator a)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                a.AdministratorId = db.tsp_Administrator_Insert(a.Ime, a.Prezime, a.DatumDodavanja, a.Email, a.Telefon, a.KoriniskoIme, a.LozinkaHash, a.LozinkaSalt);
            }
            catch (EntityException ex)
            {
                SqlException greska = ex.InnerException.InnerException as SqlException;
                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }


            return CreatedAtRoute("DefaultApi", new { id = a.AdministratorId }, a);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Administrator_SelectOne a)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != a.AdministratorId)
                return BadRequest();

            try
            {
                db.tsp_Administrator_Update(a.AdministratorId, a.Ime, a.Prezime, a.Email, a.Telefon, a.KorisnickoIme, a.LozinkaHash, a.LozinkaSalt);
            }
            catch (EntityCommandExecutionException ex)
            {
                var nesto = ex.GetType().ToString();
                SqlException greska = ex.InnerException as SqlException;
                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }
            }
           


            return StatusCode(HttpStatusCode.NoContent);
        }

       
    }
}
