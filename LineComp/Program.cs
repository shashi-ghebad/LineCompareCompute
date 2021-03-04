using System;

namespace MeasuringEqualityOfTwoLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first x1 co-ordinate point: ");
            double x1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y1 co-ordinate point: ");
            double y1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first x2 co-ordinate point: ");
            double x2 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first y2 co-ordinate point: ");
            double y2 = (double)Convert.ToDecimal(Console.ReadLine());

            double length1 = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine("Enter the first a1 co-ordinate point: ");
            double a1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first b1 co-ordinate point: ");
            double b1 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first a2 co-ordinate point: ");
            double a2 = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the first b2 co-ordinate point: ");
            double b2 = (double)Convert.ToDecimal(Console.ReadLine());

            double length2 = (double)Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));


            Console.WriteLine("Length of the first line is: " + length1);
            Console.WriteLine("Length of the second line is: " + length2);


            if (length1 == length2)
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");

            Console.ReadKey();
        }
    }
}