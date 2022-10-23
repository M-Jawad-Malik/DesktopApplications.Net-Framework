using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginRegMVC.Models;
namespace LoginRegMVC.Controllers
{
    public class HomeController : Controller
    {
        BSSEDEntities db = new BSSEDEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User objUser)
        {
            if (ModelState.IsValid)
            {
                var obj = db.Users.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["UserEmail"] = obj.Email.ToString();
                    Session["UserName"] = obj.Name.ToString();
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    TempData["Msg"] = "Invalid Email and Password!";
                    return RedirectToAction("Login", "Home");
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
            return RedirectToAction("Login", "Home");
        }
        public ActionResult Dashboard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,Name,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("CategoryList");
            }

            return View(category);
        }
        public ActionResult CategoryList()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,Name,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CategoryList");
            }
            return View(category);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }







    }
}