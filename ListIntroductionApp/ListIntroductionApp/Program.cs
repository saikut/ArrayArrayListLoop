using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(4);
            myList.Add(9);
            myList.Add(24);

            myList.Reverse();
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            List<string> secondList = new List<string>();
            secondList.Add("BITM");
            secondList.Add("Nerd Castle");

            foreach (string s in secondList)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
