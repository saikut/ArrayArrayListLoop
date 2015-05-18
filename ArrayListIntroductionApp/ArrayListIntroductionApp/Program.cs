using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("SEIP");
            myArrayList.Add(12.5);

            Console.WriteLine(myArrayList[1]);
            //foreach (var VARIABLE in myArrayList)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            Console.ReadKey();
        }
    }
}
