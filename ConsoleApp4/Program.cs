using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so thu nhat:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao so thu hai:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao so thu ba:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a != 0 && b != 0 && c != 0)
                Console.WriteLine("day la 1 tam giac");
            else
                Console.WriteLine("day khong phai la 1 tam giac");
            Console.ReadLine();
        }
    }
}
