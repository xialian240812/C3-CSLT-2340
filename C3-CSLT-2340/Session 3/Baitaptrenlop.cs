using System;
using System.Collections.Generic;
using System.Text;

namespace C3_CSLT_2340.Session_3
{
    internal class Baitaptrenlop
    {
        static void ex01()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chữ số đầu tiên: ");
            double n1 = Convert.ToDouble(Console.ReadLine());//

            Console.Write("Nhập phép toán tử (+,-,*,/): ");
            char op = Convert.ToChar(Console.ReadLine());//

            Console.Write("Nhập chữ số thứ hai: ");
            double n2 = Convert.ToDouble(Console.ReadLine());//

            double result;

            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine($"{n1} + {n2} = {result}");
                    break;

                case '-':
                    result = n1 - n2;
                    Console.WriteLine($"{n1} - {n2} = {result}");
                    break;

                case '*':
                    result = n1 * n2;
                    Console.WriteLine($"{n1} * {n2} = {result}");
                    break;

                case '/':
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result}");
                    break;
                
            }
        }
              public static void Main(string[] args)
              {
                  ex01 ();
              }
    }
}

