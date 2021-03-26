using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPIRandomNumbers
{
    class Program
    {
        static readonly double r = Math.Sqrt(2);
        static void Main(string[] args)
        {
            double pi; // Stores the value of Pi
            double inside=0; // stores the number of points inside the circle
            double total=0; // stores totol number of points generated
            Random random = new Random();
            Console.Write("This program will attempt to find the value of Pi using random numbers.\nThe higher the number of points, the more accurate the value of Pi will be.\nPlease input the number of points to generate:");
            double points = int.Parse(Console.ReadLine()); //Retrieves the number of points to generate
            for(double i = 0; i<points; i++) // generates each point
            {
                double x = random.NextDouble(); // generates random double between 0 and 1
                double y = random.NextDouble(); // generates random double between 0 and 1
                double z = Math.Sqrt((y * y) + (x * x)); 
                if (z <= 1) //checks if it is in the circle
                {
                    inside = inside +1;
                    total = total + 1;
                }
                else
                {
                    total = total + 1;
                }
            }
            pi = 4*(inside / total);
            Console.Write(pi);
            Console.ReadKey();
        }
    }
}
