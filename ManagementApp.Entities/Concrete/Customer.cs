using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Entities.Concrete
{
    public class Customer : Person
    {
        public string CustomerNumber { get; set; }
        public string Adress { get; set; }
        public string MembershipLevel { get; set; }
    }
}
