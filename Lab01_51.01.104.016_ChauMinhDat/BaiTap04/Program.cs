using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU BAI 4 ---");
                Console.WriteLine("1. Nhap ho, ten lot, ten -> Xuat ho ten day du");
                Console.WriteLine("2. Nhap ho ten day du -> Xuat tung phan");
                Console.WriteLine("3. Chuan hoa ho ten");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());

                if (chon == 0) break;
                if (chon == 1)
                {
                    Console.Write("Nhap ho: "); string ho = Console.ReadLine();
                    Console.Write("Nhap ten lot: "); string lot = Console.ReadLine();
                    Console.Write("Nhap ten: "); string ten = Console.ReadLine();
                    Console.WriteLine("Ho ten day du: {0} {1} {2}", ho, lot, ten);
                }
                else if (chon == 2)
                {
                    Console.Write("Nhap ho ten day du: ");
                    string[] parts = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 3) Console.WriteLine("Ho: {0}, Ten lot: {1}, Ten: {2}", parts[0], parts[1], parts[parts.Length - 1]);
                    else Console.WriteLine("Ban phai nhap it nhat 3 tu!");
                }
                else if (chon == 3)
                {
                    Console.Write("Nhap ho ten: ");
                    string[] words = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < words.Length; i++)
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                    Console.WriteLine("Ho ten chuan: " + string.Join(" ", words));
                }
            }
        }
    }
}