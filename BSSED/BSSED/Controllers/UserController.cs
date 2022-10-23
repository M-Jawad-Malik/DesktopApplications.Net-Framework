using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BSSED.Models;
namespace BSSED.Controllers
{
    public class UserController : Controller
    {
        BSSEDEntities db = new BSSEDEntities();
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User objUser)
        {
            if (ModelState.IsValid)
            {
                var obj = db.Users.Where(a =>a.Email.Equals(objUser.Email)&& a.Password.Equals(objUser.Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["UserEmail"] = obj.Email.ToString();
                    Session["UserName"] = obj.Name.ToString();
                    return RedirectToAction("Dashborad", "admin");
                }
                else
                {
                    TempData["Msg"] = "Invalid Email and Password!";
                    return RedirectToAction("Login","User");
                }
            }
            return View(objUser);
        }

        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(User Userdata)
        {
            Userdata.RoleId = 3;
            db.Users.Add(Userdata);
            db.SaveChanges();
            TempData["Msg"] = "Congratulations you have successfully registered!";
            return RedirectToAction("Login", "User");
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Login", "User");
        }

    }
}