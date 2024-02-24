using ManagementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.DataAccessLayer.Abstract
{
    public interface IEmployeeDAL : IGenericDAL<Employee>
    {
    }
}
