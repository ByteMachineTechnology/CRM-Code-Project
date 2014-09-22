using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BAL
{
    public class BAL_AddComments
    {
        public int Flag { get; set; }

        public int FollowupId { get; set; }

        public string Comments { get; set; }

        //acitivity
        public string ASubject { get; set; }

        public string ADate { get; set; }

        public int AEmployeeID { get; set; }

        public string ANotes { get; set; }
        //acivity


        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
