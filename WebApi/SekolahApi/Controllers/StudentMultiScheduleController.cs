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
    public class StudentMultiScheduleController : ApiController
    {
        private db_sekolahEntities db = new db_sekolahEntities();

        // GET: api/StudentMultiSchedule
        public IQueryable<student_multi_schedule> Getstudent_multi_schedule()
        {
            return db.student_multi_schedule;
        }

        // GET: api/StudentMultiSchedule/5
        [ResponseType(typeof(student_multi_schedule))]
        public IHttpActionResult Getstudent_multi_schedule(int id)
        {
            student_multi_schedule student_multi_schedule = db.student_multi_schedule.Find(id);
            if (student_multi_schedule == null)
            {
                return NotFound();
            }

            return Ok(student_multi_schedule);
        }

        // PUT: api/StudentMultiSchedule/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putstudent_multi_schedule(int id, student_multi_schedule student_multi_schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student_multi_schedule.id)
            {
                return BadRequest();
            }

            db.Entry(student_multi_schedule).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!student_multi_scheduleExists(id))
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

        // POST: api/StudentMultiSchedule
        [ResponseType(typeof(student_multi_schedule))]
        public IHttpActionResult Poststudent_multi_schedule(student_multi_schedule student_multi_schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.student_multi_schedule.Add(student_multi_schedule);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student_multi_schedule.id }, student_multi_schedule);
        }

        // DELETE: api/StudentMultiSchedule/5
        [ResponseType(typeof(student_multi_schedule))]
        public IHttpActionResult Deletestudent_multi_schedule(int id)
        {
            student_multi_schedule student_multi_schedule = db.student_multi_schedule.Find(id);
            if (student_multi_schedule == null)
            {
                return NotFound();
            }

            db.student_multi_schedule.Remove(student_multi_schedule);
            db.SaveChanges();

            return Ok(student_multi_schedule);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool student_multi_scheduleExists(int id)
        {
            return db.student_multi_schedule.Count(e => e.id == id) > 0;
        }
    }
}