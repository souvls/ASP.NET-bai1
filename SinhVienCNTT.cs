using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    internal class SinhVienCNTT:SinhVien
    {
        double csharp, pascal, sql;



        public override double dtb()
        {
            return (csharp + pascal + sql) / 3;
        }
        public SinhVienCNTT(string name, string sex, string dob, double csharp, double pascal, double sql) : base(name, sex, dob)
        {
            this.csharp = csharp;
            this.pascal = pascal;
            this.sql = sql;
        }
    }
}
