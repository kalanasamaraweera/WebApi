using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ASPApi
{
    public class StudentBasicDetails
    {
        [Key]
        public int stuID { get; set; }
        public string stuName { get; set; }
        public int stuAge { get; set; }

    }

}