using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding the Circumference of and area of a Circle 

            Console.WriteLine("\nCircumference and area of a Circle");
            Console.Write("Enter a number for the radius");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;  // Check the math 
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * Math.Pow(intradius, 2); // Check the math 
            Console.WriteLine ($"The area is {area}");

            // Part 2 Volume of a Hemisphere 

            Console.WriteLine("\nVolume of a hemisphere.");
            Console.Write("Enter a number for the volume of the hemisphere");
            string hemi = Console.ReadLine();
            int intrahemi = int.Parse(hemi);
            double volume = (4.0 / 3) * Math.PI * Math.Pow(intrahemi, 3) / 2; // Check the math 
            Console.WriteLine($"The volume is {volume}");

            //  Part 3 Area of a Triangle Heron's Formula 

            Console.WriteLine("\n The area of a triangle (Heron's formula) ");
            Console.WriteLine("Enter length");
            String l = Console.ReadLine();
            double length = double.Parse(l);
            Console.WriteLine("Enter Width");
            string w = Console.ReadLine();
            double Width = double.Parse(w);
            Console.WriteLine("Enter Height");
            String h = Console.ReadLine();
            double height = double.Parse(h);

            double triangle = (length + Width + height) / 2;
            Console.WriteLine($"area of triangle is : {triangle}");

            // Part 4 Solving a quadratic equatioin

            Console.WriteLine("\n Solving a quadratic equation");
            Console.WriteLine("Enter a number for alpha");
            String A = Console.ReadLine();
            double alpha = double.Parse(A);
            Console.WriteLine("Enter a number for Bravo");
            String B = Console.ReadLine();
            double Bravo = double.Parse(B);
            Console.WriteLine("Enter a number for charlie");
            String C = Console.ReadLine();
            double Charlie = double.Parse(C);
            double solve = (- Bravo + Math.Sqrt(Bravo * Bravo) - 4 *(alpha * Charlie)) / (2 * alpha);
            Console.WriteLine($"The positive solution is : {solve}");
            double slove = (-Bravo - Math.Sqrt(Bravo * Bravo) - 4 * (alpha * Charlie)) / (2 * alpha);
            Console.WriteLine($"The negative solution is : {solve}");


























        }
    }
}
