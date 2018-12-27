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
            dataPoints5.Add(new DataPoint(100, 1));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints4);
            ViewBag.DataPoints5 = JsonConvert.SerializeObject(dataPoints5);

            List<DataPoint> dataPoints6 = new List<DataPoint>();
            List<DataPoint> dataPoints7 = new List<DataPoint>();
            List<DataPoint> dataPoints8 = new List<DataPoint>();
            List<DataPoint> dataPoints9 = new List<DataPoint>();
            List<DataPoint> dataPoints10 = new List<DataPoint>();

            dataPoints6.Add(new DataPoint(0, 1));
            dataPoints6.Add(new DataPoint(0.5, 1));
            dataPoints6.Add(new DataPoint(1, 0));

            dataPoints7.Add(new DataPoint(0.5, 0));
            dataPoints7.Add(new DataPoint(1.25, 1));
            dataPoints7.Add(new DataPoint(2, 0));

            dataPoints8.Add(new DataPoint(1.5, 0));
            dataPoints8.Add(new DataPoint(2.5, 1));
            dataPoints8.Add(new DataPoint(3.5, 0));

            dataPoints9.Add(new DataPoint(3, 0));
            dataPoints9.Add(new DataPoint(3.75, 1));
            dataPoints9.Add(new DataPoint(4.5, 0));

            dataPoints10.Add(new DataPoint(4, 0));
            dataPoints10.Add(new DataPoint(4.5, 1));
            dataPoints10.Add(new DataPoint(5, 1));

            ViewBag.DataPoints6 = JsonConvert.SerializeObject(dataPoints6);
            ViewBag.DataPoints7 = JsonConvert.SerializeObject(dataPoints7);
            ViewBag.DataPoints8 = JsonConvert.SerializeObject(dataPoints8);
            ViewBag.DataPoints9 = JsonConvert.SerializeObject(dataPoints9);
            ViewBag.DataPoints10 = JsonConvert.SerializeObject(dataPoints10);
            ViewBag.DataPoints5 = JsonConvert.SerializeObject(dataPoints5);

            //Rezistans
            List<DataPoint> dataPoints11 = new List<DataPoint>();
            List<DataPoint> dataPoints12 = new List<DataPoint>();
            List<DataPoint> dataPoints13 = new List<DataPoint>();
            List<DataPoint> dataPoints14 = new List<DataPoint>();
            List<DataPoint> dataPoints15 = new List<DataPoint>();

            dataPoints11.Add(new DataPoint(0, 1));
            dataPoints11.Add(new DataPoint(0.5, 1));
            dataPoints11.Add(new DataPoint(1, 0));

            dataPoints12.Add(new DataPoint(0.5, 0));
            dataPoints12.Add(new DataPoint(1.25, 1));
            dataPoints12.Add(new DataPoint(2, 0));

            dataPoints13.Add(new DataPoint(1.5, 0));
            dataPoints13.Add(new DataPoint(2.5, 1));
            dataPoints13.Add(new DataPoint(3.5, 0));

            dataPoints14.Add(new DataPoint(3, 0));
            dataPoints14.Add(new DataPoint(3.75, 1));
            dataPoints14.Add(new DataPoint(4.5, 0));

            dataPoints15.Add(new DataPoint(4, 0));
            dataPoints15.Add(new DataPoint(4.5, 1));
            dataPoints15.Add(new DataPoint(5, 1));

            ViewBag.DataPoints11 = JsonConvert.SerializeObject(dataPoints11);
            ViewBag.DataPoints12 = JsonConvert.SerializeObject(dataPoints12);
            ViewBag.DataPoints13 = JsonConvert.SerializeObject(dataPoints13);
            ViewBag.DataPoints14 = JsonConvert.SerializeObject(dataPoints14);
            ViewBag.DataPoints15 = JsonConvert.SerializeObject(dataPoints15);

            double x;
            List<DataPoint> sicaklikUyelik = new List<DataPoint>();
            List<DataPoint> sicaklikUyelik1 = new List<DataPoint>();
            List<DataPoint> sicaklikUyelik2 = new List<DataPoint>();
            List<DataPoint> sicaklikUyelik3 = new List<DataPoint>();
            List<DataPoint> sicaklikUyelik4 = new List<DataPoint>();

            

            if (TempData["sicaklik"] != null)
            {
                x = Convert.ToDouble(TempData["sicaklik"]);

                if (0 <= x && x <= 20)
                {
                    
                    sicaklikUyelik.Add(new DataPoint(0, 1));
                    sicaklikUyelik.Add(new DataPoint(10, 1));
                    sicaklikUyelik.Add(new DataPoint(20, 0));
                    
                }
                /* düşük sıcaklık*/
                if (15 <= x && x <= 40)
                {
                    
                    sicaklikUyelik1.Add(new DataPoint(15, 0));
                    sicaklikUyelik1.Add(new DataPoint(27.5, 1));
                    sicaklikUyelik1.Add(new DataPoint(40, 0));
                    
                }
                /* orta sıcaklık*/
                if (35 <= x && x <= 60)
                {
                    
                    sicaklikUyelik2.Add(new DataPoint(35, 0));
                    sicaklikUyelik2.Add(new DataPoint(47.5, 1));
                    sicaklikUyelik2.Add(new DataPoint(60, 0));
                    
                }
                /* yüksek sıcaklık*/
                if (55 <= x && x <= 80)
                {
                    
                    sicaklikUyelik3.Add(new DataPoint(55, 0));
                    sicaklikUyelik3.Add(new DataPoint(67.5, 1));
                    sicaklikUyelik3.Add(new DataPoint(80, 0));
                    

                }
                /* çok yüksek sıcaklık*/
                if (75 <= x && x <= 100)
                {
                    
                    sicaklikUyelik4.Add(new DataPoint(75, 0));
                    sicaklikUyelik4.Add(new DataPoint(87.5, 1));
                    sicaklikUyelik4.Add(new DataPoint(100, 1));
                    

                }
            }

            sicaklikUyelik.Add(new DataPoint(20, 0));
            sicaklikUyelik1.Add(new DataPoint(40, 0));
            sicaklikUyelik2.Add(new DataPoint(60, 0));
            sicaklikUyelik3.Add(new DataPoint(80, 0));
            sicaklikUyelik4.Add(new DataPoint(100, 0));

            ViewBag.sicaklikUyelik = JsonConvert.SerializeObject(sicaklikUyelik);
            ViewBag.sicaklikUyelik1 = JsonConvert.SerializeObject(sicaklikUyelik1);
            ViewBag.sicaklikUyelik2 = JsonConvert.SerializeObject(sicaklikUyelik2);
            ViewBag.sicaklikUyelik3 = JsonConvert.SerializeObject(sicaklikUyelik3);
            ViewBag.sicaklikUyelik4 = JsonConvert.SerializeObject(sicaklikUyelik4);

            double y;
            List<DataPoint> seviyeUyelik = new List<DataPoint>();
            List<DataPoint> seviyeUyelik1 = new List<DataPoint>();
            List<DataPoint> seviyeUyelik2 = new List<DataPoint>();
            List<DataPoint> seviyeUyelik3 = new List<DataPoint>();
            List<DataPoint> seviyeUyelik4 = new List<DataPoint>();

            if (TempData["seviye"] != null)
            {
                y = Convert.ToDouble(TempData["seviye"]);

                if (0 <= y && y <= 20)
                {

                    seviyeUyelik.Add(new DataPoint(0, 1));
                    seviyeUyelik.Add(new DataPoint(10, 1));
                    seviyeUyelik.Add(new DataPoint(20, 0));

                }
                /* düşük sıcaklık*/
                if (15 <= y && y <= 40)
                {

                    seviyeUyelik1.Add(new DataPoint(15, 0));
                    seviyeUyelik1.Add(new DataPoint(27.5, 1));
                    seviyeUyelik1.Add(new DataPoint(40, 0));

                }
                /* orta sıcaklık*/
                if (35 <= y && y <= 60)
                {

                    seviyeUyelik2.Add(new DataPoint(35, 0));
                    seviyeUyelik2.Add(new DataPoint(47.5, 1));
                    seviyeUyelik2.Add(new DataPoint(60, 0));

                }
                /* yüksek sıcaklık*/
                if (55 <= y && y <= 80)
                {

                    seviyeUyelik3.Add(new DataPoint(55, 0));
                    seviyeUyelik3.Add(new DataPoint(67.5, 1));
                    seviyeUyelik3.Add(new DataPoint(80, 0));


                }
                /* çok yüksek sıcaklık*/
                if (75 <= y && y <= 100)
                {

                    seviyeUyelik4.Add(new DataPoint(75, 0));
                    seviyeUyelik4.Add(new DataPoint(87.5, 1));
                    seviyeUyelik4.Add(new DataPoint(100, 1));


                }
            }

            seviyeUyelik.Add(new DataPoint(20, 0));
            seviyeUyelik1.Add(new DataPoint(40, 0));
            seviyeUyelik2.Add(new DataPoint(60, 0));
            seviyeUyelik3.Add(new DataPoint(80, 0));
            seviyeUyelik4.Add(new DataPoint(100, 0));

            ViewBag.seviyeUyelik = JsonConvert.SerializeObject(seviyeUyelik);
            ViewBag.seviyeUyelik1 = JsonConvert.SerializeObject(seviyeUyelik1);
            ViewBag.seviyeUyelik2 = JsonConvert.SerializeObject(seviyeUyelik2);
            ViewBag.seviyeUyelik3 = JsonConvert.SerializeObject(seviyeUyelik3);
            ViewBag.seviyeUyelik4 = JsonConvert.SerializeObject(seviyeUyelik4);


            return View();
        }

        public ActionResult index1(double x, double y)
        {
            TempData["sicaklik"] = x;
            TempData["seviye"] = y;

            var nesne = new islem();
            var k = nesne.hesapla(x);
                var l = nesne.hesapla2(y);

                var tablo = nesne.yukle();
                var rezistansSonuc = nesne.cikarim(k, l, tablo);
                double sonuc = nesne.durulastirma(rezistansSonuc);
                if (sonuc == 404)
                {
                    TempData["Hata"] = "Çıkışta Hareket Yok";
                }
                else
                {
                    TempData["Hata"] = sonuc;
                }           

            return RedirectToAction("Index");
        }
    }
}