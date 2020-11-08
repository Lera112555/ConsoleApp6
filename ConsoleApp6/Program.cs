
using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Kit", new DateTime(2005, 8, 7));
            cat.MakeNoise();
            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");

            cat.HungryStatus = 150;
            cat.HungryStatusChanged += Cat_HungryStatusChanged;
            

            Cat cat2 = new Cat("Cry", new DateTime(2006, 6, 1));
            cat2.MakeNoise();
            Console.WriteLine($"Коту по имени {cat2.Name} уже {cat2.GetAge()} лет");
            cat2.HungryStatusChanged += Cat2_HungryStatusChanged;
            
            
            Console.ReadLine();
        }

        private static void Cat2_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
            
        }
        CatSmartHouse catHouse = new CatSmartHouse(900);
        catHouse.AddCat(cat);
            catHouse.AddCat(cat2)

        private static void Cat_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
           
            Console.ReadLine();
        }

    } }
