using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0920
{
    class Supplier
    {
        public string Contact { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", Contact, Company);
            }

        }
    }
}
