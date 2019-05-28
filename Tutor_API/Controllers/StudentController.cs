using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tutor_API.Models;

using Tutor_API.Util;

namespace Tutor_API.Controllers
{
    public class StudentController : ApiController
    {
        private TutorEntities db = new TutorEntities();

        // GET: api/Student
        public IQueryable<Student> GetStudents()
        {
            return db.Students;
        }

        // GET: api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpGet]
        [Route("api/Student/BanStudents")]
        public List<Student_BanStudents_Result> BanStudents()
        {
            return db.tsp_Student_SelectBanStudents().ToList();
        }

        [HttpGet]
        [Route("api/Student/LoginCheck/{username}/{password}")]
        [ResponseType(typeof(Student))]
        public IHttpActionResult LoginCheck(string username, string password)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var korisnickiNalog = db.KorisnickiNalogs.FirstOrDefault(x => x.KorisnickoIme == username);
            if (korisnickiNalog == null) return NotFound();

            var passwordHash = PasswordCheck.GenerateHash(korisnickiNalog.LozinkaSalt, password);
            if (passwordHash != korisnickiNalog.LozinkaHash) return NotFound();

            var student = db.Students.FirstOrDefault(x => x.KorisnickiNalogId == korisnickiNalog.KorisnickiNalogId);
            if (student == null) return NotFound();


            return Ok(student);
        }

        [HttpGet]
        [Route("api/Student/SearchStudent/{searchName?}/{GradId?}")]        
        public List<Student_SearchSelect_Result> SearchStudent(string searchName = "", int GradId=0)
        {
            if (searchName == "Empty") searchName = null;
            if (GradId == 0)
                return db.tsp_Student_SearchSelect(searchName, null).ToList();
                
            return db.tsp_Student_SearchSelect(searchName, GradId).ToList();
        }

        [HttpGet]
        [Route("api/Student/StudentDetails/{id?}")]
        [ResponseType(typeof(Student_Details_Result))]
        public IHttpActionResult StudentDetails(int id)
        {

            //promjeni ime
            var student = db.tsp_Student_Details(id).FirstOrDefault();

            if (student == null) return NotFound();

            return Ok(student);
        }


        [HttpGet]
        [Route("api/Student/PohadjeniPredmeti/{id?}")]
        [ResponseType(typeof(List<Student_PohadajniPredmeti_Result>))]
        public IHttpActionResult PohadjeniPredmeti(int id)
        {

            //promjeni ime
            var student = db.Students.Find(id);

            if (student == null) return NotFound();

            return Ok(db.tsp_Student_PohadajniPredmeti(id).ToList());
        }

        [HttpGet]
        [Route("api/Student/PohadjaneUcionice/{id?}")]
        [ResponseType(typeof(List<Student_SelectUcionice_Result>))]
        public IHttpActionResult PohadjaneUcionice(int id) {

            var student = db.Students.Find(id);

            if (student == null) return NotFound();


            return Ok(db.tsp_Student_SelectUcionice(id).ToList());
        }

        [HttpGet]
        [Route("api/Student/AllPrijave/{studentId}")]
        [ResponseType(typeof(List<Prijava>))]
        public IHttpActionResult AllPrijave(int studentId)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var student = db.Students.Find(studentId);

            if (student == null) return NotFound();

            var prijava = from u in db.Prijavas
                          where  u.StudentId == studentId
                          select u;
            

            return Ok(prijava.ToList());
        }
        // PUT: api/Student/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            db.Entry(student).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Student
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
       
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int id = 0;
           
                KorisnickiNalog kNalog = new KorisnickiNalog()
                {
                    KorisnickoIme = student.KorisnickoIme,
                    LozinkaSalt = student.LozinkaSalt,
                    LozinkaHash = student.LozinkaHash
                };
                db.KorisnickiNalogs.Add(kNalog);
            try { db.SaveChanges(); }
            catch (DbUpdateException ex)
            {
                SqlException greska = ex.InnerException.InnerException as SqlException;

                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }


            }

            KontaktInfo kontak = new KontaktInfo()
                {
                    Email = student.Email,
                    Telefon = student.Telefon,
                    Adresa = student.Adresa
                };
                db.KontaktInfoes.Add(kontak);
            try { db.SaveChanges(); }
            catch (DbUpdateException ex)
            {
                db.KorisnickiNalogs.Remove(kNalog);
                SqlException greska = ex.InnerException.InnerException as SqlException;
                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }

            }
            Image myImage = Properties.Resources.StudentIcon;
                MemoryStream ms = new MemoryStream();
                myImage.Save(ms, ImageFormat.Jpeg);

                Student novistudent = new Student
                {
                    Ime = student.Ime,
                    Prezime = student.Prezime,
                    DatumDodavanja = student.DatumDodavanja,
                    DatumRodjenja = student.DatumRodjenja,
                    GradId = student.GradId,
                    TipoviStudentaId = student.TipoviStudentaId,
                    KorisnickiNalogId = db.KorisnickiNalogs.First(x => x.KorisnickoIme == student.KorisnickoIme).KorisnickiNalogId,
                    KontaktInfoId = db.KontaktInfoes.First(x => x.Email == student.Email).KontaktInfoId,
                    StudentskaSlika = ms.ToArray(),
                    NazivUstanove = "",
                    SpolId = student.SpolId,
                    StatusKorisnickoRacunaId = 1

                };

                db.Students.Add(novistudent);
                id = novistudent.StudentId;
            try { db.SaveChanges(); }
            catch (DbUpdateException ex)
            {
                db.KorisnickiNalogs.Remove(kNalog);
                db.KontaktInfoes.Remove(kontak);
                SqlException greska = ex.InnerException.InnerException as SqlException;
                if (greska != null)
                {
                    return BadRequest(Util.ExceptionHandler.DbUpdateExceptionHandler(greska));
                }

            }          

                return CreatedAtRoute("DefaultApi", new { id = id }, student);
            }

        // DELETE: api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Students.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.StudentId == id) > 0;
        }
    }
}