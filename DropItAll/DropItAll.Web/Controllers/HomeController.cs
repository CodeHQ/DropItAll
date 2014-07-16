using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropItAll.Web.Controllers
{
    public class HomeController : Controller
    {
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

        [HttpPost]
        public string Upload()
        {
            HttpPostedFileBase FileData = Request.Files[0];

            if (FileData.ContentLength > 0)
            {
                var fileName = Path.GetFileName(FileData.FileName);
                var path = Path.Combine(Server.MapPath("~/Content"), fileName);
                FileData.SaveAs(path);
            }

            return "Files was uploaded successfully!";
        }
    }
}