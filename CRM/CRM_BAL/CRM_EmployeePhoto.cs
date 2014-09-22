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
    public class CRM_EmployeePhoto
    {
        public int Flag { get; set; }

        public int EmployeeID { get; set; }

        public string PhotoPath { get; set; }

        public byte[] EmpPhoto { get; set; }

        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
