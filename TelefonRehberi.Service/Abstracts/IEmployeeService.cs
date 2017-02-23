using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Service.Abstracts
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        List<Employee> GetByEmployee(int employeeId);

        void Add(Employee employee);

        void Update(Employee employee);

        void Delete(int employeeId);

        Employee GetById(int employeeId);

    }
}
