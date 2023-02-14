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
using SekolahApi.Models;
using EntityState = System.Data.Entity.EntityState;

namespace SekolahApi.Controllers
{
    public class SubjectController : ApiController
    {
        private db_sekolahEntities db = new db_sekolahEntities();

        // GET: api/Subjcet
        public IQueryable<subject> Getsubjects()
        {
            return db.subjects;
        }

        // GET: api/Subjcet/5
        [ResponseType(typeof(subject))]
        public IHttpActionResult Getsubject(string id)
        {
            subject subject = db.subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }

        // PUT: api/Subjcet/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsubject(string id, subject subject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subject.subject_id)
            {
                return BadRequest();
            }

            db.Entry(subject).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!subjectExists(id))
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

        // POST: api/Subjcet
        [ResponseType(typeof(subject))]
        public IHttpActionResult Postsubject(subject subject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.subjects.Add(subject);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (subjectExists(subject.subject_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = subject.subject_id }, subject);
        }

        // DELETE: api/Subjcet/5
        [ResponseType(typeof(subject))]
        public IHttpActionResult Deletesubject(string id)
        {
            subject subject = db.subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }

            db.subjects.Remove(subject);
            db.SaveChanges();

            return Ok(subject);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool subjectExists(string id)
        {
            return db.subjects.Count(e => e.subject_id == id) > 0;
        }
    }
}