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
    public class DAL_ContactCustomer
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int ContactCustomer_Save_Insert_Update_Delete(BAL_ContactCustomer bcontcustomer)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@EmployeeID", bcontcustomer.EmployeeID);
                cmd.Parameters.AddWithValue("@ContactCustID", bcontcustomer.ContactID);
                cmd.Parameters.AddWithValue("@CTitle", bcontcustomer.CTitle);
                cmd.Parameters.AddWithValue("@FirstName", bcontcustomer.FiratName);
                cmd.Parameters.AddWithValue("@LastName", bcontcustomer.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", bcontcustomer.DateOfBirth);
                cmd.Parameters.AddWithValue("@MobileNo", bcontcustomer.MobileNo);
                cmd.Parameters.AddWithValue("@PhoneNo", bcontcustomer.PhoneNo);
                cmd.Parameters.AddWithValue("@SourceOfEnquiry", bcontcustomer.SourceOfEnquiry);
                cmd.Parameters.AddWithValue("@SourceEnquiryID", bcontcustomer.SourceOfEnquiryID);
                cmd.Parameters.AddWithValue("@Occupation", bcontcustomer.Occupation);
                cmd.Parameters.AddWithValue("@EmailID", bcontcustomer.EmailID);
                cmd.Parameters.AddWithValue("@FaxNo", bcontcustomer.FaxNo);
                cmd.Parameters.AddWithValue("@Website", bcontcustomer.Wbsite);
                cmd.Parameters.AddWithValue("@MailingStreet", bcontcustomer.MailingStreet);
                cmd.Parameters.AddWithValue("@MailingCity", bcontcustomer.MailingCity);
                cmd.Parameters.AddWithValue("@MailingState", bcontcustomer.MailingState);
                cmd.Parameters.AddWithValue("@MailingZip", bcontcustomer.MailingZipNo);
                cmd.Parameters.AddWithValue("@MailingCountry", bcontcustomer.MailingCountry);
                cmd.Parameters.AddWithValue("@OtherStreet", bcontcustomer.OtherStreet);
                cmd.Parameters.AddWithValue("@OtherCity", bcontcustomer.OtherCity);
                cmd.Parameters.AddWithValue("@OtherState", bcontcustomer.OtherState);
                cmd.Parameters.AddWithValue("@OtherZip", bcontcustomer.OtherZipNo);
                cmd.Parameters.AddWithValue("@OtherCountry", bcontcustomer.OtherCountry);
                cmd.Parameters.AddWithValue("@Description", bcontcustomer.Description);
                cmd.Parameters.AddWithValue("@CustomerSystemPhotoPath", bcontcustomer.CustomerSystemPhotoPath);
                cmd.Parameters.AddWithValue("@CustomerActualPhotoPath", bcontcustomer.CustomerActualPhotoPath);
                cmd.Parameters.AddWithValue("@S_Status", bcontcustomer.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontcustomer.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int ContactDetailsDelete_Save_Insert_Update_Delete(BAL_ContactCustomer bcontdetdelete)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactDetailsDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontdetdelete.ID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int UpdateContactCustomer_Save_Insert_Update_Delete(BAL_ContactCustomer bcontcustomer)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 2);
                cmd.Parameters.AddWithValue("@ID", bcontcustomer.ID);
                cmd.Parameters.AddWithValue("@EmployeeID", bcontcustomer.EmployeeID);
                cmd.Parameters.AddWithValue("@ContactCustID", bcontcustomer.ContactID);
                cmd.Parameters.AddWithValue("@CTitle", bcontcustomer.CTitle);
                cmd.Parameters.AddWithValue("@FirstName", bcontcustomer.FiratName);
                cmd.Parameters.AddWithValue("@LastName", bcontcustomer.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", bcontcustomer.DateOfBirth);
                cmd.Parameters.AddWithValue("@MobileNo", bcontcustomer.MobileNo);
                cmd.Parameters.AddWithValue("@PhoneNo", bcontcustomer.PhoneNo);
                cmd.Parameters.AddWithValue("@SourceOfEnquiry", bcontcustomer.SourceOfEnquiry);
                cmd.Parameters.AddWithValue("@SourceEnquiryID", bcontcustomer.SourceOfEnquiryID);
                cmd.Parameters.AddWithValue("@Occupation", bcontcustomer.Occupation);
                cmd.Parameters.AddWithValue("@EmailID", bcontcustomer.EmailID);
                cmd.Parameters.AddWithValue("@FaxNo", bcontcustomer.FaxNo);
                cmd.Parameters.AddWithValue("@Website", bcontcustomer.Wbsite);
                cmd.Parameters.AddWithValue("@MailingStreet", bcontcustomer.MailingStreet);
                cmd.Parameters.AddWithValue("@MailingCity", bcontcustomer.MailingCity);
                cmd.Parameters.AddWithValue("@MailingState", bcontcustomer.MailingState);
                cmd.Parameters.AddWithValue("@MailingZip", bcontcustomer.MailingZipNo);
                cmd.Parameters.AddWithValue("@MailingCountry", bcontcustomer.MailingCountry);
                cmd.Parameters.AddWithValue("@OtherStreet", bcontcustomer.OtherStreet);
                cmd.Parameters.AddWithValue("@OtherCity", bcontcustomer.OtherCity);
                cmd.Parameters.AddWithValue("@OtherState", bcontcustomer.OtherState);
                cmd.Parameters.AddWithValue("@OtherZip", bcontcustomer.OtherZipNo);
                cmd.Parameters.AddWithValue("@OtherCountry", bcontcustomer.OtherCountry);
                cmd.Parameters.AddWithValue("@Description", bcontcustomer.Description);
                cmd.Parameters.AddWithValue("@CustomerSystemPhotoPath", bcontcustomer.CustomerSystemPhotoPath);
                cmd.Parameters.AddWithValue("@CustomerActualPhotoPath", bcontcustomer.CustomerActualPhotoPath);
                cmd.Parameters.AddWithValue("@S_Status", bcontcustomer.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontcustomer.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int ContactCustomerNotes_Save_Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomerNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ContactCustomerID", bcontnotes.ContactCustomerID);
                cmd.Parameters.AddWithValue("@Notes", bcontnotes.ContactNotes);
                cmd.Parameters.AddWithValue("@S_Status", bcontnotes.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontnotes.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        public int ContactCustomerDelete_Notes_Save_Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomerNotesDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontnotes.ID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        public int ContactCustomerActivity_Save_Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomerActivity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ContactCustomerID", bcontnotes.ContactCustomerID);
                cmd.Parameters.AddWithValue("@Subject", bcontnotes.Subject);
                cmd.Parameters.AddWithValue("@CDate", bcontnotes.SubjectDate);
                cmd.Parameters.AddWithValue("@EmployeeID", bcontnotes.EmployeeID);
                cmd.Parameters.AddWithValue("@Notes", bcontnotes.ContactNotes);
                cmd.Parameters.AddWithValue("@S_Status", bcontnotes.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontnotes.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }


        public int ContactCustomerActivityDelete_Save_Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomerActivityDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontnotes.ID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        public int ContactCustomerCampaign_Save_Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCustomerCampaign", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ContactCustomerID", bcontnotes.ContactCustomerID);
                cmd.Parameters.AddWithValue("@CampaignID", bcontnotes.CampaignID);
                cmd.Parameters.AddWithValue("@S_Status", bcontnotes.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontnotes.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {
                throw;
            }
            finally { con.Close(); }
        }

        public int DeleteContactCampaign__Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCampaignDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontnotes.ID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int UpdateContactCustomerPhotoPath_Save_Insert_Update_Delete(BAL_ContactCustomer bcontcustomer)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ConatactCustomerPhoto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontcustomer.ID);
                cmd.Parameters.AddWithValue("@CustomerSystemPhotoPath", bcontcustomer.CustomerSystemPhotoPath);
                cmd.Parameters.AddWithValue("@CustomerActualPhotoPath", bcontcustomer.CustomerActualPhotoPath);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int CreateContactCampaign_Save_Insert_Update_Delete(BAL_ContactCustomer bcontcustomer)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_CreateCampaignContacts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@CampaignID", bcontcustomer.CCampaignID);
                cmd.Parameters.AddWithValue("@ContactCustID", bcontcustomer.ContactCustomerID);
                cmd.Parameters.AddWithValue("@Status", bcontcustomer.Status);
                cmd.Parameters.AddWithValue("@S_Status", bcontcustomer.S_Status);
                cmd.Parameters.AddWithValue("@C_Date", bcontcustomer.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        public int DeleteCreateContactCampaign__Insert_Update_Delete(BAL_ContactCustomer bcontnotes)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_ContactCampaignContactsDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@ID", bcontnotes.ID);
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
