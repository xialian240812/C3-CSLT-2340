using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C3_CSLT_2340.Session_3
{
    internal class hocbuT7_1209
    {
        static void ex06()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng số hạng n: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0.0;

                Console.Write("\nDãy Harmonic: ");
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                    if (i == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write($" + 1/{i}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"\nTổng của {n} số hạng đầu tiên: {sum:F4}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
            }
        }

        static void ex07()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập vào số bắt đầu (từ): ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhập vào số kết thúc (đến): ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nCác số hoàn hảo trong khoảng từ {start} đến {end} là:");
            bool found = false;

            for (int i = start; i <= end; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy số hoàn hảo nào trong khoảng này.");
            }
            static bool IsPerfectNumber(int number)
            {
                if (number <= 1) return false;

                int sum = 1;
                int limit = (int)Math.Sqrt(number);

                for (int i = 2; i <= limit; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                        int divisorPair = number / i;
                        if (divisorPair != i)
                        {
                            sum += divisorPair;
                        }
                    }
                }

                return sum == number; // Đặt dòng này nằm bên trong hàm
            }
        }

        public static void Main(string[] args)
        {
            ex06();
            ex07();
        }
    }
}
