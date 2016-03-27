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
using ASPApi;
using ASPApi.Models;

namespace ASPApi.Controllers
{
    public class StudentBasicDetailsController : ApiController
    {
        private DBStudent db = new DBStudent();

        // GET: api/StudentBasicDetails
        public IQueryable<StudentBasicDetails> GetstuBasDet()
        {
            return db.stuBasDet;
        }

        // GET: api/StudentBasicDetails/5
        [ResponseType(typeof(StudentBasicDetails))]
        public IHttpActionResult GetStudentBasicDetails(int id)
        {
            StudentBasicDetails studentBasicDetails = db.stuBasDet.Find(id);
            if (studentBasicDetails == null)
            {
                return NotFound();
            }

            return Ok(studentBasicDetails);
        }

        // PUT: api/StudentBasicDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentBasicDetails(int id, StudentBasicDetails studentBasicDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentBasicDetails.stuID)
            {
                return BadRequest();
            }

            db.Entry(studentBasicDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentBasicDetailsExists(id))
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

        // POST: api/StudentBasicDetails
        [ResponseType(typeof(StudentBasicDetails))]
        public IHttpActionResult PostStudentBasicDetails(StudentBasicDetails studentBasicDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.stuBasDet.Add(studentBasicDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = studentBasicDetails.stuID }, studentBasicDetails);
        }

        // DELETE: api/StudentBasicDetails/5
        [ResponseType(typeof(StudentBasicDetails))]
        public IHttpActionResult DeleteStudentBasicDetails(int id)
        {
            StudentBasicDetails studentBasicDetails = db.stuBasDet.Find(id);
            if (studentBasicDetails == null)
            {
                return NotFound();
            }

            db.stuBasDet.Remove(studentBasicDetails);
            db.SaveChanges();

            return Ok(studentBasicDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentBasicDetailsExists(int id)
        {
            return db.stuBasDet.Count(e => e.stuID == id) > 0;
        }
    }
}