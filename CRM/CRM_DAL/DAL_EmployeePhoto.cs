using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CRM_BAL;

namespace CRM_DAL
{
    public class DAL_EmployeePhoto
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        //CRM_EmployeePhoto bempPhoto = new CRM_EmployeePhoto();

        public int EmployeePhoto_Insert_Update_Delete(CRM_EmployeePhoto bempphoto)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_EmployeePhoto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@EmployeeID", bempphoto.EmployeeID);
                cmd.Parameters.AddWithValue("@PhotoPath", bempphoto.PhotoPath);
                cmd.Parameters.AddWithValue("@EmpPhoto", bempphoto.EmpPhoto);
                cmd.Parameters.AddWithValue("@S_Status", bempphoto.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bempphoto.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
