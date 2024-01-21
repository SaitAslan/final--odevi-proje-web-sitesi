using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProjeee.Models.Entity;


namespace OtelMvcProjeee.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
       
        DbOtelYeniEntities db =new DbOtelYeniEntities();
        public ActionResult Hakkımda()
        {
            var veriler =db.TblHakkimda.ToList();
            return View(veriler);
        }
        
        public PartialViewResult Ekibimiz()
        {
            return PartialView();
        }
        

        public PartialViewResult PartialFooter()
        {
            var doluoda=db.TblOda.Where(x=>x.Durum!=1).Count();
            ViewBag.d= doluoda;
            var bosoda = db.TblOda.Where(x => x.Durum == 1).Count();
            ViewBag.b= bosoda;
            return PartialView();
        }
        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}