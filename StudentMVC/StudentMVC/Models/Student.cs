﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMVC.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String Branch { get; set; }
        public String Section { get; set; }
    }

}