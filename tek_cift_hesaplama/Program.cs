﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_cift_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayi cifttir.");
            }
            else
            {
                Console.WriteLine("Sayi tektir.");
            }

            Console.ReadKey();
        }
    }
}
