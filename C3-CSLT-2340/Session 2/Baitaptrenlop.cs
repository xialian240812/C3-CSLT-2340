using System;
using System.Collections.Generic;
using System.Text;

namespace C3_CSLT_2340.Session_2
{
    internal class Baitaptrenlop
    {
        static void ex01()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào độ của celsius: ");
            float celsius = float.Parse(Console.ReadLine());//
            float kelvin = celsius + 273;
            float fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"{celsius} °C = {kelvin} °K = {fahrenheit} °F ");

        }
        static void ex02()
        {
            Console.Write("Nhập vào bán kính của hình trụ tròn: ");
            float radius = float.Parse(Console.ReadLine());//
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"surface = {surface}");
            Console.WriteLine($"volume = {volume}");
        }
        public static void Main(string[] args)
        {
            ex01();
            ex02();
        }
    }
}

