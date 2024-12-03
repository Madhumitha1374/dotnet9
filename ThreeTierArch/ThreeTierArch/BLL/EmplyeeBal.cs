using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTierArch.DAL;

namespace ThreeTierArch.BLL
{
    internal class EmplyeeBal
    {
        public DataTable GetEmployees()
        {
            try
            {
                EmployeeDal objdal = new EmployeeDal();
                return objdal.Read();
            }
            catch
            {
                throw;
            }
        }
        public DataTable GetEmployees(Int16 ID)
        {
            try
            {
                EmployeeDal objdal = new EmployeeDal();
                return objdal.Read(ID);
            }
            catch
            {
                throw;
            }
        }
    }
}
