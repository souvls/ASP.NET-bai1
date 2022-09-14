using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    internal class SinhVien
    {
        string hoten;
        bool gioiTinh = true;
        DateTime ngaySinh;

        public SinhVien(string name, string sex, DateTime dob) { }
        public SinhVien(string name, string sex, string dob)
        {
            this.hoten = name;
            sex = sex.Trim().ToUpper();
            this.gioiTinh = (sex == "NAM" || sex == "MALE" || sex == "1");
            try
            {
                this.ngaySinh = DateTime.Parse(dob); 
            }catch (Exception ex)
            {
                this.ngaySinh = DateTime.Today;
            }
        }
        public virtual double dtb()
        {
            return -10;
        }
        public string getTen()
        {
            return this.hoten;
        }
        public override string ToString()
        {
            return string.Format("{0, 30} {1:0.00}", this.hoten, this.dtb());
        }
    }
}
