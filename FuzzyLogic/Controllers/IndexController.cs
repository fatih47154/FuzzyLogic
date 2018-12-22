using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuzzyLogic.Models;
using Newtonsoft.Json;

namespace FuzzyLogic.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<DataPoint> dataPoints1 = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            List<DataPoint> dataPoints3 = new List<DataPoint>();
            List<DataPoint> dataPoints4 = new List<DataPoint>();
            List<DataPoint> dataPoints5 = new List<DataPoint>();

            dataPoints1.Add(new DataPoint(0, 1));
            dataPoints1.Add(new DataPoint(10, 1));
            dataPoints1.Add(new DataPoint(20, 0));

            dataPoints2.Add(new DataPoint(15, 0));
            dataPoints2.Add(new DataPoint(27.5, 1));
            dataPoints2.Add(new DataPoint(40, 0));

            dataPoints3.Add(new DataPoint(35, 0));
            dataPoints3.Add(new DataPoint(47.5, 1));
            dataPoints3.Add(new DataPoint(60, 0));

            dataPoints4.Add(new DataPoint(55, 0));
            dataPoints4.Add(new DataPoint(67.5, 1));
            dataPoints4.Add(new DataPoint(80, 0));

            dataPoints5.Add(new DataPoint(75, 0));
            dataPoints5.Add(new DataPoint(87.5, 1));
            dataPoints5.Add(new DataPoint(100, 0));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints3);
            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints4);

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

            ViewBag.tablo = nesne.tablo;
            return RedirectToAction("Index");
        }
    }
}