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
    public class DAL_CustomerEntry
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int Customer_Save_Insert_Update_Delete(BAL_CustomerEntry bcustomer)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@EmployeeID", bcustomer.EmployeeID);
                cmd.Parameters.AddWithValue("@Cust_ID", bcustomer.Cust_ID);
                cmd.Parameters.AddWithValue("@CustTitle", bcustomer.CustTitle);
                cmd.Parameters.AddWithValue("@FirstName", bcustomer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", bcustomer.LastName);
                cmd.Parameters.AddWithValue("@Date_Of_Birth",bcustomer.Date_Of_Birth);
                cmd.Parameters.AddWithValue("@Occupation", bcustomer.Occupation);
                cmd.Parameters.AddWithValue("@Mobile_No", bcustomer.Mobile_No);
                cmd.Parameters.AddWithValue("@PhoneNo", bcustomer.PhoneNo);
                cmd.Parameters.AddWithValue("@Email_ID", bcustomer.Email_ID);
                cmd.Parameters.AddWithValue("@Address", bcustomer.Address);
                cmd.Parameters.AddWithValue("@City", bcustomer.City);
                cmd.Parameters.AddWithValue("@ZipNo", bcustomer.ZipNo);
                cmd.Parameters.AddWithValue("@State", bcustomer.State);
                cmd.Parameters.AddWithValue("@Country", bcustomer.Country);
                cmd.Parameters.AddWithValue("@SourceOfEnquiry", bcustomer.SourceOfEnquiry);
                cmd.Parameters.AddWithValue("@SourceEnquiryID", bcustomer.SourceEnquiryID);
                cmd.Parameters.AddWithValue("@CustSystemPhotoPath", bcustomer.CustSystemPhotoPath);
                cmd.Parameters.AddWithValue("@CustActualPhotoPath", bcustomer.CustActualPhotoPath);
                cmd.Parameters.AddWithValue("@S_Status", bcustomer.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcustomer.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }
    }
}
