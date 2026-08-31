using System;
using System.Collections.Generic;
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

        public static void Main(string[] args)
        {
            ex01();
            ex02();
        }
    }
}

