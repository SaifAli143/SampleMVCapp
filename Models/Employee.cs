﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCapp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public string Department { get; set; }
        public double Salary { get; set; }
    }
}