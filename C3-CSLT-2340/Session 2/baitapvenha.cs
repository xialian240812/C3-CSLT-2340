using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

namespace C3_CSLT_2340.Session_2
{
    internal class baitapvenha
    {
        static void ex01()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            int chiSoDienCu = int.Parse(Console.ReadLine());//

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            int chiSoDienMoi = int.Parse(Console.ReadLine());//

            if (chiSoDienMoi < chiSoDienCu)
            {
                Console.WriteLine("LỖI: Chỉ số điện mới phải >= Chỉ số điện cũ");
                return;
            }
            int luongDienTieuThu = chiSoDienMoi - chiSoDienCu;

            decimal bac1 = 1806m;
            decimal bac2 = 1866m;
            decimal bac3 = 2167m;
            decimal bac4 = 2729m;
            decimal bac5 = 3050m;

            decimal tienDienChuaThue = 0m;
            int soDienConLai = luongDienTieuThu;

            int dienBac1 = Math.Min(soDienConLai, 50);
            tienDienChuaThue += dienBac1 * bac1;
            soDienConLai -= dienBac1;

            int dienBac2 = Math.Min(soDienConLai, 51);
            tienDienChuaThue += dienBac2 * bac2;
            soDienConLai -= dienBac2;

            int dienBac3 = Math.Min(soDienConLai, 101);
            tienDienChuaThue += dienBac3 * bac3;
            soDienConLai -= dienBac3;

            int dienBac4 = Math.Min(soDienConLai, 201);
            tienDienChuaThue += dienBac4 * bac4;
            soDienConLai -= dienBac4;

            if (soDienConLai > 0)
            {
                tienDienChuaThue += soDienConLai * bac5;
            }
            decimal thueVAT = Math.Round(tienDienChuaThue * 0.08m, 0);
            decimal tongTien = Math.Round(tienDienChuaThue + thueVAT, 0);

            Console.WriteLine("----- HÓA ĐƠN TIỀN ĐIỆN -----");
            Console.WriteLine("Số điện tiêu thụ: {0} kWh", luongDienTieuThu);
            Console.WriteLine("Tiền điện chưa thuế: {0:#,##0} VNĐ", tienDienChuaThue);
            Console.WriteLine("Thuế VAT (8%): {0:#,##0} VNĐ", thueVAT);
            Console.WriteLine("Tổng thanh toán: {0:#,##0} VNĐ", tongTien);
        }
        static void ex02()
        {
            Console.Write("Chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());//

            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());//

            double BMI = canNang / Math.Pow(chieuCao, 2);

            string phanLoai;
            if (BMI < 18.5)
                phanLoai = "Gầy (Thiếu cân)";
            else if (BMI < 23.0)
                phanLoai = "Bình Thường (Lý tưởng)";
            else if (BMI < 25.0)
                phanLoai = "Thừa cân (Tiền béo phì)";
            if (BMI >= 25.0)
                phanLoai = "Béo phì";

            double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);

