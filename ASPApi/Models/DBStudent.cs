using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPApi.Models
{
    public class DBStudent:DbContext
    {

        public DbSet<StudentBasicDetails> stuBasDet { get; set; }
    }
}