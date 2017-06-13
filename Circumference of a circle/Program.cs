using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circumference_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
            // Prompt the user to enter the radius of a circle.
        {
            Console.WriteLine("Please write the radius of your circle and press enter.");
            // Circumference of a Circle C= 2 * pi * r
             double pi =  3.14;
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(" The circumference of the circle is " + (2 * pi * radius));
            Console.WriteLine(" The area of the circle is " + (pi * radius * radius));
            Console.ReadLine();
             

                 
        }
    }
}
