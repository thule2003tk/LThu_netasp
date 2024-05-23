using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThuLesson04.Models;

namespace ThuLesson04.Controllers
{
    public class ThucustomerscaffdingController : Controller
    {
        //mock data
        private static List<Thucustomer> listcustomer = new List<Thucustomer>()
            {
                new Thucustomer()
                {
                    CustomerId = 1,
                            FirstName = "Lê",
                            LastName = "Thu",
                            Address = "k22cnt1",
                            YearOfBirth = 2003
                        },
                new Thucustomer()
                {
                    CustomerId = 2,
                        FirstName = "Lê",
                        LastName = "Duyen",
                        Address = "k22cnt1",
                        YearOfBirth = 2001
                    },
                new Thucustomer()
                {
                    CustomerId = 3,
                        FirstName = "Lê",
                        LastName = "tham",
                        Address = "k22cnt1",
                        YearOfBirth = 1981
                    },
                new Thucustomer()
                {
                    CustomerId = 4,
                        FirstName = "Lê",
                        LastName = "viet",
                        Address = "k22cnt1",
                        YearOfBirth = 2007
                }
    };
    // GET: Thucustomerscaffding
    //listcustomer

    public ActionResult Index()
        {
            return View(listcustomer);
        }
        [HttpGet]
        public ActionResult Thucreate()
        {
            var model = new Thucustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult Thucreate(Thucustomer model)
        {
            //thêm mới đối tượng khách hàng vào danh sách dữ liệu
            listcustomer.Add(model);
           // return View(model);
           //chuyển về trang danh sách
           return RedirectToAction("Index");
        }
        public ActionResult ThuEdit(int id)
        {
            var customer = listcustomer.FirstOrDefault(x=>x.CustomerId == id);
            return View();
        }

    }
}