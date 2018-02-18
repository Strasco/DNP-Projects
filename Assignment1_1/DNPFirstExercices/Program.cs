using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNPFirstExercices
{
    class Exercices
    {
        


        static void Main(string[] args)
        {
            CLBirdie bird;
            bird = new CLBirdie();
            //Assignment 1_1
            for (int k = 100; k <= 202; k += 2)
            {
                Console.WriteLine(k + " ");

            }
            bird.makeSomeNoise();
            Console.WriteLine("Create a for loop that print every second number in the range from 100 to 202 (both inclusive)");
            Console.ReadKey();

            //Assignment 1_2
            for (int j = 202; j >= 100; j -= 2)
            {
                Console.WriteLine(j + " ");

            }
            Console.WriteLine("Create a for loop that print every second number in the range from 100 to 202 in reverse order");
            
            Console.ReadKey();

            //Assignment1_3a
            int i = 100;
            while (i <= 202)
            {
                Console.WriteLine(i + " ");
                i += 2;
            }
            Console.WriteLine("Create a while loop that print every second number in the range from 100 to 202");
            Console.ReadKey();

            //Assignment1_3b
            int a = 100;
            while (a <= 202)
            switch (a)
            {
                case 110:
                    Console.WriteLine(a + "This is a funny number");
                    a += 2;
                    break;
                case 130:
                    Console.WriteLine(a + "This is a funny number");
                    a += 2;
                    break;
                case 140:
                    Console.WriteLine(a + "This is a funny number");
                        a += 2;
                    break;
                    default:
                        Console.WriteLine(a);
                        a += 2;
                        break;
                    case 122:
                        Console.WriteLine(a+ "This is a my lucky number");
                        a += 2;
                        break;
                    case 196:
                        Console.WriteLine(a);
                        a += 4;
                        break;
            }

            Console.ReadKey();
            String hexValue;
            for (int l = 1; l <= 255; l++)
            {
                if(l <= 15)
                {
                    hexValue = l.ToString("X");
                    Console.WriteLine("0"+hexValue);
                }
                else
                {
                    hexValue = l.ToString("X");
                    Console.WriteLine(hexValue);
                }
           
                
            }
            Console.ReadKey();
        }
}
}

