using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuzzyLogic.Models;

namespace FuzzyLogic.Controllers
{
    public class RezistansSonuc
    {
        public string RSeviye { get; set; }
        public string RSicaklik { get; set; }
        public string RUyelik { get; set; }
        public double RDerece { get; set; }
        public double RSicaklikDerece { get; set; }
        public double RSeviyeDerece { get; set; }
    }

    public class DuruSonucX
    {
        public Double DuruSonuc { get; set; }
        public List<Double> XList { get; set; }
        public List<Son> SonGrafikList { get; set; }
    }
    public class DuruSonuc
    {
        public double duruSonuc { get; set; }
    }

    public class Son
    {
        public double x { get; set; }
        public string uyelik { get; set; }
        public double derece { get; set; }

    }

    public class islem
    {
        static int i;
        static int y;
        public int m;
        double pay = 0;
        double payda = 0;

        /*Sıcaklık Hesaplama*/
        public List<Sicaklik> hesapla(double x)
        {
            List<Sicaklik> Sicaklik = new List<Sicaklik>();
            Sicaklik nesne = new Sicaklik();

            double derece = 0;
            i=0;
            /* çok düşük sıcaklık*/
            if (0 <= x && x <= 20)
            { 
                if (0 <= x && x <= 10)
                {
                    derece = 1;
                }
                if (10 < x && x <= 20)
                {
                    derece = (20 - x) / 10;
                }

                i++;
                nesne.Uyelik = "Çok Düşük";
                nesne.Derece = derece;
                Sicaklik.Add(nesne);
            }
            /* düşük sıcaklık*/
            if (15 <= x && x <= 40)
            {
                nesne = new Sicaklik();
                if (15 <= x && x < 27.5)
                {
                    derece = (x - 15) / 12.5;
                }
                if (27.5 <= x && x <= 40)
                {
                    derece = (40 - x) / 12.5;
                }

                i++;
                nesne.Uyelik = "Düşük";
                nesne.Derece = derece;
                Sicaklik.Add(nesne);
            }
            /* orta sıcaklık*/
            if (35 <= x && x <= 60)
            {
                nesne = new Sicaklik();
                if (35 <= x && x < 47.5)
                {
                    derece = (x - 35) / 12.5;
                }
                if (47.5 <= x && x <= 60)
                {
                    derece = (60 - x) / 12.5;
                }

                i++;
                nesne.Uyelik = "Orta";
                nesne.Derece = derece;
                Sicaklik.Add(nesne);
            }
            /* yüksek sıcaklık*/
            if (55 <= x && x <= 80)
            {
                nesne = new Sicaklik();
                if (55 <= x && x < 67.5)
                {
                    derece = (x - 55) / 12.5;
                }
                if (67.5 <= x && x <= 80)
                {
                    derece = (80 - x) / 12.5;
                }

                i++;
                nesne.Uyelik = "Yüksek";
                nesne.Derece = derece;
                Sicaklik.Add(nesne);
            }
            /* çok yüksek sıcaklık*/
            if (75 <= x && x <= 100)
            {
                nesne = new Sicaklik();
                if (75 <= x && x < 87.5)
                {
                    derece = (x - 75) / 12.5;
                }
                if (87.5 <= x && x <= 100)
                {
                    derece = (100 - x) / 12.5;
                }

                i++;
                nesne.Uyelik = "Çok Yüksek";
                nesne.Derece = derece;
                Sicaklik.Add(nesne);
            }

            return Sicaklik;
        }
        /* Seviye Hesaplama*/
        public List<Seviye> hesapla2(double x)
        {
            List<Models.Seviye> Seviye = new List<Seviye>();
            Seviye nesne = new Seviye();
            double derece = 0;
            y = 0;
            /* çok düşük seviye*/
            if (0 <= x && x <= 1)
            {
                if (0 <= x && x <= 0.5)
                {
                    derece = 1;
                }
                if (0.5 < x && x <= 1)
                {
                    derece = (1 - x) / 0.5;
                }

                y++;
                nesne.Uyelik = "Çok Düşük";
                nesne.Derece = derece;
                Seviye.Add(nesne);
            }
            /* düşük seviye*/
            if (0.5 <= x && x <= 2)
            {
                nesne = new Seviye();
                if (0.5 <= x && x < 1.25)
                {
                    derece = (x - 0.5) / 0.75;
                }
                if (1.25 <= x && x <= 2)
                {
                    derece = (2 - x) / 0.75;
                }

                y++;
                nesne.Uyelik = "Düşük";
                nesne.Derece = derece;
                Seviye.Add(nesne);
            }
            /* orta seviye*/
            if (1.5 <= x && x <= 3.5)
            {
                nesne = new Seviye();
                if (1.5 <= x && x < 2.5)
                {
                    derece = (x - 1.5);
                }
                if (2.5 <= x && x <= 3.5)
                {
                    derece = (3.5 - x);
                }

                y++;
                nesne.Uyelik = "Orta";
                nesne.Derece = derece;
                Seviye.Add(nesne);
            }
            /* yüksek seviye*/
            if (3 <= x && x <= 4.5)
            {
                nesne = new Seviye();
                if (3 <= x && x < 3.75)
                {
                    derece = (x - 3) / 0.75;
                }
                if (3.75 <= x && x <= 4.5)
                {
                    derece = (4.5 - x) / 0.75;
                }

                y++;
                nesne.Uyelik = "Yüksek";
                nesne.Derece = derece;
                Seviye.Add(nesne);
            }
            /* çok yüksek seviye*/
            if (4 <= x && x <= 5)
            {
                nesne = new Seviye();
                if (4 <= x && x < 4.5)
                {
                    derece = (x - 4) / 0.5;
                }
                if (4.5 <= x && x <= 5)
                {
                    derece = (5 - x) / 0.5;
                }

                y++;
                nesne.Uyelik = "Çok Yüksek";
                nesne.Derece = derece;
                Seviye.Add(nesne);
            }
            return Seviye;
        }

