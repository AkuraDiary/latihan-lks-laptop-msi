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
    public class HeaderScheduleController : ApiController
    {
        private db_sekolahEntities db = new db_sekolahEntities();

        // GET: api/HeaderSchedule
        public IQueryable<header_schedule> Getheader_schedule()
        {
            return db.header_schedule;
        }

        // GET: api/HeaderSchedule/5
        [ResponseType(typeof(header_schedule))]
        public IHttpActionResult Getheader_schedule(int id)
        {
            header_schedule header_schedule = db.header_schedule.Find(id);
            if (header_schedule == null)
            {
                return NotFound();
            }

            return Ok(header_schedule);
        }

        // PUT: api/HeaderSchedule/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putheader_schedule(int id, header_schedule header_schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != header_schedule.schedule_id)
            {
                return BadRequest();
            }

            db.Entry(header_schedule).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!header_scheduleExists(id))
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

        // POST: api/HeaderSchedule
        [ResponseType(typeof(header_schedule))]
        public IHttpActionResult Postheader_schedule(header_schedule header_schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.header_schedule.Add(header_schedule);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = header_schedule.schedule_id }, header_schedule);
        }

        // DELETE: api/HeaderSchedule/5
        [ResponseType(typeof(header_schedule))]
        public IHttpActionResult Deleteheader_schedule(int id)
        {
            header_schedule header_schedule = db.header_schedule.Find(id);
            if (header_schedule == null)
            {
                return NotFound();
            }

            db.header_schedule.Remove(header_schedule);
            db.SaveChanges();

            return Ok(header_schedule);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool header_scheduleExists(int id)
        {
            return db.header_schedule.Count(e => e.schedule_id == id) > 0;
        }
    }
}