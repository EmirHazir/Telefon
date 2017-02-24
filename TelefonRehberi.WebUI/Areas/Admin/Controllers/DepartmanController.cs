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
    [Authorize(Roles = "Admin")]
    public class DepartmanController : Controller
    {
        private IDepartmanService _departmanService;
        private IEmployeeService _employeeService;
        public DepartmanController(IDepartmanService depService, IEmployeeService empServie)
        {
            _employeeService = empServie;
            _departmanService = depService;
        }

        // GET: Admin/Departman
        public ActionResult Index()
        {
            var model = new DepartmanListVM
            {
                Departmans = _departmanService.GetAll()
            };
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new DepartmanAddVM
            {
                Departmanlar = new Departman(),
                Employees = _employeeService.GetAll()

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Departman departman)
        {
            if (ModelState.IsValid)
            {
                _departmanService.Add(departman);
            }
            return RedirectToAction("Create");
        }

        public ActionResult Update(int departmanId)
        {
            var model = new DepartmanUpdateVM
            {
                Departmanlar = _departmanService.GetById(departmanId),
                Employees = _employeeService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Departman departman)
        {
            if (ModelState.IsValid)
            {
                _departmanService.Update(departman);

            }
            return RedirectToAction("Update");
        }


        public ActionResult Delete(int departmanId)
        {
            var model = new DepartmanDeleteVM
            {
                Departmans = _departmanService.GetById(departmanId)
            };
            return View(model);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int departmanId)
        {
            if (ModelState.IsValid)
            {
                _departmanService.Delete(departmanId);
            }
            return RedirectToAction("Index");
        }
    }
}