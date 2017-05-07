using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BUS
{
    public class DichVu_BUS
    {
        public static DataTable DichVu_getAll()
        {
            return DAL.DichVu_DAL.DichVu_getAll();
        }

        public static bool DichVu_add(DichVu dichvu)
        {
            return DAL.DichVu_DAL.DichVu_add(dichvu);
        }

        public static bool DichVu_update(DichVu dichvu)
        {
            return DAL.DichVu_DAL.DichVu_update(dichvu);
        }
    }
}
