using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            //Do not repeat yourself
            //deger tutucu, alias(takma isim)

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }
            
            
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            


            //Console.WriteLine(kategoriEtiketi);


        }
    }
}
