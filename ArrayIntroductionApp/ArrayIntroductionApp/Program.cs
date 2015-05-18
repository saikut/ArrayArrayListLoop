using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] str = new string[2] { "Hello", "World" };
            ////Console.WriteLine(str[2]);

            //Console.WriteLine(Array.IndexOf(str, "World"));

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 14;
            numbers[2] = 87;
            numbers[3] = 55;
            numbers[4] = 24;

            Console.WriteLine(Array.IndexOf(numbers, 87));

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine("Length: "+numbers.Length);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine();
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //numbers[5] = 10;
            Console.ReadKey();
        }
    }
}
