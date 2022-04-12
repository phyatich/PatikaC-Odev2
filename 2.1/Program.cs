using System;
using System.Collections;
using System.Collections.Generic;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeList = new ArrayList();    
            ArrayList nonPrimeList = new ArrayList();    
            int n = 5;
            Console.WriteLine($"{n} adet pozitif sayı giriniz: ");
            for (int i = 0; i < n; i++)
            {
                int number;
                bool success = int.TryParse(Console.ReadLine(), out number);
                if (success && number > 0)
                {
                    if (IsPrime(number))
                        primeList.Add(number);
                    else
                    {
                        nonPrimeList.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Girilen değer pozitif bir sayı değil. Tekrar deneyiniz.");
                    i--;
                }
            }

            primeList.Sort();
            nonPrimeList.Sort();
            Console.Write("Asal sayılar:         ");
            foreach (var item in primeList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Asal olmayan sayılar: ");
            foreach (var item in nonPrimeList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Girilen asal sayı adedi: {primeList.Count}");
            int primeListSum = 0;
            foreach (var item in primeList)
            {
                primeListSum += (int)item; 
            }
            Console.WriteLine($"Girilen asal sayıların ortalaması: {(double)primeListSum / primeList.Count}");

            Console.WriteLine($"Girilen asal olmayan sayı adedi: {nonPrimeList.Count}");
            int nonPrimeListSum = 0;
            foreach (var item in nonPrimeList)
            {
                nonPrimeListSum += (int)item; 
            }
            Console.WriteLine($"Girilen asal olmayan sayıların ortalaması: {(double)nonPrimeListSum / nonPrimeList.Count}");
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            
            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i+= 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
