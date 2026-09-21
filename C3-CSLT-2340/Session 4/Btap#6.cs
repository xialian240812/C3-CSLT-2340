using System;
using System.Collections.Generic;
using System.Text;

namespace C3_CSLT_2340.Session_4
{
    public class Btap_6
    {
        static void ex01()
        {
            int TinhTong(int a, int b) => a + b;

            Console.WriteLine("--- Bài 1 ---");
            Console.WriteLine($"TinhTong(5, 3) = {TinhTong(5, 3)}");
        }

        static void ex02()
        {
            bool KiemTraChan(int n) => n % 2 == 0;

            Console.WriteLine("--- Bài 2 ---");
            Console.WriteLine($"KiemTraChan(4) = {KiemTraChan(4)}");
            Console.WriteLine($"KiemTraChan(7) = {KiemTraChan(7)}");
        }

        static void ex03()
        {
            int TimMax(int a, int b, int c) => Math.Max(Math.Max(a, b), c);

            Console.WriteLine("--- Bài 3 ---");
            Console.WriteLine($"TimMax(3, 8, 5) = {TimMax(3, 8, 5)}");
        }

        static void ex04()
        {
            long TinhGiaiThua(int n)
            {
                long result = 1;
                for (int i = 1; i <= n; i++) result *= i;
                return result;
            }

            Console.WriteLine("--- Bài 4 ---");
            Console.WriteLine($"TinhGiaiThua(5) = {TinhGiaiThua(5)}");
        }

