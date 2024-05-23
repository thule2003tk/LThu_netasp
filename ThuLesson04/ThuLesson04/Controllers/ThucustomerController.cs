using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using ThuLesson04.Models;

namespace ThuLesson04.Controllers
{
    public class ThucustomerController : Controller
    {
        // GET: Thucustomer
        public ActionResult Index()
        {
            return View();
        }
        /// Action: Thucustomerdetail
        public ActionResult Thucustomerdetail()
        {
            //tạo đối tượng dữ liệu 
            var customer = new Thucustomer()
            {
                CustomerId = 1,
                FirstName = "Lê",
                LastName = "Thu",
                Address = "k22cnt1",
                YearOfBirth = 2003

            };
            ViewBag.Customer = customer;
            return View(); 
        }

        ///GET: Thulistcustomer
        public ActionResult Thulistcustomer()
        {
            var list= new List<Thucustomer>()
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
            ViewBag.list = list; // đưa dữ liệu ra view bằng đối tượng ViewBag
            return View();

        }

    }
}