        /* Kural Tablosu Oluşturma*/
        public List<Tablo> yukle()
        {
            Tablo nesne = new Tablo();
            List<Tablo> Tablo = new List<Tablo>();

            nesne.UyelikSicaklik = "Çok Düşük"; nesne.UyelikSeviye = "Çok Düşük"; nesne.UyelikRezistans = "Orta"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Düşük"; nesne.UyelikSeviye = "Düşük"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Düşük"; nesne.UyelikSeviye = "Orta"; nesne.UyelikRezistans = "Aşırı Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Düşük"; nesne.UyelikSeviye = "Yüksek"; nesne.UyelikRezistans = "Aşırı Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Düşük"; nesne.UyelikSeviye = "Çok Yüksek"; nesne.UyelikRezistans = "Aşırı Çok"; Tablo.Add(nesne); nesne = new Tablo();


            nesne.UyelikSicaklik = "Düşük"; nesne.UyelikSeviye = "Çok Düşük"; nesne.UyelikRezistans = "Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Düşük"; nesne.UyelikSeviye = "Düşük"; nesne.UyelikRezistans = "Orta"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Düşük"; nesne.UyelikSeviye = "Orta"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Düşük"; nesne.UyelikSeviye = "Yüksek"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Düşük"; nesne.UyelikSeviye = "Çok Yüksek"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();

            nesne = new Tablo();
            nesne.UyelikSicaklik = "Orta"; nesne.UyelikSeviye = "Çok Düşük"; nesne.UyelikRezistans = "Çok Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Orta"; nesne.UyelikSeviye = "Düşük"; nesne.UyelikRezistans = "Çok Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Orta"; nesne.UyelikSeviye = "Orta"; nesne.UyelikRezistans = "Orta"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Orta"; nesne.UyelikSeviye = "Yüksek"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Orta"; nesne.UyelikSeviye = "Çok Yüksek"; nesne.UyelikRezistans = "Çok"; Tablo.Add(nesne); nesne = new Tablo();

            nesne = new Tablo();
            nesne.UyelikSicaklik = "Yüksek"; nesne.UyelikSeviye = "Çok Düşük"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Yüksek"; nesne.UyelikSeviye = "Düşük"; nesne.UyelikRezistans = "Çok Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Yüksek"; nesne.UyelikSeviye = "Orta"; nesne.UyelikRezistans = "Çok Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Yüksek"; nesne.UyelikSeviye = "Yüksek"; nesne.UyelikRezistans = "Az"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Yüksek"; nesne.UyelikSeviye = "Çok Yüksek"; nesne.UyelikRezistans = "Orta"; Tablo.Add(nesne); nesne = new Tablo();

            nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Yüksek"; nesne.UyelikSeviye = "Çok Düşük"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Yüksek"; nesne.UyelikSeviye = "Düşük"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Yüksek"; nesne.UyelikSeviye = "Orta"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Yüksek"; nesne.UyelikSeviye = "Yüksek"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne); nesne = new Tablo();
            nesne.UyelikSicaklik = "Çok Yüksek"; nesne.UyelikSeviye = "Çok Yüksek"; nesne.UyelikRezistans = "Çıkışta Hareket Yok"; Tablo.Add(nesne);

