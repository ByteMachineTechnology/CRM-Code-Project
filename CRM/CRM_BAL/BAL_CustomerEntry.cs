using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM_BAL
{
    public class BAL_CustomerEntry
    {
        public int Flag { get; set; }
        //public string Cust_ID { get; set; }
        public int EmployeeID { get; set; }
        public string Cust_ID { get; set; }
        public string CustTitle { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Date_Of_Birth { get; set; }

        public string Occupation { get; set; }

        public string Mobile_No { get; set; }

        public string PhoneNo { get; set; }

        public string Email_ID { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipNo { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string SourceOfEnquiry { get; set; }

        public int SourceEnquiryID { get; set; }
        public string CustSystemPhotoPath { get; set; }
        public string CustActualPhotoPath { get; set; }
        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
