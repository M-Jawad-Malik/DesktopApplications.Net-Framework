using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deServico.Controllers
{
    public class chatController : Controller
    {
        // GET: chat
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

    }
}