using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Number from 1 to 9");
            byte points = byte.Parse(Console.ReadLine());
            switch (points)
            {
                case 1: 
                case 2: 
                case 3:
                    Console.WriteLine("{0}", points * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("{0}", points * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("{0}", points * 1000);
                    break;
                default:
                    Console.WriteLine("Error imput a number from 1 to 9");
                    break;

            }
        }
    }
}
