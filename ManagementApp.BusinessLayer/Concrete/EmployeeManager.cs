using ManagementApp.BusinessLayer.Abstract;
using ManagementApp.DataAccessLayer.Abstract;
using ManagementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;

        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public void Add(Employee t)
        {
            _employeeDAL.Add(t);
        }

        public void Delete(Employee t)
        {
            _employeeDAL.Delete(t);
        }

        public List<Employee> GetAll()
        {
            return _employeeDAL.GetAll();
        }

        public Employee GetByID(int id)
        {
            return _employeeDAL.GetByID(id);
        }

        public void Update(Employee t)
        {
            _employeeDAL.Update(t);
        }
    }
}
