using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceLevel { get; set; }
        public Priority Priority { get; set; }
        public string Executor { get; set; }
        public string Availability { get; set; }
        public string Theme { get; set; }
    }
}
