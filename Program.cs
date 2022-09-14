using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];

            //nhap sinh vien
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", i + 1);

                Console.Write("\tHo ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("\tGioi Tinh [1]nam [0]nu: ");
                string gioitinh = Console.ReadLine();

                Console.Write("\tNgay Sinh: ");
                string ngaysinh = Console.ReadLine();

                Console.Write("\tChuyen nganh cua sinh vien [1]van [2]CNTT [any key]vatly: ");
                char k = char.Parse(Console.ReadLine());

                switch (k)
                {
                    case '1':
                        #region Nhap diem cho sinh vien van

                        Console.Write("\t\tNhap diem co dien: ");
                        double codien = double.Parse(Console.ReadLine());

                        Console.Write("\t\tNhap diem hien dai: ");
                        double hiendai = double.Parse(Console.ReadLine());

                        sv[i] = new SinhVienVan(hoTen, gioitinh, ngaysinh, codien, hiendai);

                        #endregion
                        break;
                    case '2':
                        #region Nhap diem cho sinh vien CNTT

                        Console.Write("\t\tNhap diem Csharp: ");
                        double c = double.Parse(Console.ReadLine());

                        Console.Write("\t\tNhap diem pascal: ");
                        double ps = double.Parse(Console.ReadLine());

                        Console.Write("\t\tNhap diem sql: ");
                        double sql = double.Parse(Console.ReadLine());

                        sv[i] = new SinhVienCNTT(hoTen, gioitinh, ngaysinh, c, ps, sql);

                        #endregion
                        break;
                }
            }
            //in danh sach dtb lon hon 5
            Console.WriteLine("==>Diem trung binh lon hon 5");
            for (int i = 0; i < sv.Length; i++)
            {

                if (sv[i].dtb() >= 5)
                {
                    Console.WriteLine(sv[i].ToString());
                }  
            }

            //Tim sinh viem
            Console.WriteLine("==>Nhap ho ten Sinh vien Can tim");
            string a = Console.ReadLine();
            for(int i = 0; i < sv.Length; i++)
            {
                if (sv[i].getTen() == a)
                {
                    Console.WriteLine(sv[i].ToString());
                }
            }

        }       
           
    }
}
