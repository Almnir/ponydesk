using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class KnowledgeBase
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public bool HasAttachment { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
    }
}