            Console.WriteLine("----- KẾT QUẢ THEO DÕI SỨC KHỎE -----");
            Console.WriteLine("Chỉ số BMI của bạn: {0:F2}, BMI");
            Console.WriteLine("Phân loại sức khỏe: {0}, phanLoai");
            Console.WriteLine("Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {0:F2} kg đến {1:F2} kg.", canNangToiThieu, canNangToiDa);
        }
        static void ex04()
        {
            Console.Write("Nhập vào ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                DateTime today = DateTime.Now.Date;

                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;

                TimeSpan livedDays = today - birthDate;

                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
                if (nextBirthday < today)
                    nextBirthday = nextBirthday.AddYears(1);
                TimeSpan daysUntilBirthday = nextBirthday - today;

                Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
                Console.WriteLine($"Bạn đã sống tổng cộng: {livedDays.TotalDays:N0} ngày");
                Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilBirthday.Days} ngày nữa");
            }
            else
            {
                Console.WriteLine("Định dạng ngày sinh không hợp lệ.Vui lòng nhập theo dd / MM / yyyy.");
            }
        }
        static void ex06()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập học tên thô: ");
            string rawInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(rawInput))
            {
                Console.WriteLine("Họ tên không được để trống!");
                return;
            }
            string[] words = rawInput.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }
            string fullName = string.Join("", words);
            string ho = words[0];
            string ten = words[words.Length - 1];
            string tenDem = "";

            if (words.Length > 2)
            {
                string[] tenDemArray = new string[words.Length - 2];
                Array.Copy(words, 1, tenDemArray, 0, words.Length - 2);
                tenDem = string.Join("", tenDemArray);
            }
            else if (words.Length == 2)
            {
                tenDem = "(không có)";
            }
            string tenKhongDau = BoDauTiengViet(ten).ToLower();
            string hoVaTenDem = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                hoVaTenDem += BoDauTiengViet(words[i]).ToLower();
            }
            string username = $"{tenKhongDau}.{hoVaTenDem}";
            string email = $"{username}@company.edu.vn";

            Console.WriteLine("\n----- OUTPUT -----");
            Console.WriteLine($"Họ tên chuẩn hóa: {fullName}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");

            Console.ReadKey();

            static string BoDauTiengViet(string text)
            {
                string normalized = text.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();

                foreach (char c in normalized)
                {
                    System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                    if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString().Normalize(NormalizationForm.FormC).Replace("đ", "d").Replace("Đ", "D");
            }
        }
        static void ex07()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("--- INPUT ---");
            Console.Write("Quãng đường (km): ");
            double quangDuong = double.Parse(Console.ReadLine());

            Console.Write("Mức tiêu hao (L/100km): ");
            double mucTieuHao = double.Parse(Console.ReadLine());

            Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());

            Console.Write("Số người đi: ");
            int soNguoi = int.Parse(Console.ReadLine());

            double tongLitXang = (quangDuong / 100) * mucTieuHao;

            decimal tongChiPhi = (decimal)tongLitXang * giaXang;

            decimal chiPhiThucTeMoiNguoi = tongChiPhi / soNguoi;

            decimal chiPhiMoiNguoiLamTron = Math.Ceiling(chiPhiThucTeMoiNguoi / 1000m) * 1000m;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongLitXang:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoiLamTron:N0} VNĐ");

            Console.ReadKey();
        }
        static void ex08()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string otpChuan = "839201";
            DateTime creationTime = DateTime.Now; // Thời điểm phát hành OTP

            Console.WriteLine("=== HỆ THỐNG XÁC THỰC OTP NGÂN HÀNG ===");
            Console.WriteLine($"[Hệ thống] Mã OTP đã gửi: {otpChuan}");
            Console.WriteLine($"[Hệ thống] Thời gian tạo: {creationTime:HH:mm:ss}\n");

            Console.WriteLine("--- INPUT ---");
            Console.Write("Mã OTP nhận được: ");
            string inputOtp = Console.ReadLine();

            Console.Write("Nhập số phút trôi qua: ");
            int minutessPassed = int.Parse(Console.ReadLine());

            Console.Write("Nhập số giây trôi qua: ");
            int secondsPassed = int.Parse(Console.ReadLine());

            TimeSpan timeDifference = new TimeSpan(0, 0, minutessPassed, secondsPassed);
            DateTime confirmTime = creationTime.Add(timeDifference);

            Console.WriteLine("\n--- OUTPUT ---");

            bool isSixDigits = inputOtp.Length == 6 && int.TryParse(inputOtp, out _);
            if (!isSixDigits)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Định dạng OTP không hợp lệ (Phải đủ 6 chữ số).");
                Console.ReadKey();
                return;
            }

            double totalSeconds = (confirmTime - creationTime).TotalSeconds;
            if (totalSeconds > 300)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Mã OTP đã hết hạn (Quá 5 phút).");
                Console.ReadKey();
                return;
            }

            if (inputOtp != otpChuan)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Mã OTP không chính xác.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");

            Console.ReadKey();
        }
        static void ex09()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("--- INPUT ---");
            Console.Write("Lương Gross (VNĐ): ");
            decimal luongGross = decimal.Parse(Console.ReadLine());

            Console.Write("Số người phụ thuộc: ");
            int soNguoiPhuThuoc = int.Parse(Console.ReadLine());

            decimal bhxh = luongGross * 0.08m;
            decimal bhyt = luongGross * 0.015m;
            decimal bhtn = luongGross * 0.01m;
            decimal tongBaoHiem = bhxh + bhyt + bhtn;

            decimal mucGiamTruBanThan = 11000000m;
            decimal mucGiamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;

            decimal thuNhapChiuThue = luongGross - tongBaoHiem - mucGiamTruBanThan - mucGiamTruPhuThuoc;

            if (thuNhapChiuThue < 0m)
            {
                thuNhapChiuThue = 0m;
            }
            decimal thueTNCN = TinhThueLuyTien(thuNhapChiuThue);
            decimal luongNet = luongGross - tongBaoHiem - thueTNCN;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {tongBaoHiem:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0} VNĐ");
            Console.ReadKey();

            static decimal TinhThueLuyTien(decimal tnct)
            {
                if (tnct <= 0m) return 0m;

                decimal thue = 0m;

                // Bậc 1: Đến 5 triệu (5%)
                if (tnct > 5000000m)
                {
                    thue += 5000000m * 0.05m;
                }
                else
                {
                    return thue + (tnct * 0.05m);
                }

                // Bậc 2: Trên 5 triệu đến 10 triệu (10%)
                if (tnct > 10000000m)
                {
                    thue += 5000000m * 0.10m;
                }
                else
                {
                    return thue + ((tnct - 5000000m) * 0.10m);
                }

                // Bậc 3: Trên 10 triệu đến 18 triệu (15%)
                if (tnct > 18000000m)
                {
                    thue += 8000000m * 0.15m;
                }
                else
                {
                    return thue + ((tnct - 10000000m) * 0.15m);
                }

                // Bậc 4: Trên 18 triệu đến 32 triệu (20%)
                if (tnct > 32000000m)
                {
                    thue += 14000000m * 0.20m;
                }
                else
                {
                    return thue + ((tnct - 18000000m) * 0.20m);
                }

                // Bậc 5: Trên 32 triệu đến 52 triệu (25%)
                if (tnct > 52000000m)
                {
                    thue += 20000000m * 0.25m;
                }
                else
                {
                    return thue + ((tnct - 32000000m) * 0.25m);
                }

                // Bậc 6: Trên 52 triệu đến 80 triệu (30%)
                if (tnct > 80000000m)
                {
                    thue += 28000000m * 0.30m;
                    // Bậc 7: Trên 80 triệu (35%)
                    thue += (tnct - 80000000m) * 0.35m;
                }
                else
                {
                    return thue + ((tnct - 52000000m) * 0.30m);
                }

                return thue;
            }
        }
        static void ex011()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("--- INPUT ---");
            Console.Write("Số tiền gửi ban đầu (VNĐ): ");
            decimal P = decimal.Parse(Console.ReadLine());

            Console.Write("Lãi suất năm (%/năm): ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Thời gian gửi (tháng): ");
            int n = int.Parse(Console.ReadLine());

            decimal tienLaiDon = P * (decimal)(r / 100) * (decimal)(n / 12.0);

            double pDouble = (double)P;
            double rThang = (r / 100) / 12;

            double tongTienCompoundDouble = pDouble * Math.Pow(1 + rThang, n);

            decimal tongTienCompound = (decimal)tongTienCompoundDouble;
            decimal tienLaiKep = tongTienCompound - P;

            decimal chenhLech = tienLaiKep - tienLaiDon;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {tienLaiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {tienLaiKep:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {chenhLech:N0} VNĐ (Lãi kép tối ưu hơn)");

            Console.ReadKey();
        }
        enum VehicleType
        {
            Motorbike = 1,
            Car = 2,
            Truck = 3
        }
        static void ex012()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("--- INPUT ---");
            Console.Write("Văn bản gốc: ");
            string originalText = Console.ReadLine();

            Console.Write("Khóa dịch chuyển (Shift Key k): ");
            int k = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(originalText, k);
            string decryptedText = Decrypt(encryptedText, k);

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Văn bản Mã hóa: {encryptedText}");
            Console.WriteLine($"Văn bản Giải mã: {decryptedText}");

            Console.ReadKey();
        }
        static string Encrypt(string input, int key)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                // Chữ cái in hoa ('A'-'Z')
                if (c >= 'A' && c <= 'Z')
                {
                    buffer[i] = (char)('A' + (c - 'A' + key) % 26);
                }
                // Chữ cái in thường ('a'-'z')
                else if (c >= 'a' && c <= 'z')
                {
                    buffer[i] = (char)('a' + (c - 'a' + key) % 26);
                }
                // Ký tự đặc biệt, chữ số, khoảng trắng giữ nguyên
            }

            return new string(buffer);
        }
        static string Decrypt(string input, int key)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                // Chữ cái in hoa ('A'-'Z')
                if (c >= 'A' && c <= 'Z')
                {
                    // Cộng 26 trước khi chia lấy dư để tránh số âm
                    buffer[i] = (char)('A' + (c - 'A' - key + 26) % 26);
                }
                // Chữ cái in thường ('a'-'z')
                else if (c >= 'a' && c <= 'z')
                {
                    buffer[i] = (char)('a' + (c - 'a' - key + 26) % 26);
                }
            }

            return new string(buffer);
        }
        static void ex014()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("--- INPUT ---");
            Console.Write("Nhập chuỗi số: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("\n--- OUTPUT ---");
                Console.WriteLine("Lỗi: Chuỗi nhập vào không phải là số nguyên int32 hợp lệ hoặc vượt quá phạm vi lưu trữ!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {number}");

            bool fitByte = number >= byte.MinValue && number <= byte.MaxValue;
            bool fitShort = number >= short.MinValue && number <= short.MaxValue;

            Console.WriteLine($"Phù hợp kiểu byte: {(fitByte ? "CÓ (Vừa vặn trong dải 0-255)" : "KHÔNG")}");
            Console.WriteLine($"Phù hợp kiểu short: {(fitShort ? "CÓ (Vừa vặn trong dải -32,768 đến 32,767)" : "KHÔNG")}");

            int temp = Math.Abs(number);
            int sumDigits = 0;
            string strNumber = temp.ToString();
            string detailSum = "";

            for (int i = 0; i < strNumber.Length; i++)
            {
                int digit = strNumber[i] - '0';
                sumDigits += digit;
                detailSum += (i == 0) ? digit.ToString() : $" + {digit}";
            }

            Console.WriteLine($"Tổng các chữ số: {detailSum} = {sumDigits}");
            try
            {
                checked
                {
                    // Thực hiện nhân bình phương số đó để thử nghiệm tràn số int32
                    int square = number * number;
                    Console.WriteLine($"Kiểm tra Tràn số: An toàn trong phạm vi int32 (Bình phương = {square}).");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiểm tra Tràn số: PHÁT HIỆN TRÀN SỐ! Giá trị vượt quá phạm vi của int32 khi tính toán.");
            }

            Console.ReadKey();
        }
        public static void Main1(string[] args)
        {
            ex01();
            ex02();
            ex04();
            ex06();
            ex07();
            ex08();
            ex09();
            ex011();
            ex012();
            ex014();
        }
    }
}


