using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DichVu
    {
        private Int32 madv;
        private String tendv;
        private Int32 soluong;
        private Double gia;

        public Int32 Madv
        {
            get
            {
                return madv;
            }

            set
            {
                madv = value;
            }
        }

        public String Tendv
        {
            get
            {
                return tendv;
            }

            set
            {
                tendv = value;
            }
        }

        public Int32 Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public Double Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public DichVu(Int32 ma, String ten, Int32 sl, Double gia)
        {
            this.Madv = ma;
            this.Tendv = ten;
            this.Soluong = sl;
            this.Gia = gia;
        }


        public DichVu( String ten, Int32 sl, Double gia)
        {
            this.Tendv = ten;
            this.Soluong = sl;
            this.Gia = gia;
        }
    }
}
