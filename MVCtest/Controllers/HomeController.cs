using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            var physicalFilePath = Server.MapPath("~/Content/Images/untitled.jpg");

            return base.File(physicalFilePath, "image/jpeg");
        }

        public ActionResult Download2()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\Szymon\Documents\GitHub\AJAX\MVCtest\MVCtest\Content\Files\newsletter_01.01.17.docx");
            string fileName = "newsletter_01.01.17.docx";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult Download3()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\Szymon\Documents\GitHub\AJAX\MVCtest\MVCtest\Content\Images\untitled.jpg");
            string fileName = "untitled.png";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}