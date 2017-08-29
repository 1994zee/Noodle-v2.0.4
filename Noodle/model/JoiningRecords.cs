using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model
{
    class JoiningRecords
    {
        public Record WC1record { get; set; }
        public claim2Records WC2record { get; set; }
        public JoiningRecords(Record r, claim2Records q)
        {
            this.WC1record = r;
            this.WC2record = q;
        }
    }
}
