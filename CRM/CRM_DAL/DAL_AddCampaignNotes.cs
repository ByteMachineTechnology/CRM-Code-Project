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
    public class DAL_AddCampaignNotes
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int AddCampainsNotes_Insert_Update_Delete(BAL_AddCampaignNotes baddcampnots)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_CampaignNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@CampaignId", baddcampnots.CampaignId);
                cmd.Parameters.AddWithValue("@CampaignNotes", baddcampnots.CampaignNotes);
                cmd.Parameters.AddWithValue("@S_Status", baddcampnots.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", baddcampnots.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int CampaignNotes_Insert_Update_Delete(BAL_AddCampaignNotes baddcmpdel)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_CampaignNotesDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", baddcmpdel.Id);
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
