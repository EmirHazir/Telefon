using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using TelefonRehberi.DataAccess.Concrete;
using TelefonRehberi.Entities.Concrete;
using TelefonRehberi.WebUI.Models;

namespace TelefonRehberi.WebUI.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;
        // GET: Admin/Home
        public AccountController()
        {
            TelefonDBContext db = new TelefonDBContext();
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(db);
            userManager = new UserManager<ApplicationUser>(userStore);
            RoleStore<ApplicationRole> roleStore = new RoleStore<ApplicationRole>(db);
            roleManager = new RoleManager<ApplicationRole>(roleStore);
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Adi = model.Adi;
                user.Soyadi = model.Soyadi;
                user.Telefon = model.Telefon;
                user.UserName = model.Adi;

                IdentityResult result = userManager.Create(user, model.Sifre);

                if (result.Succeeded)
                {
                    //Admincontrollerdaki tüm viewlar[Authorize(Roles = "User")] durumda isterseniz buradan ya dda db den değiştirip Admin yapabilirsiniz.Ben register için ilk başta herkesi User tanımlıyorum
                    userManager.AddToRole(user.Id, "User");
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUser", "Kullanıcı ekleme işleminde hata!");
                }

            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model)
        {
            ApplicationUser user = userManager.Find(model.Adi, model.Sifre);
            if (ModelState.IsValid)
            {
                if (user!=null)
                {
                    IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
                    ClaimsIdentity identity = userManager.CreateIdentity(user, "ApplicationCookie");
                    AuthenticationProperties authProps = new AuthenticationProperties();
                    authProps.IsPersistent = model.BeniHatirla;
                    authManager.SignIn(authProps, identity);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUser", "Böyle bir kullanıcı bulunamadı");
                }

            }
            return View(model);
        }

        [Authorize]
        public ActionResult Logout()
        {
            IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Login","Account");
        }

    }
}