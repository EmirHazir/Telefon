using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelefonRehberi.Service.Abstracts;
using TelefonRehberi.WebUI.Models;

namespace TelefonRehberi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeService _employeeService;
        private IDepartmanService _departmanService;
        private IRoleService _roleService;
        public HomeController(IEmployeeService empService, IDepartmanService depService,IRoleService roleService)
        {
            _departmanService = depService;
            _employeeService = empService;
            _roleService = roleService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var model = new EmployeListViewModel
            {
                Employees = _employeeService.GetAll()
            };

            return View(model);
        }


        public ActionResult Details(int employeId)
        {
            var model = new EmployeeDetailsViewModel
            {
                Employees = _employeeService.GetById(employeId),
                Departmans = _departmanService.GetAll(),
                Roles = _roleService.GetAll()
            };
            return View(model);
        }
    }
}