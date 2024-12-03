using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace ThreeTierArch.DAL
{
    internal class EmployeeDal
    {
        public string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
        SqlConnection scon = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable Read()
        {
            scon.ConnectionString = c;
            if (ConnectionState.Closed == scon.State)
                scon.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_empl", scon);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
            
        }
        public DataTable Read(Int16 Id)
        {
            scon.ConnectionString = c;
            if (ConnectionState.Closed == scon.State)
                scon.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_empl where empl_id= " + Id + "", scon);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

    }
}
