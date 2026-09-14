using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C3_CSLT_2340.Session_3
{
    internal class baitap_4
    {
        static void ex01()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập tuổi người xem: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Nhập giờ chiếu (0 - 23): ");
            int hour = int.Parse(Console.ReadLine());

            int price;

            if (age < 12 || age > 60)
            {
                price = 50000;
            }
            else
            {
                // if-else lồng nhau kiểm tra khung giờ chiếu
                if (hour < 17)
                {
                    price = 80000;
                }
                else
                {
                    price = 110000;
                }
            }

            Console.WriteLine($"Giá vé của bạn là: {price:N0} VNĐ");
        }

        static void ex02()
        {
            Console.Write("Nhập mã vai trò (ADMIN, MANAGER, EMPLOYEE, GUEST): ");
            string role = Console.ReadLine()?.Trim().ToUpper();

            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
                    break;
                default:
                    Console.WriteLine("Mã vai trò không hợp lệ!");
                    break;
            }
        }
         
        static void ex04()
        {
            Console.Write("Phím bấm = ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("[Tổng đài]: Đang kết nối tới tổng đài viên tư vấn thẻ.");
                    break;
                case "2":
                    Console.WriteLine("[Tổng đài]: Đang tra cứu số dư tài khoản của bạn.");
                    break;
                case "3":
                    Console.WriteLine("[Tổng đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.");
                    break;
                case "4":
                    Console.WriteLine("[Tổng đài]: Đang tra cứu tỷ giá ngoại tệ hôm nay.");
                    break;
                case "0":
                    Console.WriteLine("[Tổng đài]: Đã quay lại menu chính.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                    break;
            }
        }

        static void ex06()
        {
            
                Console.Write("Nhập mã trạng thái đơn hàng (1-5): ");
                string status = Console.ReadLine()?.Trim();

                // Sử dụng switch để cập nhật và hiển thị trạng thái đơn hàng
                switch (status)
                {
                    case "1":
                        Console.WriteLine("Chờ xác nhận thanh toán.");
                        break;
                    case "2":
                        Console.WriteLine("Đang đóng gói và bàn giao đơn vị vận chuyển.");
                        break;
                    case "3":
                        Console.WriteLine("Đơn hàng đang trên đường giao đến bạn.");
                        break;
                    case "4":
                        Console.WriteLine("Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                        break;
                    case "5":
                        Console.WriteLine("Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                        break;
                    default:
                        Console.WriteLine("Mã trạng thái không hợp lệ!");
                        break;
                }
            }

        static void ex07()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Cân nặng = ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Chiều cao = ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string result;
            if (bmi < 18.5)
            {
                result = "Thấy gầy - Nên bổ sung dinh dưỡng.";
            }
            else if (bmi < 25)
            {
                result = "Cân đối - Tiếp tục duy trì.";
            }
            else if (bmi < 30)
            {
                result = "Thừa cân - Nên tăng cường luyện tập.";
            }
            else
            {
                result = "Béo phì - Cần sự tư vấn từ bác sĩ.";
            }

            Console.WriteLine($"BMI: {bmi:F2} - Đánh giá: {result}");
        }
         
        static void ex08()
        {
            Console.Write("Nhập loại xe (BIKE hoặc CAR): ");
            string vehicle = Console.ReadLine()?.Trim().ToUpper();

            Console.Write("Nhập thời gian gửi (1: Ban ngày, 2: Ban đêm): ");
            int time = int.Parse(Console.ReadLine());

            int fee = 0;
            bool isValid = true;

            switch (vehicle)
            {
                case "BIKE":
                    if (time == 1)
                    {
                        fee = 5000;
                    }
                    else if (time == 2)
                    {
                        fee = 10000;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;

                case "CAR":
                    if (time == 1)
                    {
                        fee = 30000;
                    }
                    else if (time == 2)
                    {
                        fee = 60000;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;

                default:
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine($"Phí đỗ xe: {fee:N0} VNĐ");
            }
            else
            {
                Console.WriteLine("Loại xe hoặc thời gian gửi không hợp lệ!");
            }
        }

        static void ex09()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập điểm trung bình (GPA 4.0): ");
            double gpa = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm rèn luyện (DRL 100): ");
            int drl = int.Parse(Console.ReadLine());

            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Học bổng Xuất sắc (Mức 100%).");
            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                Console.WriteLine("Học bổng Khá/Giỏi (Mức 50%).");
            }
            else
            {
                Console.WriteLine("Không đạt học bổng.");
            }
        }

        static void ex12()
        {
            Console.Write("Nhập số ngày trễ hạn: ");
            int days = int.Parse(Console.ReadLine());//

            if (days <= 0)
            {
                Console.WriteLine("Trả sách đúng hạn. Không bị phạt.");
            }
            else if (days <= 3)
            {
                int fine = days * 5000;
                Console.WriteLine($"Phạt: {fine:N0} VNĐ");
            }
            else if (days <= 7)
            {
                int fine = days * 10000;
                Console.WriteLine($"Phạt: {fine:N0} VNĐ");
            }
            else
            {
                int fine = days * 20000;
                Console.WriteLine($"Phạt: {fine:N0} VNĐ - Khóa thẻ thư viện 30 ngày.");
            }
        }
        static void ex13()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập mức lương cơ bản (VNĐ): ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("Nhập tỷ lệ hoàn thành KPI (%): ");
            double kpi = double.Parse(Console.ReadLine());

            double bonus = 0;

            if (kpi < 80)
            {
                bonus = 0;
            }
            else if (kpi < 100)
            {
                bonus = baseSalary * 0.5;
            }
            else if (kpi <= 120)
            {
                bonus = baseSalary * 1.0;
            }
            else
            {
                bonus = baseSalary * 1.5;
            }

            Console.WriteLine($"Mức thưởng KPI nhận được: {bonus:N0} VNĐ");
        }

        static void ex14()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập tổng giá trị đơn hàng (VNĐ): ");
            double totalAmount = double.Parse(Console.ReadLine());

            Console.Write("Nhập mã voucher (WELCOME10, SUPERDEAL, FREESHIP): ");
            string voucher = Console.ReadLine()?.Trim().ToUpper();

            double discount = 0;

            switch (voucher)
            {
                case "WELCOME10":
                    discount = totalAmount * 0.10;
                    break;

                case "SUPERDEAL":
                    discount = totalAmount * 0.20;
                    // Giảm tối đa 100,000 VNĐ
                    if (discount > 100000)
                    {
                        discount = 100000;
                    }
                    break;

                case "FREESHIP":
                    discount = 30000;

                    if (discount > totalAmount)
                    {
                        discount = totalAmount;
                    }
                    break;

                default:
                    Console.WriteLine("Mã voucher không hợp lệ hoặc không áp dụng!");
                    break;
            }

            double finalAmount = totalAmount - discount;
            if (finalAmount < 0) finalAmount = 0;

            Console.WriteLine($"Số tiền được giảm: {discount:N0} VNĐ");
            Console.WriteLine($"Tổng tiền cần thanh toán: {finalAmount:N0} VNĐ");
        }
            
        public static void Main2( string[] args )
        {
            ex01();
            ex02();
            ex04();
            ex06();
            ex07();
            ex08();
            ex09();
            ex12();
            ex13();
            ex14();

        }
    }
}
