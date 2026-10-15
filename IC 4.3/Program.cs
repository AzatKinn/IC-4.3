using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            int v = 0;
            int g = 0;
            int s = 0;
            while (a >= c)
            {
                a -= c;
                v++;
            }
            while (b >= c)
            {
                b -= c;
                g++;
            }
            while (g>0)
            {
                s += v;
                g--;
            }
            Console.WriteLine(s);
            Console.ReadKey();  
        }
    }
}
