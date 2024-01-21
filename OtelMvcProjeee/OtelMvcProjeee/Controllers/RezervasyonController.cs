using OtelMvcProjeee.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OtelMvcProjeee.Controllers
{
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblOnRezervasyon t)
        {

            var misafirmail = (string)Session["Mail"];
            //var misafirid = db.TblYeniKayit.Where(x => x.Mail == misafirmail).Select(x=>x.Id).FirstOrDefault();
            

          //  p.Durum = 1023;
           // p.Misafir = misafirid;
           t.Mail = misafirmail;
           t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOnRezervasyon.Add(t);
            db.SaveChanges();
            return RedirectToAction("Rezervasyonlarim","Misafir");

        }
    }
}