            return Tablo;
        }

        /*Bulanık Çıkarım Kurallarını Yazdırma*/
        public List<RezistansSonuc> cikarim(List<Sicaklik> k, List<Seviye> l, List<Tablo> Tablo)
        {
            Controllers.RezistansSonuc nesne = new RezistansSonuc();
            var RezistansSonuc = new List<RezistansSonuc>();
            int sayac = 0;

            foreach (var item in Tablo)
            {
                foreach (var iscaklik in k)
                {
                    foreach (var esviye in l)
                    {
                        nesne = new RezistansSonuc();
                        if (item.UyelikSicaklik == iscaklik.Uyelik && item.UyelikSeviye == esviye.Uyelik)
                        {
                            nesne.RSicaklik = item.UyelikSicaklik;
                            nesne.RSeviye = item.UyelikSeviye;
                            nesne.RUyelik = item.UyelikRezistans;
                            nesne.RSicaklikDerece = iscaklik.Derece;
                            nesne.RSeviyeDerece = esviye.Derece;

                            if (iscaklik.Derece < esviye.Derece)
                            {
                                nesne.RDerece = iscaklik.Derece;
                            }
                            else
                            {
                                nesne.RDerece = esviye.Derece;
                            }

                            RezistansSonuc.Add(nesne);
                        }
                    } 
                } 
            }
            return RezistansSonuc;
        }
        /* rezistans üyelik derecesi bulma*/
        public DuruSonucX durulastirma(List<RezistansSonuc> RezistansSonuc)
        {
            Controllers.DuruSonuc nesne = new DuruSonuc();
            var DuruSonuc = new List<DuruSonuc>();
            DuruSonucX sonucNesne = new DuruSonucX();
            sonucNesne.XList = new List<double>();

            List<Son> sonGrafik = new List<Son>();

            foreach (var item in RezistansSonuc)
            {
                double cvr = item.RDerece;
                if (item.RUyelik == "Çok Az")
                {
                    nesne = new DuruSonuc();
                    Son sonNesne = new Son();

                    nesne.duruSonuc = 1 - cvr * 0.5;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Çok Az";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);

                    m++;
                }
                if (item.RUyelik == "Az")
                {
                    nesne = new DuruSonuc();
                    Son sonNesne = new Son();

                    nesne.duruSonuc = cvr * 0.75 + 0.5;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Az";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);
                    sonNesne = new Son();

                    nesne.duruSonuc = 2 - cvr * 0.75;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;

                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Az";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);

                    m++;
                }
                if (item.RUyelik == "Orta")
                {
                    nesne = new DuruSonuc();
                    Son sonNesne = new Son();

                    nesne.duruSonuc = cvr * 1 + 1.5;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Orta";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);
                    sonNesne = new Son();

                    nesne.duruSonuc = 3.5 - cvr * 1;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Orta";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);

                    m++;
                }
                if (item.RUyelik == "Çok")
                {
                    nesne = new DuruSonuc();
                    Son sonNesne = new Son();

                    nesne.duruSonuc = cvr * 0.75 + 3;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Çok";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);
                    sonNesne = new Son();

                    nesne.duruSonuc = 4.5 - cvr * 0.75;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Çok";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);

                    m++;
                }
                if (item.RUyelik == "Aşırı Çok")
                {
                    nesne = new DuruSonuc();
                    Son sonNesne = new Son();

                    nesne.duruSonuc = cvr * 0.5 + 4;
                    pay = pay + cvr * nesne.duruSonuc;
                    payda = payda + cvr;
                    sonucNesne.XList.Add(nesne.duruSonuc);

                    sonNesne.x = nesne.duruSonuc;
                    sonNesne.uyelik = "Aşırı Çok";
                    sonNesne.derece = cvr;
                    sonGrafik.Add(sonNesne);

                    m++;
                }
            }

            sonucNesne.SonGrafikList = sonGrafik;
            sonucNesne.DuruSonuc = pay / payda;

            if (payda == 0)
            {
                sonucNesne.DuruSonuc = -999;
                return sonucNesne;
            }
            else
            {
                return sonucNesne;
            }
        }
    }
}