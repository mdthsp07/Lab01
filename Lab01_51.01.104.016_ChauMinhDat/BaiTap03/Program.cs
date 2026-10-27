using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong phan tu n > 0: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i + ": ");
                while (!int.TryParse(Console.ReadLine(), out mang[i]))
                    Console.Write("Nhap lai phan tu " + i + ": ");
            }

            int tong = 0, max = mang[0], min = mang[0];
            for (int i = 0; i < n; i++)
            {
                tong += mang[i];
                if (mang[i] > max) max = mang[i];
                if (mang[i] < min) min = mang[i];
            }

            Console.WriteLine("Tong cua mang: " + tong);
            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.WriteLine("Gia tri nho nhat: " + min);
            Console.ReadKey();
        }
    }
}