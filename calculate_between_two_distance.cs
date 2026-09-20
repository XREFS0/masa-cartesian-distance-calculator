using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter x1 and y1 coordinates:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2 and y2 coordinates:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double result = Distance(x1, x2, y1, y2);
            Console.WriteLine("Distance between coordinates {0},{1} and{2},{3} is{4:F}", x1, y1, x2 , y2, result);

            Console.ReadKey();
        }

        private static double Distance(double x1, double x2, double y1, double y2)
        {
            double temp1 = Math.Pow((x2 - x1),2);
            double temp2 = Math.Pow((y2 - y1),2);
            double answer = Math.Sqrt(temp1 + temp2);
            return answer;
       }
    }


}
