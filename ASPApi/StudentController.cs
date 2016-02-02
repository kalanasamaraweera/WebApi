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
        studentTable[] st = new studentTable[]
        {
            new studentTable {stuID='1',stuName="AAA",stuAge='8' },
            new studentTable {stuID='2',stuName="BBB",stuAge='9' },
            new studentTable {stuID='3',stuName="CCC",stuAge='8' },
            new studentTable {stuID='4',stuName="DDD",stuAge='8' },
            new studentTable {stuID='5',stuName="EEE",stuAge='9' },
            new studentTable {stuID='6',stuName="FFF",stuAge='8' }
        };
        public IEnumerable<studentTable> GetAll()
        {
            return st;
        }
        public IHttpActionResult GetStuID(int stuid)
        {
            var studet = st.FirstOrDefault((s) => s.stuID == stuid);
            if (studet == null)
            {
                return NotFound();
            }
            return Ok(studet);
        }
    }
}
