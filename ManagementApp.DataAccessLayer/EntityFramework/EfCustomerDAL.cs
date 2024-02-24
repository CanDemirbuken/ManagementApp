using ManagementApp.DataAccessLayer.Abstract;
using ManagementApp.DataAccessLayer.Concrete;
using ManagementApp.DataAccessLayer.Repository;
using ManagementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.DataAccessLayer.EntityFramework
{
    public class EfCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
    }
}
