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
        private static List<RezistansSonuc> rezistansSonucs;
        private static DuruSonucX duruSonuc;

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
            seviyeUyelik4.Add(new DataPoint(4, 0));
            if (TempData["seviye"] != null)
            {
                y = Convert.ToDouble(TempData["seviye"]);

                if (0 <= y && y <= 1)
                {
                    seviyeUyelik.Add(new DataPoint(0, 1));
                    seviyeUyelik.Add(new DataPoint(0.5, 1));
                    seviyeUyelik.Add(new DataPoint(1, 0));

                }
                /* düşük sıcaklık*/
                if (0.5 <= y && y <= 2)
                {
                    seviyeUyelik1.Add(new DataPoint(0.5, 0));
                    seviyeUyelik1.Add(new DataPoint(1.25, 1));
                    seviyeUyelik1.Add(new DataPoint(2, 0));

                }
                /* orta sıcaklık*/
                if (1.5 <= y && y <= 3.5)
                {
                    seviyeUyelik2.Add(new DataPoint(1.5, 0));
                    seviyeUyelik2.Add(new DataPoint(2.5, 1));
                    seviyeUyelik2.Add(new DataPoint(3.5, 0));

                }
                /* yüksek sıcaklık*/
                if (3 <= y && y <= 4.5)
                {
                    seviyeUyelik3.Add(new DataPoint(3, 0));
                    seviyeUyelik3.Add(new DataPoint(3.75, 1));
                    seviyeUyelik3.Add(new DataPoint(4.5, 0));
                }
                /* çok yüksek sıcaklık*/
                if (4 <= y && y <= 5)
                {
                    seviyeUyelik4.Add(new DataPoint(4, 0));
                    seviyeUyelik4.Add(new DataPoint(4.5, 1));
                    seviyeUyelik4.Add(new DataPoint(5, 1));
                }
            }

            seviyeUyelik.Add(new DataPoint(1, 0));
            seviyeUyelik1.Add(new DataPoint(2, 0));
            seviyeUyelik2.Add(new DataPoint(3.5, 0));
            seviyeUyelik3.Add(new DataPoint(4.5, 0));
            

            ViewBag.seviyeUyelik = JsonConvert.SerializeObject(seviyeUyelik);
            ViewBag.seviyeUyelik1 = JsonConvert.SerializeObject(seviyeUyelik1);
            ViewBag.seviyeUyelik2 = JsonConvert.SerializeObject(seviyeUyelik2);
            ViewBag.seviyeUyelik3 = JsonConvert.SerializeObject(seviyeUyelik3);
            ViewBag.seviyeUyelik4 = JsonConvert.SerializeObject(seviyeUyelik4);

            List<DataPoint> rezistansUyelik = new List<DataPoint>();
            List<DataPoint> rezistansUyelik1 = new List<DataPoint>();
            List<DataPoint> rezistansUyelik2 = new List<DataPoint>();
            List<DataPoint> rezistansUyelik3 = new List<DataPoint>();
            List<DataPoint> rezistansUyelik4 = new List<DataPoint>();

            
            
            if (rezistansSonucs != null)
            {
                List<Son> cokAz = new List<Son>();
                List<Son> az = new List<Son>();
                List<Son> orta = new List<Son>();
                List<Son> cok = new List<Son>();
                List<Son> asiriCok = new List<Son>();

                int i = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                foreach (var item in duruSonuc.SonGrafikList)
                {
                    if ("Çok Az" == item.uyelik)
                    {
                        if (a < 2)
                        {
                            cokAz.Add(item);
                            a++;
                        }
                    }
                    /* düşük sıcaklık*/
                    if ("Az" == item.uyelik)
                    {
                        if (b < 2)
                        {
                            az.Add(item);
                            b++;
                        }
                    }
                    /* orta sıcaklık*/
                    if ("Orta" == item.uyelik)
                    {

                        if (c < 2)
                        {
                            orta.Add(item);
                            c++;
                        }
                    }
                    /* yüksek sıcaklık*/
                    if ("Çok" == item.uyelik)
                    {
                        i = 0;
                        if (d < 2)
                        {
                            cok.Add(item);
                            d++;
                        }
                    }
                    /* çok yüksek sıcaklık*/
                    if ("Aşırı Çok" == item.uyelik)
                    {
                        i = 0;
                        if (i < 2)
                        {
                            asiriCok.Add(item);
                            i++;
                        }
                    }
                }

                if (cokAz.Count != 0)
                {
                    rezistansUyelik.Add(new DataPoint(0, 1));
                    rezistansUyelik.Add(new DataPoint(0.5, 1));
                    foreach (var item in cokAz)
                    {
                        rezistansUyelik.Add(new DataPoint(item.x, item.derece));
                    }
                    rezistansUyelik.Add(new DataPoint(1, 0));
                }

                if (az.Count != 0)
                {
                    int k = 0;
                    rezistansUyelik1.Add(new DataPoint(0.5, 0));
                    foreach (var item in az)
                    {
                        rezistansUyelik1.Add(new DataPoint(item.x, item.derece));
                        if (k == 0)
                        {
                            rezistansUyelik1.Add(new DataPoint(1.25, 1));
                        }

                        k++;
                    }
                    rezistansUyelik1.Add(new DataPoint(2, 0));
                }

                if (orta.Count != 0)
                {
                    int k = 0;
                    rezistansUyelik2.Add(new DataPoint(1.5, 0));
                    foreach (var item in orta)
                    {
                        rezistansUyelik2.Add(new DataPoint(item.x, item.derece));
                        if (k == 0)
                        {
                            rezistansUyelik2.Add(new DataPoint(2.5, 1));
                        }

                        k++;
                    }
                    rezistansUyelik2.Add(new DataPoint(3.5, 0));
                }

                if (cok.Count != 0)
                {
                    int k = 0;
                    rezistansUyelik3.Add(new DataPoint(3, 0));
                    foreach (var item in cok)
                    {
                        rezistansUyelik3.Add(new DataPoint(item.x, item.derece));
                        if (k == 0)
                        {
                            rezistansUyelik3.Add(new DataPoint(3.75, 1));
                        }
                    }
                    rezistansUyelik3.Add(new DataPoint(4.5, 0));
                }

                if (asiriCok.Count != 0)
                {
                    int k = 0;
                    rezistansUyelik4.Add(new DataPoint(4, 0));
                    foreach (var item in asiriCok)
                    {
                        rezistansUyelik4.Add(new DataPoint(item.x, item.derece));
                        if (k != 0)
                        {
                            rezistansUyelik4.Add(new DataPoint(4.5, 1));
                        }
                    }
                    rezistansUyelik4.Add(new DataPoint(5, 1));
                }

                //foreach (var item in rezistansSonucs)
                //{
                //    if ("Çok Az" == item.RUyelik)
                //    {
                //        rezistansUyelik.Add(new DataPoint(0, 1));
                //        rezistansUyelik.Add(new DataPoint(0.5, 1));
                //        rezistansUyelik.Add(new DataPoint(1, 0));

                //    }
                //    /* düşük sıcaklık*/
                //    if ("Az" == item.RUyelik)
                //    {
                //        rezistansUyelik1.Add(new DataPoint(0.5, 0));
                //        rezistansUyelik1.Add(new DataPoint(1.25, 1));
                //        rezistansUyelik1.Add(new DataPoint(2, 0));

                //    }
                //    /* orta sıcaklık*/
                //    if ("Orta" == item.RUyelik)
                //    {
                //        rezistansUyelik2.Add(new DataPoint(1.5, 0));
                //        rezistansUyelik2.Add(new DataPoint(2.5, 1));
                //        rezistansUyelik2.Add(new DataPoint(3.5, 0));

                //    }
                //    /* yüksek sıcaklık*/
                //    if ("Çok" == item.RUyelik)
                //    {
                //        rezistansUyelik3.Add(new DataPoint(3, 0));
                //        rezistansUyelik3.Add(new DataPoint(3.75, 1));
                //        rezistansUyelik3.Add(new DataPoint(4.5, 0));
                //    }
                //    /* çok yüksek sıcaklık*/
                //    if ("Aşırı Çok" == item.RUyelik)
                //    {
                //        rezistansUyelik4.Add(new DataPoint(4, 0));
                //        rezistansUyelik4.Add(new DataPoint(4.5, 1));
                //        rezistansUyelik4.Add(new DataPoint(5, 1));
                //    }
                //} 
            }

            rezistansUyelik.Add(new DataPoint(1, 0));
            rezistansUyelik1.Add(new DataPoint(2, 0));
            rezistansUyelik2.Add(new DataPoint(3.5, 0));
            rezistansUyelik3.Add(new DataPoint(4.5, 0));
            

            ViewBag.rezistansUyelik = JsonConvert.SerializeObject(rezistansUyelik);
            ViewBag.rezistansUyelik1 = JsonConvert.SerializeObject(rezistansUyelik1);
            ViewBag.rezistansUyelik2 = JsonConvert.SerializeObject(rezistansUyelik2);
            ViewBag.rezistansUyelik3 = JsonConvert.SerializeObject(rezistansUyelik3);
            ViewBag.rezistansUyelik4 = JsonConvert.SerializeObject(rezistansUyelik4);

            

            List<DataPoint> sonGrafikUyelik = new List<DataPoint>();
            List<DataPoint> sonGrafikUyelik1 = new List<DataPoint>();
            List<DataPoint> sonGrafikUyelik2 = new List<DataPoint>();
            List<DataPoint> sonGrafikUyelik3 = new List<DataPoint>();
            List<DataPoint> sonGrafikUyelik4 = new List<DataPoint>();


            if (rezistansSonucs != null)
            {
                List<Son> cokAz = new List<Son>();
                List<Son> az = new List<Son>();
                List<Son> orta = new List<Son>();
                List<Son> cok = new List<Son>();
                List<Son> asiriCok = new List<Son>();

                int i = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                foreach (var item in duruSonuc.SonGrafikList)
                {
                    if ("Çok Az" == item.uyelik)
                    { 
                        if (a < 2)
                        {
                            cokAz.Add(item);
                            a++;
                        }
                    }
                    /* düşük sıcaklık*/
                    if ("Az" == item.uyelik)
                    { 
                        if (b < 2)
                        {
                            az.Add(item);
                            b++;
                        }
                    }
                    /* orta sıcaklık*/
                    if ("Orta" == item.uyelik)
                    {
                        
                        if (c < 2)
                        {
                            orta.Add(item);
                            c++;
                        }
                    }
                    /* yüksek sıcaklık*/
                    if ("Çok" == item.uyelik)
                    { i = 0;
                        if (d < 2)
                        {
                            cok.Add(item);
                            d++;
                        }
                    }
                    /* çok yüksek sıcaklık*/
                    if ("Aşırı Çok" == item.uyelik)
                    { i = 0;
                        if (i < 2)
                        {
                            asiriCok.Add(item);
                            i++;
                        }
                    }
                }



                if (cokAz.Count != 0)
                {
                    sonGrafikUyelik.Add(new DataPoint(0, cokAz[0].derece));
                    foreach (var item in cokAz)
                    {
                        sonGrafikUyelik.Add(new DataPoint(item.x, item.derece));
                    }
                    sonGrafikUyelik.Add(new DataPoint(1, 0));
                }

                if (az.Count != 0)
                {
                    sonGrafikUyelik1.Add(new DataPoint(0.5, 0));
                    foreach (var item in az)
                    {
                        sonGrafikUyelik1.Add(new DataPoint(item.x, item.derece));
                    }
                    sonGrafikUyelik1.Add(new DataPoint(2, 0));
                }

                if (orta.Count != 0)
                {
                    sonGrafikUyelik2.Add(new DataPoint(1.5, 0));
                    foreach (var item in orta)
                    {
                        sonGrafikUyelik2.Add(new DataPoint(item.x, item.derece));
                    }
                    sonGrafikUyelik2.Add(new DataPoint(3.5, 0));
                }

                if (cok.Count != 0)
                {
                    sonGrafikUyelik3.Add(new DataPoint(3, 0));
                    foreach (var item in cok)
                    {
                        sonGrafikUyelik3.Add(new DataPoint(item.x, item.derece));
                    }
                    sonGrafikUyelik3.Add(new DataPoint(4.5, 0));
                }

                if (asiriCok.Count != 0)
                {
                    sonGrafikUyelik4.Add(new DataPoint(4, 0));
                    foreach (var item in asiriCok)
                    {
                        sonGrafikUyelik4.Add(new DataPoint(item.x, item.derece));
                    }
                    sonGrafikUyelik4.Add(new DataPoint(5, asiriCok[0].derece));
                }

            }

            ViewBag.sonGrafikUyelik = JsonConvert.SerializeObject(sonGrafikUyelik);
            ViewBag.sonGrafikUyelik1 = JsonConvert.SerializeObject(sonGrafikUyelik1);
            ViewBag.sonGrafikUyelik2 = JsonConvert.SerializeObject(sonGrafikUyelik2);
            ViewBag.sonGrafikUyelik3 = JsonConvert.SerializeObject(sonGrafikUyelik3);
            ViewBag.sonGrafikUyelik4 = JsonConvert.SerializeObject(sonGrafikUyelik4);

            ViewBag.rezistansSonuc = rezistansSonucs;

            if (duruSonuc != null)
            {
                ViewBag.xler = duruSonuc.XList;
            }

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
                DuruSonucX sonuc = nesne.durulastirma(rezistansSonuc);
                if (sonuc.DuruSonuc == -999)
                {
                    TempData["Hata"] = "Çıkışta Hareket Yok";
                }
                else
                {
                    TempData["Hata"] = sonuc.DuruSonuc;
                }

            duruSonuc = sonuc;
            rezistansSonucs = rezistansSonuc;
            return RedirectToAction("Index");
        }
    }
}