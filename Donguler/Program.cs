﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kur1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            //array- dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "Java","Python","C#" }; 



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}





