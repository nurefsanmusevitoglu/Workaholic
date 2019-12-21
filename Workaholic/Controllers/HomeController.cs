using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Workaholic.Models;

namespace Workaholic.Controllers
{
    public class HomeController : Controller
    {
        private WContext db = new WContext();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(User user)
        {
            User u = db.Users.FirstOrDefault(i => i.Email == user.Email);

            if (u == null || u.Password != user.Password) 
            {
                if (u == null && user.Email != null) { ViewBag.UserDoesNotExistMessage = "This email address is not registered yet!"; }
                if (user.Password != null && u != null && u.Password != user.Password) { ViewBag.PasswordNotCorrectMessage = "Password is not correct!"; }
                return View(u);
            }
            else
            {
                FormsAuthentication.SetAuthCookie(u.Email, false);
                return RedirectToAction("Index");
            }
        }

        public ActionResult LogOut() 
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUpEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpEmployee(Employee e, string Repassword)
        {
            if (ModelState.IsValid && db.Users.FirstOrDefault(i => i.Email == e.Email) == null && e.Password == Repassword)
            {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("LogIn");
            }
            if (e.Password != null && e.Password != Repassword) { ViewBag.PasswordsDoNotMatchMessage = "Passwords do not match!"; }
            if (db.Users.FirstOrDefault(i => i.Email == e.Email) != null) { ViewBag.UserExistMessage = "This email address is already registered!"; }
            return View(e);
        }

        [HttpGet]
        public ActionResult SignUpEmployer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpEmployer(Employer e, string Repassword)
        {
            if (ModelState.IsValid && db.Users.FirstOrDefault(i => i.Email == e.Email) == null && e.Password == Repassword)
            {
                db.Employers.Add(e);
                db.SaveChanges();
                return RedirectToAction("LogIn");
            }
            if (e.Password != null && e.Password != Repassword) { ViewBag.PasswordsDoNotMatchMessage = "Passwords do not match!"; }
            if (db.Users.FirstOrDefault(i => i.Email == e.Email) != null) { ViewBag.UserExistMessage = "This email address is already registered!"; }
            return View(e);
        }

        //**********************************************************************************************************************************************

        public ActionResult GetAppliedJobs() 
        {
            var user = db.Employees.Include("AppliedJobs").FirstOrDefault(i => i.Email == User.Identity.Name);
            return View(user.AppliedJobs.ToList());
        }

        public ActionResult Schedule()
        {
            return View();
        }
    }
}