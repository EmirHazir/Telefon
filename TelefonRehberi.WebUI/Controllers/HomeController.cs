using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.Service.Abstracts;
using TelefonRehberi.WebUI.Models;

namespace TelefonRehberi.WebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        private IEmployeeService _employeeService;

        public HomeController(IEmployeeService empService)
        {
            _employeeService = empService;
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
    }
}