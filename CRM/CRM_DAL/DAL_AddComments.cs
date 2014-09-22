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
     public class DAL_AddComments
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int AddComments_Insert_Update_Delete(BAL_AddComments baddcomments)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_AddComments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@FollowupId", baddcomments.FollowupId);
                cmd.Parameters.AddWithValue("@Comments", baddcomments.Comments);
                cmd.Parameters.AddWithValue("@S_Status", baddcomments.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", baddcomments.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int AddActivity_Insert_Update_Delete(BAL_AddComments baddcomments)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_AddActivity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@FollowupId", baddcomments.FollowupId);
                cmd.Parameters.AddWithValue("@ASubject", baddcomments.ASubject);
                cmd.Parameters.AddWithValue("@ADate", baddcomments.ADate);
                cmd.Parameters.AddWithValue("@AEmployeeID", baddcomments.AEmployeeID);
                cmd.Parameters.AddWithValue("@ANotes", baddcomments.ANotes);
                cmd.Parameters.AddWithValue("@S_Status", baddcomments.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", baddcomments.C_Date);
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
