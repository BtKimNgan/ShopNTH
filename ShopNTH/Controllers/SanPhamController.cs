using ShopNTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopNTH.Controllers
{
    public class SanPhamController : Controller
    {
        
        // GET: SanPham
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult ListSanPham()
        {
            var all_SanPham = from ss in data.SanPhams select ss;
            return View(all_SanPham);
        }
    }
}