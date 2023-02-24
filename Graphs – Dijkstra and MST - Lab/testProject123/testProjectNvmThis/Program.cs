using System.Collections.Generic;
using System.Linq;

namespace testProjectNvmThis
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = 5;

            var array = new int[5];

            var mylist = new List<int>();

           
            mylist.Add(1);

            var b = mylist.Average();

            Console.WriteLine($"{b} && {mylist.Count:f4}");


        }
    }
}
