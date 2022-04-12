using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] numberArr = new int[n];
            Console.WriteLine($"{n} adet sayı giriniz: ");
            for (int i = 0; i < n; i++)
            {
                numberArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numberArr);
            // int[] firstThree = numberArr[..3];
            // int[] lastThree = numberArr[^3..];
            int firstThreeSum = numberArr[0] + numberArr[1] + numberArr[2];
            Console.WriteLine($"Girilen en küçük 3 sayının toplamı: {firstThreeSum}");
            Console.WriteLine($"Girilen en küçük 3 sayının ortalaması: {(double)firstThreeSum / 3}");

            int lastThreeSum = numberArr[^3] + numberArr[^2] + numberArr[^1];
            Console.WriteLine($"Girilen en büyük 3 sayının toplamı: {lastThreeSum}");
            Console.WriteLine($"Girilen en büyük 3 sayının ortalaması: {(double)lastThreeSum / 3}");
        }
    }
}
