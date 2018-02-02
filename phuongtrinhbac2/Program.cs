using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            float del = (b * b) - (4 * a * c);
            if (del < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (del == 0)
            {
                float x = -b / (2 * a);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(del)) / (2 * a);
                double x2 = (-b - Math.Sqrt(del)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem: x1={0}, x2={1}", x1, x2);
            }
        }
    }
}
