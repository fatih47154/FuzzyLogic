using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuzzyLogic.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult index1(double x, double y)
        {
            islem nesne = new islem();
            try
            {

                int k, l;
                k = nesne.hesapla(x);
                l = nesne.hesapla2(y);

                nesne.yukle();
                nesne.cikarim(k, l);
                double sonuc = nesne.durulastirma(k, l);
                if (sonuc == 404)
                {
                    TempData["Hata"] = "Çıkışta Hareket Yok";
                }
                else
                {
                    TempData["Hata"] = sonuc;
                }

            }
            catch
            {
                TempData["Hata"] = "Kriterlere uygun değerler giriniz";
            }

            return RedirectToAction("Index");
        }
    }
}