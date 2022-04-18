using System;

namespace AritmetikIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Matematiksel Islemler

            //int sayi1 = 5;
            //int sayi2 = 3;
            //int sonuc = 0;

            //sonuc = sayi1 + sayi2;
            //Console.WriteLine("Toplam= " + sonuc);
            //Console.WriteLine("-------------Çıkarma-----------");

            //int fark=sayi1 - sayi2;
            //Console.WriteLine("Fark=" + fark);


            //int bolum = sayi1 / sayi2;

            //if (sayi2==0)
            //{
            //    Console.WriteLine("Bölen sayı '0' olamaz.");
            //}
            //else
            //{
            //    bolum = sayi1 / sayi2;
            //    Console.WriteLine(bolum);

            //}


            //Console.WriteLine("Sayı:" + sayi1);
            //sayi1++;
            //Console.WriteLine(sayi1);







            #endregion

            #region Ekrandan deger okuma

            //Console.ReadLine();
            // bu her zaman geriye string döner.
            // sayısaliçin convert lazım

            //int sayi1,sayi2;
            //string input,input2;
            //Console.WriteLine("giriniz");

            //sayi1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("yine gir");

            //sayi2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Toplam: "+(sayi1+sayi2));




            #endregion

            #region soru 1
            int sayi1, sayi2;

            //Console.WriteLine("sayı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //float sonuc1 = (sayi1 + sayi2) % (sayi1 - sayi2);
            //Console.WriteLine("Sonuc: " + sonuc1);

            #endregion

            #region soru 2



            //Console.WriteLine("sayı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //float sonuc2 = (sayi1 - sayi2) % (sayi1 + sayi2);
            //Console.WriteLine("sonuc: " + sonuc2);

            #endregion

            #region Örnek2
            //int sayi;
            //Console.WriteLine("sayı giriniz");
            //sayi =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sonuc: " + (((sayi - 10) + 20) % 2) * (((sayi - 10) + 20) % 2));



            #endregion
            #region Örnek3

            Console.WriteLine("1. sayı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.sayı karesi: " + sayi1 * sayi1);
            Console.WriteLine("2.sayı karesi: " + sayi2 * sayi2);
            float kare1 = sayi1 * sayi1;
            float kare2 = sayi2 * sayi2;
            Console.WriteLine("Kare Farkı: " + (kare1 - kare2));
            Console.WriteLine("Kare Toplamı: " + (kare1 + kare2));



            #endregion
        }
    }
}
