using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPApi
{
    public class StudentController : ApiController
    {
        StudentBasicDetails[] st = new StudentBasicDetails[]
        {
            new StudentBasicDetails {stuID=1,stuName="AAA",stuAge=8 },
            new StudentBasicDetails {stuID=2,stuName="BBB",stuAge=9 },
            new StudentBasicDetails {stuID=3,stuName="CCC",stuAge=8 },
            new StudentBasicDetails {stuID=4,stuName="DDD",stuAge=8 },
            new StudentBasicDetails {stuID=5,stuName="EEE",stuAge=9 },
            new StudentBasicDetails {stuID=6,stuName="FFF",stuAge=8 }
        };
        public IEnumerable<StudentBasicDetails> GetAll()
        {
            return st;
        }
        [HttpGet]
        [Route("api/Student/{id}")]
        public IHttpActionResult GetId(int id)
        {
            var studet = st.FirstOrDefault((s) => s.stuID == id);
            if (studet == null)
            {
                return NotFound();
            }
            return Json(studet);
        }
    }
}
