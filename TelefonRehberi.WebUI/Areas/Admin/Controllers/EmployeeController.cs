using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.Service.Abstracts;
using TelefonRehberi.WebUI.Areas.Admin.Models;

namespace TelefonRehberi.WebUI.Areas.Admin.Controllers
{
    [Authorize(Users = "Admin")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private IDepartmanService _departmanService;
        public EmployeeController(IEmployeeService employeeService, IDepartmanService departmanService)
        {
            _departmanService = departmanService;
            _employeeService = employeeService;
        }

        // GET: Admin/Employee/Index
        public ActionResult Index()
        {
            var employeeList = new EmployeeeListVM
            {
                Employees = _employeeService.GetAll().ToList()
            };

            return View(employeeList);
        }
        // GET: Admin/Employee/Create
        public ActionResult Create()
        {
            var model = new EmployeeAddVM
            {
                Employees = new Employee(),
                Departmans = _departmanService.GetAll()
            };

            return View(model);
        }
        // POST: Admin/Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(employee);
            }
            return RedirectToAction("Create");
        }
        // GET: Admin/Employee/Update
        public ActionResult Update(int employeeId)
        {
            var model = new EmployeeUpdateVM
            {
                Employees = _employeeService.GetById(employeeId),
                Departmans = _departmanService.GetAll()
            };
            return View(model);
        }
        // POST: Admin/Employee/Update
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(employee);
            }

            return RedirectToAction("Update");
        }

        // GET: Admin/Employee/Delete
        public ActionResult Delete(int employeeId)
        {
            var model = new EmployeeDeleteVM
           {
             Employes =  _employeeService.GetById(employeeId),
             Departmans = _departmanService.GetAll()
            };  
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int employeeId)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Delete(employeeId);
            }

            return RedirectToAction("Index");
        }

    }
}