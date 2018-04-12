using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBASIC.Models
{
    public class StudentDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string States { get; set; }
        public string Gender { get; set; }
        public bool Student { get; set; }
        public bool working { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public int Age { get; set; }
    }
}