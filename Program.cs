using System;

namespace LineCompare
{
    class Program
    {
       
        // Function to calculate 
        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating distance 
                return Math.Sqrt(Math.Pow(x2 - x1, 2) +  Math.Pow(y2 - y1, 2) * 1.0);
        }

                public static void Main()
                {
                Console.WriteLine(Math.Round(distance(5, 6, 6, 5) * 100.0) / 100.0);

        }
    }
}
