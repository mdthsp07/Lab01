using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap tham so a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("a khong hop le, nhap lai a: ");

            Console.Write("Nhap tham so b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.Write("b khong hop le, nhap lai b: ");

            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Phuong trinh co vo so nghiem");
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x = " + x);
            }
            Console.ReadKey();
        }
    }
}