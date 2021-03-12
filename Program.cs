using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareMethodForLine
{
    class Program
    {
        public static double CalculateLength()
        {
            Console.WriteLine("Enter the first x1 co-ordinate point: ");
            double x1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y1 co-ordinate point: ");
            double y1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first x2 co-ordinate point: ");
            double x2 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y2 co-ordinate point: ");
            double y2 = (double)Convert.ToDecimal(Console.ReadLine());

            double length = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return length;
        }

        public static void CompareToMethod(double length1, double length2)
        {
            if (length1 < length2)
                Console.WriteLine("Line1 " + length1 + " is less than Line2 " + length2);
            else if (length1 > length2)
                Console.WriteLine("Line1 " + length1 + " is greater than Line2" + length2);
            else
                Console.WriteLine("Lines are equal of length " + length1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Coordinate for First Line");
            double length1 = CalculateLength();
            Console.WriteLine("Coordinate for Second Line");
            double length2 = CalculateLength();

            Console.WriteLine("Length of the first line is: " + length1);
            Console.WriteLine("Length of the second line is: " + length2);

            CompareToMethod(length1, length2);

            Console.ReadKey();
        }
    }
}
