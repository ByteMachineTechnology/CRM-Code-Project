using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BAL
{
    public class BAL_ContactCustomer
    {
        public int Flag { get; set; }
        //public string Cust_ID { get; set; }

        public int ID { get; set; }

        public int EmployeeID { get; set; }

        public string ContactID { get; set; }

        public string CTitle { get; set; }

        public string FiratName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string MobileNo { get; set; }

        public string PhoneNo { get; set; }

        public string SourceOfEnquiry { get; set; }

        public int SourceOfEnquiryID { get; set; }

        public string Occupation { get; set; }

        public string EmailID { get; set; }

        public string FaxNo { get; set; }

        public string Wbsite { get; set; }

        public string MailingStreet { get; set; }

        public string MailingCity { get; set; }

        public string MailingState { get; set; }

        public string OtherStreet { get; set; }

        public string OtherCity { get; set; }

        public string OtherState { get; set; }

        public string MailingZipNo { get; set; }

        public string OtherZipNo { get; set; }

        public string MailingCountry { get; set; }

        public string OtherCountry { get; set; }

        public string Description { get; set; }

        public string CustomerSystemPhotoPath { get; set; }

        public string CustomerActualPhotoPath { get; set; }

        //contact customer notes
        public int ContactCustomerID { get; set; }

        public string ContactNotes { get; set; }

        //contact activity
        public string Subject { get; set; }

        public string SubjectDate { get; set; }
        
        //contact campaign
        public int CampaignID { get; set; }

        //create contact campaign
        public int CCampaignID { get; set; }

        public string Status { get; set; }

        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
