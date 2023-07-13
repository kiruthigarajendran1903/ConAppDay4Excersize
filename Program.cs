using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay4AS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            int no = int.Parse(Console.ReadLine());
            if (no > 0)
            {
                Console.WriteLine("no is positive");
            }
            else
            {
                Console.WriteLine("no is negative");
            }
            string OddOrEven = (no % 2 == 0) ? "even" : "odd";
            Console.WriteLine(OddOrEven);
        }
        


        }
    }

