using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelMvcProjeee.Models.Entity;

namespace OtelMvcProjeee.Controllers
{
    [Authorize]
    public class MisafirController : Controller
    {
        // GET: Misafir
        DbOtelYeniEntities db = new DbOtelYeniEntities();


        public ActionResult Index()
        {
            var misafirmail = (string)Session["Mail"];
            var misafirbilgi = db.TblYeniKayit.Where(x => x.Mail == misafirmail).FirstOrDefault();
            return View(misafirbilgi);
        }
        public ActionResult Rezervasyonlarim()
        {
            var misafirmail = (string)Session["Mail"];
            var degerler = db.TblOnRezervasyon.Where(x => x.Mail == misafirmail).ToList();
            return View(degerler);
        }
        public ActionResult MisafirBilgiGuncelle(TblYeniKayit p)

        {
            var misafir = db.TblYeniKayit.Find(p.Id);
            misafir.AdSoyad = p.AdSoyad;
            misafir.Sifre = p.Sifre;
            misafir.Telefon = p.Telefon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "AnaSayfa");
        }
        public ActionResult GelenMesajlar()
        {
            var misafirmail = (string)Session["Mail"];
            var mesajlar=db.TblMesaj2.Where(x=>x.Alici==misafirmail).ToList();
            return View(mesajlar);
        }
    }
}
