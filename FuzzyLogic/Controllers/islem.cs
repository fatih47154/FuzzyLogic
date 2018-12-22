using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuzzyLogic.Controllers
{
    public class islem
    {
        public double[,] dizi1 = new double[2, 2];
        public double[,] dizi2 = new double[2, 2];
        public string[,] tablo = new string[5, 5];
        public string[,] rezistan = new string[2, 2];
        public string[,] rezistan_sonuc = new string[2, 2];
        public double[,] duru_sonuc = new double[2, 4];
        public int i;
        public int y;
        public int m;
        double pay = 0;
        double payda = 0;

        /*Sıcaklık Hesaplama*/
        public int hesapla(double x)
        {
            int i = 0;
            /* çok düşük sıcaklık*/
            if (0 <= x && x <= 20)
            {
                dizi1[i, 0] = 0;
                if (0 <= x && x <= 10)
                {
                    dizi1[i, 1] = 1;
                }
                if (10 < x && x <= 20)
                {
                    dizi1[i, 1] = (20 - x) / 10;
                }
                i++;
            }
            /* düşük sıcaklık*/
            if (15 <= x && x <= 40)
            {
                dizi1[i, 0] = 1;

                if (15 <= x && x < 27.5)
                {
                    dizi1[i, 1] = (x - 15) / 12.5;
                }
                if (27.5 <= x && x <= 40)
                {
                    dizi1[i, 1] = (40 - x) / 12.5;
                }
                i++;
            }
            /* orta sıcaklık*/
            if (35 <= x && x <= 60)
            {
                dizi1[i, 0] = 2;

                if (35 <= x && x < 47.5)
                {
                    dizi1[i, 1] = (x - 35) / 12.5;
                }
                if (47.5 <= x && x <= 60)
                {
                    dizi1[i, 1] = (60 - x) / 12.5;
                }
                i++;
            }
            /* yüksek sıcaklık*/
            if (55 <= x && x <= 80)
            {
                dizi1[i, 0] = 3;

                if (55 <= x && x < 67.5)
                {
                    dizi1[i, 1] = (x - 55) / 12.5;
                }
                if (67.5 <= x && x <= 80)
                {
                    dizi1[i, 1] = (80 - x) / 12.5;
                }
                i++;
            }
            /* çok yüksek sıcaklık*/
            if (75 <= x && x <= 100)
            {
                dizi1[i, 0] = 4;

                if (75 <= x && x < 87.5)
                {
                    dizi1[i, 1] = (x - 75) / 12.5;
                }
                if (87.5 <= x && x <= 100)
                {
                    dizi1[i, 1] = (100 - x) / 12.5;
                }
                i++;
            }
            return i;
        }
        /* Seviye Hesaplama*/
        public int hesapla2(double x)
        {
            int y = 0;
            /* çok düşük seviye*/
            if (0 <= x && x <= 1)
            {
                dizi2[y, 0] = 0;
                if (0 <= x && x <= 0.5)
                {
                    dizi2[y, 1] = 1;
                }
                if (0.5 < x && x <= 1)
                {
                    dizi2[y, 1] = (1 - x) / 0.5;
                }
                y++;
            }
            /* düşük seviye*/
            if (0.5 <= x && x <= 2)
            {
                dizi2[y, 0] = 1;

                if (0.5 <= x && x < 1.25)
                {
                    dizi2[y, 1] = (x - 0.5) / 0.75;
                }
                if (1.25 <= x && x <= 2)
                {
                    dizi2[y, 1] = (2 - x) / 0.75;
                }
                y++;
            }
            /* orta seviye*/
            if (1.5 <= x && x <= 3.5)
            {
                dizi2[y, 0] = 2;

                if (1.5 <= x && x < 2.5)
                {
                    dizi2[y, 1] = (x - 1.5);
                }
                if (2.5 <= x && x <= 3.5)
                {
                    dizi2[y, 1] = (3.5 - x);
                }
                y++;
            }
            /* yüksek seviye*/
            if (3 <= x && x <= 4.5)
            {
                dizi2[y, 0] = 3;

                if (3 <= x && x < 3.75)
                {
                    dizi2[y, 1] = (x - 3) / 0.75;
                }
                if (3.75 <= x && x <= 4.5)
                {
                    dizi2[y, 1] = (4.5 - x) / 0.75;
                }
                y++;
            }
            /* çok yüksek seviye*/
            if (4 <= x && x <= 5)
            {
                dizi2[y, 0] = 4;

                if (4 <= x && x < 4.5)
                {
                    dizi2[y, 1] = (x - 4) / 0.5;
                }
                if (4.5 <= x && x <= 5)
                {
                    dizi2[y, 1] = (5 - x) / 0.5;
                }
                y++;
            }
            return y;
        }

        /* Kural Tablosu Oluşturma*/
        public void yukle()
        {
            tablo[0, 0] = "Orta";
            tablo[0, 1] = "Az";
            tablo[0, 2] = "Çok Az";
            tablo[0, 3] = "Hareket Yok";
            tablo[0, 4] = "Hareket Yok";

            tablo[1, 0] = "Çok";
            tablo[1, 1] = "Orta";
            tablo[1, 2] = "Çok Az";
            tablo[1, 3] = "Çok Az";
            tablo[1, 4] = "Hareket Yok";

            tablo[2, 0] = "Aşırı Çok";
            tablo[2, 1] = "Çok";
            tablo[2, 2] = "Orta";
            tablo[2, 3] = "Çok Az";
            tablo[2, 4] = "Hareket Yok";

            tablo[3, 0] = "Aşırı Çok";
            tablo[3, 1] = "Çok";
            tablo[3, 2] = "Çok";
            tablo[3, 3] = "Az";
            tablo[3, 4] = "Hareket Yok";

            tablo[4, 0] = "Aşırı Çok";
            tablo[4, 1] = "Çok";
            tablo[4, 2] = "Çok";
            tablo[4, 3] = "Orta";
            tablo[4, 4] = "Hareket Yok";
        }
        /*Bulanık Çıkarım Kurallarını Yazdırma*/
        public void cikarim(int k, int l)
        {
            for (int a = 0; a < k; a++)
            {
                for (int j = 0; j < l; j++)
                {
                    int don1 = Convert.ToInt32(dizi1[a, 0]);
                    int don2 = Convert.ToInt32(dizi2[j, 0]);
                    double don3 = Convert.ToDouble(dizi1[a, 1]);
                    double don4 = Convert.ToDouble(dizi2[j, 1]);

                    if (don3 > don4)
                    {
                        rezistan_sonuc[a, j] = don4.ToString();
                    }
                    else
                    {
                        rezistan_sonuc[a, j] = don3.ToString();
                    }

                    rezistan[a, j] = tablo[don2, don1];
                }
            }
        }
        /* rezistans üyelik derecesi bulma*/
        public double durulastirma(int k, int l)
        {
            for (int z = 0; z < 1; z++)
            {
                m = z;
                for (int a = 0; a < k; a++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        double cvr = Convert.ToDouble(rezistan_sonuc[a, j]);
                        if (rezistan[a, j] == "Çok Az")
                        {
                            duru_sonuc[0, m] = 1;
                            pay = pay + cvr * duru_sonuc[0, m];
                            payda = payda + cvr;
                            duru_sonuc[1, m] = 1 - cvr * 0.5;
                            pay = pay + cvr * duru_sonuc[1, m];
                            payda = payda + cvr;
                            m++;
                        }
                        if (rezistan[a, j] == "Az")
                        {
                            duru_sonuc[0, m] = cvr * 0.75 + 0.5;
                            pay = pay + cvr * duru_sonuc[0, m];
                            payda = payda + cvr;
                            duru_sonuc[1, m] = 2 - cvr * 0.75;
                            pay = pay + cvr * duru_sonuc[1, m];
                            payda = payda + cvr;
                            m++;
                        }
                        if (rezistan[a, j] == "Orta")
                        {
                            duru_sonuc[0, m] = cvr * 1 + 1.5;
                            pay = pay + cvr * duru_sonuc[0, m];
                            payda = payda + cvr;
                            duru_sonuc[1, m] = 3.5 - cvr * 1;
                            pay = pay + cvr * duru_sonuc[1, m];
                            payda = payda + cvr;
                            m++;
                        }
                        if (rezistan[a, j] == "Çok")
                        {
                            duru_sonuc[0, m] = cvr * 0.75 + 3;
                            pay = pay + cvr * duru_sonuc[0, m];
                            payda = payda + cvr;
                            duru_sonuc[1, m] = 4.5 - cvr * 0.75;
                            pay = pay + cvr * duru_sonuc[1, m];
                            payda = payda + cvr;
                            m++;
                        }
                        if (rezistan[a, j] == "Aşırı Çok")
                        {
                            duru_sonuc[0, m] = cvr * 0.5 + 4;
                            pay = pay + cvr * duru_sonuc[0, m];
                            payda = payda + cvr;
                            duru_sonuc[1, m] = 1;
                            pay = pay + cvr * duru_sonuc[1, m];
                            payda = payda + cvr;
                            m++;
                        }
                    }
                }
            }
            if (payda == 0)
            {
                return 404;
            }
            else
            {
                return pay / payda;
            }
        }
    }
}