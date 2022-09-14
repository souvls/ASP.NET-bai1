using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    internal class SinhVienVan : SinhVien
    {
        double coDien, hienDai;

        public override double dtb()
        {
            return (coDien + hienDai) / 2;
        }
        public SinhVienVan(string name, string sex, string dob, double classic, double modern) : base(name, sex, dob)
        {
            this.coDien = classic;
            this.hienDai = modern;
        }
    }
}
