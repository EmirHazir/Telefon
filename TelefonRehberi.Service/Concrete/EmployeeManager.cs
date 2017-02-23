using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.DataAccess.Abstracts;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.Service.Abstracts;

namespace TelefonRehberi.Service.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }


        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(int employeeId)
        {
            _employeeDal.Delete(new Employee { Id = employeeId });
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<Employee> GetByEmployee(int employeeId)
        {
            return _employeeDal.GetList(x => x.Id == employeeId);
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.Get(x => x.Id == employeeId);
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
