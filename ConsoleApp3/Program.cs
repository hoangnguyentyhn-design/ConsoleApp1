using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so thu nhat:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao so thu hai:");
            int b = Convert.ToInt32(Console.ReadLine());
            double Thuong = a / b;
            Console.WriteLine("Ket qua phep chia a/b:" + Convert.ToString(Thuong));
            Console.ReadKey();
        }
    }
}
