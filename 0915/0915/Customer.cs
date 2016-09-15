using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0915
{
    class Customer
    {
        public string fname { get; set; }
        public string lname { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", fname, lname);
            }

        }
    }
}
