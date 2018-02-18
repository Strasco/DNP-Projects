using System;
using System.Collections.Generic;

namespace HelloWorldVSC
{
    class Program
    {
        static void Main(string[] args)
        {
              IndexerNames names = new IndexerNames(2);

            names[0] = " Vlad";
            names[1] = " Alex";
            Console.WriteLine(names[1] + names[0]); 
            
            names.Age = 10111;
            Console.WriteLine(names.Age + " here");
        }
    }
}
