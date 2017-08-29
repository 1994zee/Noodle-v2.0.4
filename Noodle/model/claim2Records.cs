using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model
{
    class claim2Records
    {
        public string ClientID { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
        public string DBA { get; set; }
        public string Product { get; set; }
        public string PricinyBatchName { get; set; }
        public string SurchargeType { get; set; }
        public string SurchaseDescription { get; set; }
        public string BillRates { get; set; }
        public claim2Records(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            ClientID = a;
            Status = b;
            CompanyName = c;
            DBA = d;
            Product = e;
            PricinyBatchName = f;
            SurchargeType = g;
            SurchaseDescription = h;
            BillRates = i;
        }
    }
}
