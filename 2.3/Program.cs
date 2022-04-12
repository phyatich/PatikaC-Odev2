using System;
using System.Collections.Generic;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            List<char> letterList = new List<char>();
            for (int i = 0; i < sentence.Length; i++)
            {
                switch (sentence[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü':
                        letterList.Add(sentence[i]);
                        break;
                    default:
                        continue;
                }
            }
            letterList.Sort();
            foreach (var letter in letterList)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
