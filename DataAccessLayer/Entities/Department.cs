﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
        public string Head { get; set; }
    }
}
