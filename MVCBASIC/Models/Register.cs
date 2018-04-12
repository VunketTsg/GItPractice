﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBASIC.Models
{
    public class Register
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public bool Terms { get; set; }
    }
}