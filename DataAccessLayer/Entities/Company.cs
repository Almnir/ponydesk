using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Head { get; set; }
        public string FactAddress { get; set; }
        public string JuridicalAddress { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string OGRN { get; set; }
        public string BIK { get; set; }
        public string CorrInvoice { get; set; }
        public string Invoice { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ContactPerson { get; set; }
        public string ManagerPerson { get; set; }
        public string Region { get; set; }
    }
}
