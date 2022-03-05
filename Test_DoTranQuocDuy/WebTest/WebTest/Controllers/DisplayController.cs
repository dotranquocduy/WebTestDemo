using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;
namespace WebTest.Controllers
{
    public class DisplayController : Controller
    {
        VNR_InternShipEntities db = new VNR_InternShipEntities();
        
        public ActionResult NoiDung(int ? index)
        {
         
            return View(db.KhoaHocs.ToList().Where(n => n.ID == index));
        }
        public ActionResult DanhSachKhoaHoc()
        {
            return PartialView(db.KhoaHocs.ToList());
        }
        public ActionResult DanhSachMonHoc(int? index)
        {
            return View(db.MonHocs.ToList().Where(n => n.KhoaHocID == index));
        }
    }
}