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
using CobaWebApiApplication.Models;
using EntityState = System.Data.Entity.EntityState;

namespace CobaWebApiApplication.Controllers
{
    public class AnggotaController : ApiController
    {
        private db_first_cobaEntities db = new db_first_cobaEntities();

        // GET: api/Anggota
        public IQueryable<anggota> Getanggotas()
        {
            return db.anggotas;
        }

        // GET: api/Anggota/5
        [ResponseType(typeof(anggota))]
        public IHttpActionResult Getanggota(int id)
        {
            anggota anggota = db.anggotas.Find(id);
            if (anggota == null)
            {
                return NotFound();
            }

            return Ok(anggota);
        }

        // PUT: api/Anggota/5
        [ResponseType(typeof(string))]
        public IHttpActionResult Putanggota(int id, anggota anggota)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != anggota.id)
            {
                return BadRequest();
            }

            db.Entry(anggota).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                if (!anggotaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return InternalServerError(e);
                    throw;
                }
            }

            return Ok("data updated successfully");
        }

        // POST: api/Anggota
        [ResponseType(typeof(anggota))]
        public IHttpActionResult Postanggota(anggota anggota)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.anggotas.Add(anggota);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = anggota.id }, anggota);
        }

        // DELETE: api/Anggota/5
        [ResponseType(typeof(anggota))]
        public IHttpActionResult Deleteanggota(int id)
        {
            anggota anggota = db.anggotas.Find(id);
            if (anggota == null)
            {
                return NotFound();
            }

            db.anggotas.Remove(anggota);
            db.SaveChanges();

            return Ok("deleted");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool anggotaExists(int id)
        {
            return db.anggotas.Count(e => e.id == id) > 0;
        }
    }
}