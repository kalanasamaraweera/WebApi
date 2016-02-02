using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPApi
{
    public class StudentBasicDetails:DbContext
    {
        public DbSet<studentTable> StudentDetails { get; set; }

    }
    public class studentTable
    {
        public int stuID { get; set; }
        public string stuName { get; set; }
        public int stuAge { get; set; }
    }
}