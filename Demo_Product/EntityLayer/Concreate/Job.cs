﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Job
    {
        public int JobID { get; set; }
        public string Name { get; set; }
        public int City { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
