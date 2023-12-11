using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string Fullname { get; set; }
        public string Town { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string MainPhone { get; set; }
        public string AdditionalPhone { get; set; }
        public string MobilePhone { get; set; }
        public Company Company { get; set; }
    }
}
