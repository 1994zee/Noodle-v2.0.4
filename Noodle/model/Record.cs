using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model
{
    class Record
    {
        public string CsClaimNumber { get; set; }
        public string CarrierClaimNumber { get; set; }
        public string BillDate { get; set; }
        public string BillEventCode { get; set; }
        public string BillUnits { get; set; }
        public string ClientID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeNameComment { get; set; }
        public string InjuredEmployee { get; set; }
        public string Location { get; set; }
        public string CompanyName { get; set; }

        public Record(string a, string i, string b, string c, string d, string e, string f, string g, string h, string j,string k)
        {
            this.CsClaimNumber = a;
            this.CarrierClaimNumber = i;
            this.BillDate = b;
            this.BillEventCode = c;
            this.BillUnits = d;
            this.ClientID = e;
            this.EmployeeID = f;
            this.EmployeeNameComment = g;
            this.InjuredEmployee = "Injured employee:" + h;
            this.Location = j;
            this.CompanyName = k;
        }
        public void print()
        {
            Console.WriteLine(CsClaimNumber + "\t" + CarrierClaimNumber + "\t" + BillDate + "\t" + BillEventCode + "\t" + BillUnits + "\t" + ClientID + "\t" + EmployeeID + "\t" + EmployeeNameComment + "\t" + InjuredEmployee + "\t" + Location);
        }
    }
}
