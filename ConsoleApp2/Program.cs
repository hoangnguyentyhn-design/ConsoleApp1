using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            if (a < b) 
            {
              Console.WriteLine("so lon nhat la b:" + b);  
            }
            if(a < c)
            {
              Console.WriteLine("so lon nhat la c:" + c);
            }
            else
            {
              Console.WriteLine("so lon nhat la a:" + a);
            }
            Console.ReadLine();
            

        }
    }
}
