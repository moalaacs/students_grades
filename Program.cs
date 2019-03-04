using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_grades
{
    class Program //Mohammed Alaa Mohammed
    {
        static void Main(string[] args)
        {
            restart:
            int d1, d2, total;
            Console.WriteLine("Enter 1st Degree");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Degree");
            d2 = int.Parse(Console.ReadLine());

            total = d1 + d2;

             if (total >= 0 && total < 50)
             {
                 Console.WriteLine("Fail");
             }
             else if (total >= 50 && total < 65)
             {
                 Console.WriteLine("Pass");
             }
             else if (total >= 65 && total < 75)
             {
                 Console.WriteLine("Good");
             }
             else if (total >= 75 && total < 85)
             {
                 Console.WriteLine("Very Good");
             }
             else if (total >= 85 && total <= 100)
             {
                 Console.WriteLine("Excellent");
             }
             else
             {
                 Console.WriteLine("Error Try Again");
             }
             goto restart;           
        }
    }
}
