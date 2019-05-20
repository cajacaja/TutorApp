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
    public class NivoTezineController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/NivoTezine
        public List<NivoTezine> GetNivoTezines()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.NivoTezines.ToList();
        }

     

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}