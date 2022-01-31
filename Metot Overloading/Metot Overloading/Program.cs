using System;

namespace Metot_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Out parametre kullanımı
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı..");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız..");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            // Metot Aşırı Yükleme-Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Veysel ", " Yemlik");

             // Metot İmzası 
             // metotAdi + Parametre Sayisi + parametre



            
        }
    }
    class Metotlar
    {
        public void Topla(int a , int b , out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1 , string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}
