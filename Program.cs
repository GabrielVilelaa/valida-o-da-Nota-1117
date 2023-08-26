using System;
using System.Globalization;

class URI
{
    class program {
        static void Main(string[] args)
        {
            double grade1,grade2, sum;

            grade1 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            sum = 0.0;
            while (grade1 < 0.0 || grade1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                grade1 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            }

            grade2 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            while (grade2 > 0.0 || grade2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                grade2 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));

            }
            sum = (grade1 + grade2) / 2.0;
            Console.WriteLine("media = " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}