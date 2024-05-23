using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thu_Lesson03.Controllers
{
    /// <summary>
    /// Author: Le Tuan Tinh
    /// Class: K22CNT1
    /// </summary>
    public class LttStudentController : Controller
    {
        // GET: LttStudent
        public ActionResult Index()
        {
            // Truyen du lieu tu Controller -> View
            ViewBag.fullName = "Le Tuan Tinh";
            ViewData["Birthday"] = "24/04/2004";
            TempData["Phone"] = "0845682356";

            return View();
        }

        public ActionResult Details() 
        {
            string lttstr = "";
            lttstr += "<h3>Ho va ten: Ltht thu</h3>";
            lttstr += "<p>Ma so: 2210900130</p>";
            lttstr += "<p>Dia chi mail:tinh2004@gmail.com</p>";

            ViewBag.Details = lttstr;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            string[] names = { "Ltht thu", "hgffjhjguf" };
            ViewBag.Names = names;
            return View();
        }

        // HTMLHelper
        // GET: thuStudent/AddStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //Lay du lieu tren form
            string fullName = form["fullName"];
            string masv = form["maSV"];
            string tk = form["TaiKhoan"];
            string mk = form["MatKhau"];

            string lttStr = "<h3>" + fullName + "</h3>";
            lttStr += "<p>" + masv;
            lttStr += "<p>" + tk;
            lttStr += "<p>" + mk;

            ViewBag.info = lttStr;
            return View("Ketqua");
        }
    }
}