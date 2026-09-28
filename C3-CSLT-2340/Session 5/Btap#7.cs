using System;
using System.Collections.Generic;
using System.Text;

namespace C3_CSLT_2340.Session_5
{
    internal class Btap_7
    {
        static void ex01()
        {
            Random random = new Random();
            int[] randomArray = new int[10];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 21);
            }

            Console.WriteLine($"Mảng ban đầu: [{string.Join(", ", randomArray)}]\n");

            int sampleTarget = randomArray[0];

            Console.WriteLine($"1. Giá trị trung bình: {CalculateAverage(randomArray):F2}");

            Console.WriteLine($"2. Có chứa số {sampleTarget} không?: {ContainsValue(randomArray, sampleTarget)}");
            Console.WriteLine($"   Có chứa số 99 không?: {ContainsValue(randomArray, 99)}");

            Console.WriteLine($"3. Vị trí của số {sampleTarget}: {FindIndex(randomArray, sampleTarget)}");

            int[] afterRemoval = RemoveElement(randomArray, sampleTarget);
            Console.WriteLine($"4. Mảng sau khi xóa số {sampleTarget}: [{string.Join(", ", afterRemoval)}]");

            var (min, max) = FindMinMax(randomArray);
            Console.WriteLine($"5. Giá trị nhỏ nhất: {min}, Giá trị lớn nhất: {max}");

            int[] reversed = ReverseArray(randomArray);
            Console.WriteLine($"6. Mảng sau khi đảo ngược: [{string.Join(", ", reversed)}]");

            int[] duplicates = FindDuplicates(randomArray);
            Console.WriteLine($"7. Các giá trị bị trùng lặp: [{string.Join(", ", duplicates)}]");

            int[] uniqueArray = RemoveDuplicates(randomArray);
            Console.WriteLine($"8. Mảng sau khi xóa phần tử trùng: [{string.Join(", ", uniqueArray)}]");

            static double CalculateAverage(int[] arr)
            {
                if (arr == null || arr.Length == 0) return 0;
                return arr.Average();
            }

            static bool ContainsValue(int[] arr, int target)
            {
                return Array.Exists(arr, element => element == target);
            }

            static int FindIndex(int[] arr, int target)
            {
                return Array.IndexOf(arr, target);
            }

            static int[] RemoveElement(int[] arr, int target)
            {
                int index = Array.IndexOf(arr, target);
                if (index == -1) return (int[])arr.Clone();

                int[] result = new int[arr.Length - 1];
                Array.Copy(arr, 0, result, 0, index);
                Array.Copy(arr, index + 1, result, index, arr.Length - index - 1);
                return result;
            }

            static (int min, int max) FindMinMax(int[] arr)
            {
                if (arr == null || arr.Length == 0)
                    throw new ArgumentException("Mảng không được rỗng.");

                return (arr.Min(), arr.Max());
            }

            static int[] ReverseArray(int[] arr)
            {
                int[] reversed = (int[])arr.Clone();
                Array.Reverse(reversed);
                return reversed;
            }

            static int[] FindDuplicates(int[] arr)
            {
                HashSet<int> seen = new HashSet<int>();
                HashSet<int> duplicates = new HashSet<int>();

                foreach (int item in arr)
                {
                    if (!seen.Add(item))
                    {
                        duplicates.Add(item);
                    }
                }

                return duplicates.ToArray();
            }

