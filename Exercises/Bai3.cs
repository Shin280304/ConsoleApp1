using System;
using System.Linq;

namespace Exercises
{
    public class Exercise3
    {
        public static void Run()
        {
            Console.WriteLine("--- Bài tập 3: Tìm số lớn nhất và nhỏ nhất trong mảng ---");
            Console.Write("Nhập số lượng phần tử của mảng: ");
            
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Phần tử [{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        Console.Write($"Vui lòng nhập số nguyên hợp lệ cho phần tử [{i}]: ");
                    }
                }

                int max = numbers.Max();
                int min = numbers.Min();

                Console.WriteLine($"Mảng vừa nhập: {string.Join(", ", numbers)}");
                Console.WriteLine($"Số lớn nhất: {max}");
                Console.WriteLine($"Số nhỏ nhất: {min}");
            }
            else
            {
                Console.WriteLine("Số lượng phần tử không hợp lệ.");
            }
        }
    }
}
