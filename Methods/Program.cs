using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenli
            foreach (var urun in urunler)
            { 
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("--------------Metotlar--------------");


            //instance - ornek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);



        }
    }
}



//Do not repeat yourself