            static int[] RemoveDuplicates(int[] arr)
            {
                return arr.Distinct().ToArray();
            }
        }

        static void ex02()
        {
            Console.WriteLine("=== PHẦN 1: SẮP XẾP NỔI BỌT (BUBBLE SORT) ===");
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i + 1}/10: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại một số nguyên: ");
                }
            }

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Hoán đổi hai phần tử kế tiếp
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }

                Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
                Console.WriteLine(string.Join(", ", numbers));

                Console.WriteLine("\n=== PHẦN 2: TÌM KIẾM TUYẾN TÍNH (LINEAR SEARCH) ===");

                Console.Write("Nhập vào một câu: ");
                string sentence = Console.ReadLine() ?? "";

                Console.Write("Nhập từ cần tìm: ");
                string targetWord = Console.ReadLine() ?? "";

                char[] separators = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-' };
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                bool found = false;
                int foundIndex = -1;

                for (int k = 0; k< words.Length; k++)
                {
                    if (string.Equals(words[k], targetWord, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        foundIndex = k;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine($"\nKết quả: Từ '{targetWord}' xuất hiện trong câu ở vị trí từ thứ {foundIndex + 1}.");
                }
                else
                {
                    Console.WriteLine($"\nKết quả: Từ '{targetWord}' không tồn tại trong câu.");
                }
            }
        }

        static void ex03()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số hàng N: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine() ?? "0");

            int[,] matrix = CreateRandomMatrix(n, m);

            Console.WriteLine("\n--- MA TRẬN BAN ĐẦU ---");
            PrintMatrix(matrix);

            Console.Write($"\nNhập chỉ số hàng i cần in (0 đến {n - 1}): ");
            int rowIdx = int.Parse(Console.ReadLine() ?? "0");
            PrintRow(matrix, rowIdx);

            Console.Write($"Nhập chỉ số cột i cần in (0 đến {m - 1}): ");
            int colIdx = int.Parse(Console.ReadLine() ?? "0");
            PrintColumn(matrix, colIdx);

            Console.WriteLine($"\nGiá trị lớn nhất của ma trận: {FindMax(matrix)}");

            Console.Write($"\nNhập chỉ số hàng i để tìm Min (0 đến {n - 1}): ");
            int minRowIdx = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Giá trị nhỏ nhất của hàng {minRowIdx}: {FindMinOfRow(matrix, minRowIdx)}");

            Console.Write($"Nhập chỉ số cột i để tìm Min (0 đến {m - 1}): ");
            int minColIdx = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Giá trị nhỏ nhất của cột {minColIdx}: {FindMinOfColumn(matrix, minColIdx)}");

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ ---");
            int[,] transposed = TransposeMatrix(matrix);
            PrintMatrix(transposed);

            Console.WriteLine("\n--- ĐƯỜNG CHÉO MA TRẬN ---");
            PrintDiagonals(matrix);

            static int[,] CreateRandomMatrix(int rows, int cols)
            {
                Random random = new Random();
                int[,] matrix = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = random.Next(1, 100);
                    }
                }
                return matrix;
            }

            static void PrintMatrix(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{matrix[i, j],4} ");
                    }
                    Console.WriteLine();
                }
            }

            static void PrintRow(int[,] matrix, int rowIndex)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                if (rowIndex < 0 || rowIndex >= rows)
                {
                    Console.WriteLine("Chỉ số hàng không hợp lệ.");
                    return;
                }

                Console.Write($"Hàng {rowIndex}: ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[rowIndex, j]} ");
                }
                Console.WriteLine();
            }

            static void PrintColumn(int[,] matrix, int colIndex)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                if (colIndex < 0 || colIndex >= cols)
                {
                    Console.WriteLine("Chỉ số cột không hợp lệ.");
                    return;
                }

                Console.Write($"Cột {colIndex}: ");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"{matrix[i, colIndex]} ");
                }
                Console.WriteLine();
            }

            static int FindMax(int[,] matrix)
            {
                int max = matrix[0, 0];
                foreach (int val in matrix)
                {
                    if (val > max) max = val;
                }
                return max;
            }

            static int FindMinOfRow(int[,] matrix, int rowIndex)
            {
                int cols = matrix.GetLength(1);
                int min = matrix[rowIndex, 0];

                for (int j = 1; j < cols; j++)
                {
                    if (matrix[rowIndex, j] < min)
                        min = matrix[rowIndex, j];
                }
                return min;
            }

            static int FindMinOfColumn(int[,] matrix, int colIndex)
            {
                int rows = matrix.GetLength(0);
                int min = matrix[0, colIndex];

                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, colIndex] < min)
                        min = matrix[i, colIndex];
                }
                return min;
            }

            static int[,] TransposeMatrix(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] transposed = new int[cols, rows];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        transposed[j, i] = matrix[i, j];
                    }
                }
                return transposed;
            }

            static void PrintDiagonals(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                if (rows != cols)
                {
                    Console.WriteLine("Không thể in đường chéo vì đây không phải là ma trận vuông (N != M).");
                    return;
                }

                Console.Write("Đường chéo chính: ");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"{matrix[i, i]} ");
                }
                Console.WriteLine();

                Console.Write("Đường chéo phụ: ");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"{matrix[i, rows - 1 - i]} ");
                }
                Console.WriteLine();
            }

        }
            static void Main(string[] args)
            {
                ex01();
                ex02();
                ex03();
            }
    }
}
