using System;

namespace Exercises
{
    public class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine("--- Bài tập 2: Kiểm tra số nguyên tố ---");
            Console.Write("Nhập một số nguyên dương: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{number} không phải là số nguyên tố.");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
