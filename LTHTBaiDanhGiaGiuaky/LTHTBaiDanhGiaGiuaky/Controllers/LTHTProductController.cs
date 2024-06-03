using LTHTBaiDanhGiaGiuaky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTHTBaiDanhGiaGiuaky.Controllers
{
    public class LTHTProductController : Controller
    {
        private static List<LTHTProduct> LTHTProducts = new List<LTHTProduct>()

        {
            new LTHTProduct{ID = 221090036,thuFullName="Lê thương hoài thu", thuImage="anh",thuQuantity=20,thuPrice =150000, thuisActive=29},
            new LTHTProduct{ID = 221090037,thuFullName="minh minh", thuImage="anh",thuQuantity=89,thuPrice =20000,thuisActive='9'},

        };
        // GET: LTHT


        public ActionResult Index()
        {
            return View(LTHTProducts);
        }
        public ActionResult LTHTCreate()
        {
            var LTHTProduct = new LTHTProduct();
            return View(LTHTProduct);
        }
        // GET: LTHT
        [HttpPost]
        public ActionResult LTHTCreate(LTHTProduct LTHTProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(LTHTProduct);
            }
            //nếu dữ liệu đúng thì lưu vào danh sách
            LTHTProducts.Add(LTHTProduct);
            return RedirectToAction("Index");
        }
        
    }
}