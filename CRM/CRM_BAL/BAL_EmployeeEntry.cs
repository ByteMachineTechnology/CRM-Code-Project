﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM_BAL
{
    public class BAL_EmployeeEntry
    {
        public int Flag { get; set; }

        public int EID { get; set; }

        public string EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string DateOfBirth { get; set; }

        public string MobileNo { get; set; }

        public string PhoneNo { get; set; }

        public string EmpAddress { get; set; }

        public string EmpZipNo { get; set; }

        public string EmpCity { get; set; }

        public string EmpState { get; set; }

        public string EmpCountry { get; set; }

        public string Designation { get; set; }

        public string DateOfJoining { get; set; }

        public string NoOfYears { get; set; }

        public string Years { get; set; }

        public string NoOfMonths { get; set; }

        public string Months { get; set; }

        public double Salary { get; set; }

        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
