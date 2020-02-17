using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // введення вихідних даних
            Console.Write("PI=");
            double PI = double.Parse(Console.ReadLine());
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("c=");пше
            double c = double.Parse(Console.ReadLine());
            // реалізація алгоритму розв'язання задачі
            double y = Math.Pow((c * x - a), 3) + Math.Log(x) / 2*Math.Sin(PI / 3 + x);
            // вивід результату
            Console.WriteLine("y={0}", y);//
            Console.ReadKey();//
        }
    }
}
