using System;

namespace Exercises
{
    public class Exercise1
    {
        public static void Run()
        {
            Console.WriteLine("--- Bài tập 1: Tính diện tích hình chữ nhật ---");
            Console.Write("Nhập chiều dài: ");
            if (double.TryParse(Console.ReadLine(), out double length))
            {
                Console.Write("Nhập chiều rộng: ");
                if (double.TryParse(Console.ReadLine(), out double width))
                {
                    double area = length * width;
                    Console.WriteLine($"Diện tích hình chữ nhật là: {area}");
                }
                else
                {
                    Console.WriteLine("Chiều rộng không hợp lệ.");
                }
            }
            else
            {
                Console.WriteLine("Chiều dài không hợp lệ.");
            }
        }
    }
}