        static void ex05()
        {
            string DaoNguocChuoi(string input)
            {
                if (string.IsNullOrEmpty(input)) return input;
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            Console.WriteLine("--- Bài 5 ---");
            Console.WriteLine($"DaoNguocChuoi(\"hello\") = {DaoNguocChuoi("hello")}");
        }

        static void ex06()
        {
            bool KiemTraNguyenTo(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            Console.WriteLine("--- Bài 6 ---");
            Console.WriteLine($"KiemTraNguyenTo(7) = {KiemTraNguyenTo(7)}");
            Console.WriteLine($"KiemTraNguyenTo(10) = {KiemTraNguyenTo(10)}");
        }

        static void ex07()
        {
            void InFibonacci(int n)
            {
                if (n <= 0) return;
                int a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                Console.WriteLine();
            }

            Console.WriteLine("--- Bài 7 ---");
            Console.Write("InFibonacci(6) = ");
            InFibonacci(6);
        }

        static void ex08()
        {
            int DemNguyenAm(string s)
            {
                int count = 0;
                string vowels = "aeiouAEIOU";
                foreach (char c in s)
                {
                    if (vowels.Contains(c)) count++;
                }
                return count;
            }

            Console.WriteLine("--- Bài 8 ---");
            Console.WriteLine($"DemNguyenAm(\"Hello World\") = {DemNguyenAm("Hello World")}");
        }

        static void ex09()
        {
            double TinhLuyThua(double x, int y)
            {
                double result = 1.0;
                int exponent = Math.Abs(y);
                for (int i = 0; i < exponent; i++) result *= x;
                return y < 0 ? 1.0 / result : result;
            }

            Console.WriteLine("--- Bài 9 ---");
            Console.WriteLine($"TinhLuyThua(2, 3) = {TinhLuyThua(2, 3)}");
        }

        static void ex10()
        {
            double TinhTrungBinh(int[] arr)
            {
                if (arr == null || arr.Length == 0) return 0;
                long sum = 0;
                foreach (int num in arr) sum += num;
                return (double)sum / arr.Length;
            }

            Console.WriteLine("--- Bài 10 ---");
            Console.WriteLine($"TinhTrungBinh([4, 5, 6, 7]) = {TinhTrungBinh(new int[] { 4, 5, 6, 7 })}");
        }

        static void ex11()
        {
            bool KiemTraDoiXung(string s)
            {
                if (string.IsNullOrEmpty(s)) return true;
                int left = 0, right = s.Length - 1;
                while (left < right)
                {
                    if (s[left] != s[right]) return false;
                    left++;
                    right--;
                }
                return true;
            }

            Console.WriteLine("--- Bài 11 ---");
            Console.WriteLine($"KiemTraDoiXung(\"radar\") = {KiemTraDoiXung("radar")}");
            Console.WriteLine($"KiemTraDoiXung(\"hello\") = {KiemTraDoiXung("hello")}");
        }

        static void ex12()
        {
            double CelsiusToFahrenheit(double c) => c * 1.8 + 32;

            Console.WriteLine("--- Bài 12 ---");
            Console.WriteLine($"CelsiusToFahrenheit(25) = {CelsiusToFahrenheit(25)}");
        }

        static void ex13()
        {
            int TimMin(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                }
                return min;
            }

            Console.WriteLine("--- Bài 13 ---");
            Console.WriteLine($"TimMin([10, 5, 8, 2, 9]) = {TimMin(new int[] { 10, 5, 8, 2, 9 })}");
        }

        static void ex14()
        {
            int TongCacChuSo(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            Console.WriteLine("--- Bài 14 ---");
            Console.WriteLine($"TongCacChuSo(1234) = {TongCacChuSo(1234)}");
        }

        static void ex15()
        {
            void SapXepMang(int[] arr)
            {
                Array.Sort(arr);
                foreach (int item in arr) Console.Write(item + " ");
                Console.WriteLine();
            }

            Console.WriteLine("--- Bài 15 ---");
            Console.Write("SapXepMang([3, 1, 4, 2]) = ");
            SapXepMang(new int[] { 3, 1, 4, 2 });
        }

        static void ex16()
        {
            string XoaTrungLap(string s)
            {
                string result = "";
                foreach (char c in s)
                {
                    if (!result.Contains(c)) result += c;
                }
                return result;
            }

            Console.WriteLine("--- Bài 16 ---");
            Console.WriteLine($"XoaTrungLap(\"programming\") = \"{XoaTrungLap("programming")}\"");
        }

        static void ex17()
        {
            int UCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            Console.WriteLine("--- Bài 17 ---");
            Console.WriteLine($"UCLN(12, 18) = {UCLN(12, 18)}");
        }

        static void ex18()
        {
            string DecimalToBinary(int n)
            {
                if (n == 0) return "0";
                string binary = "";
                int num = Math.Abs(n);
                while (num > 0)
                {
                    binary = (num % 2) + binary;
                    num /= 2;
                }
                return n < 0 ? "-" + binary : binary;
            }

            Console.WriteLine("--- Bài 18 ---");
            Console.WriteLine($"DecimalToBinary(10) = \"{DecimalToBinary(10)}\"");
        }

        static void ex19()
        {
            bool KiemTraNamNhuan(int year)
            {
                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }

            Console.WriteLine("--- Bài 19 ---");
            Console.WriteLine($"KiemTraNamNhuan(2024) = {KiemTraNamNhuan(2024)}");
            Console.WriteLine($"KiemTraNamNhuan(2023) = {KiemTraNamNhuan(2023)}");
        }

        static void ex20()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int DemSoTu(string sentence)
            {
                if (string.IsNullOrWhiteSpace(sentence)) return 0;
                string[] words = sentence.Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }

            Console.WriteLine("--- Bài 20 ---");
            Console.WriteLine($"DemSoTu(\"Học lập trình C# rất thú vị\") = {DemSoTu("Học lập trình C# rất thú vị")}");
        }

        public static void Main(string[] args)
        {
            ex01();
            ex02();
            ex03();
            ex04();
            ex05();
            ex06();
            ex07();
            ex08();
            ex09();
            ex10();
            ex11();
            ex12();
            ex13();
            ex14();
            ex15();
            ex16();
            ex17();
            ex18();
            ex19();
            ex20();
        }

    }
}
