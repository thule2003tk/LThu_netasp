using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thulesson08CF.Models;

namespace Thulesson08CF.Controllers
{
    public class ThuCategoryController : Controller
    {
        private static ThuBookStore _ThuBookStore;
        public ThuCategoryController()
        {
            _ThuBookStore = new ThuBookStore();
        }
        // GET: ThuCategory
        public ActionResult Index()
        {
            var ThuCategory=_ThuBookStore.ThuCategories.ToList();
            return View(ThuCategory);
        }
        [HttpGet]
        public ActionResult ThuCreate() {
            var ThuCcategory=new ThuCategory();
            return View(ThuCcategory);
        }
        public ActionResult ThuCreate(ThuCategory thuCategory) {
            _ThuBookStore.ThuCategories.Add(thuCategory);
            _ThuBookStore.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}