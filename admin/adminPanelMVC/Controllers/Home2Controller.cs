using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using adminPanelMVC.Models;
namespace adminPanelMVC.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(UserProfile objUser)
        {
            if (ModelState.IsValid)
            {
                using (webQuizEntities5 db = new webQuizEntities5())
                {
                    var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName)&& a.Password.Equals(objUser.Password )).FirstOrDefault();
                    if (obj != null)
                    {

                        Session["UserId"] = obj.UserId.ToString();
                        Session["UserName"] = obj.UserName.ToString();
                        return RedirectToAction("UserDashBoard");

                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserId"] != null)  
             {
                return View();
            } else
            {
                return RedirectToAction("Login");
            }
        }
    }
}