using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Entities.Concrete
{
    public class Employee : Person
    {
        public string Title { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
