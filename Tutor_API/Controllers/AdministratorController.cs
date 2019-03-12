using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;

namespace Tutor_API.Controllers
{
    public class AdministratorController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        [HttpGet]
        [ResponseType(typeof(List<Administrator_SelectAll>))]
        public List<Administrator_SelectAll> GetAdministrator() {

            return db.tsp_Administrator_SelectAll().ToList();
        }

        [HttpGet]
        public IHttpActionResult GetAdministrator(int id)
        {
            Administrator_SelectOne admin = db.tsp_Administrator_SelectOne(id).FirstOrDefault();
            if (admin==null)
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

        [HttpPost]
        public IHttpActionResult PostAdministrator(Administrator a) {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
           a.AdministratorId =db.tsp_Administrator_Insert(a.Ime, a.Prezime, a.DatumDodavanja, a.Email, a.Telefon, a.KoriniskoIme, a.LozinkaHash, a.LozinkaSalt);

            return CreatedAtRoute("DefaultApi", new { id = a.AdministratorId }, a);
        }
    }
}
