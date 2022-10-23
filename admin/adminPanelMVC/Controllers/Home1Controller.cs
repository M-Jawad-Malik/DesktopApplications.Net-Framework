using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using adminPanelMVC.Models;
namespace adminPanelMVC.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Userlogin obj)

         {  
            if (ModelState.IsValid) {  

                webQuizEntities4 db = new webQuizEntities4();  
               db.Userlogins.Add(obj);  
                 db.SaveChanges();  
            }  
             return View(obj);  
         }
    }
}