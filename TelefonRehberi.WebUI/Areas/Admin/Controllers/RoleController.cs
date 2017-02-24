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
    public class RoleController : Controller
    {
        private IRoleService _roleService;
        private IEmployeeService _employeeService;
        public RoleController(IRoleService roleService, IEmployeeService empService)
        {
            _employeeService = empService;
            _roleService = roleService;
        }


        // GET: Admin/Account
        public ActionResult Index()
        {
            RoleVM model = new RoleVM
            {
                Roles = _roleService.GetAll().ToList()
            };
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new RoleAddVM
            {
                Roles = new Role(),
                Employees = _employeeService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Role role)
        {
            if (ModelState.IsValid)
            {
                _roleService.Add(role);
            }

            return RedirectToAction("Create");
        }


        public ActionResult Update(int roleId)
        {
            var model = new RoleUpdateVM
            {
                Roles = _roleService.GetById(roleId),
                Employees = _employeeService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Role role)
        {
            if (ModelState.IsValid)
            {
                _roleService.Update(role);
            }
            return RedirectToAction("Update");
        }

        public ActionResult Delete(int roleId)
        {
            var model = new RoleDeleteVM
            {
                Roles = _roleService.GetById(roleId),
                Employees = _employeeService.GetAll()
            };
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int roleId)
        {
            if (ModelState.IsValid)
            {
                _roleService.Delete(roleId);
            }
            return RedirectToAction("Index");
        }



    }
}