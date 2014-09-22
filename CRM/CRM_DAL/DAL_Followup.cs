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
    public class DAL_Followup
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int Follwup_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_Followup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@EmployeeID", balfp.EmployeeID);
                cmd.Parameters.AddWithValue("@Followup_ID", balfp.Followup_ID);
                cmd.Parameters.AddWithValue("@FTitle", balfp.FTitle);
                cmd.Parameters.AddWithValue("@FiratName", balfp.FiratName);
                cmd.Parameters.AddWithValue("@LastName", balfp.LastName);
                cmd.Parameters.AddWithValue("@Date_Of_Birth", balfp.Date_Of_Birth);
                cmd.Parameters.AddWithValue("@Mobile_No", balfp.Mobile_No);
                cmd.Parameters.AddWithValue("@PhoneNo", balfp.PhoneNo);
                cmd.Parameters.AddWithValue("@SourceOfEnquiry", balfp.SourceOfEnquiry);
                cmd.Parameters.AddWithValue("@SourceEnquiryID", balfp.SourceOfEnquiryID);
                cmd.Parameters.AddWithValue("@Occupation", balfp.Occupation);
                cmd.Parameters.AddWithValue("@AnnualRevenue", balfp.AnnualRevenue);
                cmd.Parameters.AddWithValue("@Email_ID", balfp.Email_ID);
                cmd.Parameters.AddWithValue("@FaxNo", balfp.FaxNo);
                cmd.Parameters.AddWithValue("@Wbsite", balfp.Wbsite);
                cmd.Parameters.AddWithValue("@Street", balfp.Street);
                cmd.Parameters.AddWithValue("@City", balfp.City);
                cmd.Parameters.AddWithValue("@State", balfp.State);
                cmd.Parameters.AddWithValue("@ZipNo", balfp.ZipNo);
                cmd.Parameters.AddWithValue("@Country", balfp.Country);
                cmd.Parameters.AddWithValue("@Description", balfp.Description);
                cmd.Parameters.AddWithValue("@F_Date", balfp.F_Date);
                cmd.Parameters.AddWithValue("@S_Status", balfp.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", balfp.C_Date);
                cmd.Parameters.AddWithValue("@SystemPhotoPath", balfp.SystemPhotoPath);
                cmd.Parameters.AddWithValue("@AtualPhotoPath", balfp.AtualPhotoPath);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int UpadetFollwup_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_Followup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 2);
                cmd.Parameters.AddWithValue("@ID", balfp.ID);
                cmd.Parameters.AddWithValue("@EmployeeID", balfp.EmployeeID);
                cmd.Parameters.AddWithValue("@Followup_ID", balfp.Followup_ID);
                cmd.Parameters.AddWithValue("@FTitle", balfp.FTitle);
                cmd.Parameters.AddWithValue("@FiratName", balfp.FiratName);
                cmd.Parameters.AddWithValue("@LastName", balfp.LastName);
                cmd.Parameters.AddWithValue("@Date_Of_Birth", balfp.Date_Of_Birth);
                cmd.Parameters.AddWithValue("@Mobile_No", balfp.Mobile_No);
                cmd.Parameters.AddWithValue("@PhoneNo", balfp.PhoneNo);
                cmd.Parameters.AddWithValue("@SourceOfEnquiry", balfp.SourceOfEnquiry);
                cmd.Parameters.AddWithValue("@SourceEnquiryID", balfp.SourceOfEnquiryID);
                cmd.Parameters.AddWithValue("@Occupation", balfp.Occupation);
                cmd.Parameters.AddWithValue("@AnnualRevenue", balfp.AnnualRevenue);
                cmd.Parameters.AddWithValue("@Email_ID", balfp.Email_ID);
                cmd.Parameters.AddWithValue("@FaxNo", balfp.FaxNo);
                cmd.Parameters.AddWithValue("@Wbsite", balfp.Wbsite);
                cmd.Parameters.AddWithValue("@Street", balfp.Street);
                cmd.Parameters.AddWithValue("@City", balfp.City);
                cmd.Parameters.AddWithValue("@State", balfp.State);
                cmd.Parameters.AddWithValue("@ZipNo", balfp.ZipNo);
                cmd.Parameters.AddWithValue("@Country", balfp.Country);
                cmd.Parameters.AddWithValue("@Description", balfp.Description);
                cmd.Parameters.AddWithValue("@F_Date", balfp.F_Date);
                cmd.Parameters.AddWithValue("@S_Status", balfp.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", balfp.C_Date);
                cmd.Parameters.AddWithValue("@SystemPhotoPath", balfp.SystemPhotoPath);
                cmd.Parameters.AddWithValue("@AtualPhotoPath", balfp.AtualPhotoPath);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int AddFollwupPhoto_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupPhoto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", balfp.ID);
                cmd.Parameters.AddWithValue("@SystemPhotoPath", balfp.SystemPhotoPath);
                cmd.Parameters.AddWithValue("@AtualPhotoPath", balfp.AtualPhotoPath);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }


        public int FollwupProducts_Save_Insert_Update_Delete(BAL_FollowUp_Products balfproduct)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowUpProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@FolloupProductID", balfproduct.FolloupProductID);
                cmd.Parameters.AddWithValue("@FProductID", balfproduct.FProductID);
                cmd.Parameters.AddWithValue("@S_Status", balfproduct.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", balfproduct.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public string  i;
        
        public object View_Search_FollowupDetails(string TableName, string FirstName)
        {

            string q = "SELECT [ID],[FiratName] + ' ' + [LastName] AS [FolloupName],[Mobile_No],[Phone_No],[AnnualRevenue] " +
                       "FROM " + TableName + " " + 
                       "WHERE " ;
             if(FirstName != "")
             {
                 q = q + "[FiratName]LIKE ISNULL('" + FirstName + "',[FiratName]) + '%' AND " ;
             }
             q = q  + " [S_Status] = 'Active' ORDER BY [FiratName] ";
            
            con.Open();
            DataSet s = new DataSet();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
           // SqlDataReader dr = cmd.ExecuteReader();
            adp.Fill(s);
            //if (s.)
            //{
            //    //dr.Read();
            //    if (dr[0].ToString() != null)
            //    {
            //        i = dr[0].ToString ();
            //    }
            //    dr.Close();
            //}
            con.Close();
            return (s);
        }

        public int DeleteFollwupCommentsNotes_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupCommentsNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", balfp.CommentsID);
                int i = cmd.ExecuteNonQuery();
                return i;


            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int DeleteFollwupAddProductsDelete_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupAddProductsDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", balfp.FProductID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int DeleteFollwupActivityDelete_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupActivityDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", balfp.ActivityID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int FollwupAddCampaign_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupAddCamapign", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@FollowupID", balfp.FollowUPID1);
                cmd.Parameters.AddWithValue("@CampaignID", balfp.CampaignID);
                cmd.Parameters.AddWithValue("@S_Status", balfp.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", balfp.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int DeleteFollwupCamapign_Save_Insert_Update_Delete(BAL_Followup balfp)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_FollowupCampaignDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", balfp.ID);
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
