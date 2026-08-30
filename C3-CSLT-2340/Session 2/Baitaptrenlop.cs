using System;
using System.Collections.Generic;
using System.Text;

namespace C3_CSLT_2340.Session_2
{
    internal class Baitaptrenlop
    {
        static void ex01()
        {
            Console.Write("Nhap vao do cua Celsius: ");
            float Celsius = float.Parse(Console.ReadLine());//
            float Kelvin = Celsius + 273;
            float Fahrenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine($"{Celsius} °C = {Kelvin} °K = {Fahrenheit} °F ");

        }
        static void ex02()
        {
            Console.Write("Nhap vao ban kinh hinh tru tron: ");
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

