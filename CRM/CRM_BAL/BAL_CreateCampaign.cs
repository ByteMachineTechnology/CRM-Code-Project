using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BAL
{
    public class BAL_CreateCampaign
    {
        public int Flag { get; set; }

        /// <summary>
        /// update id
        /// </summary>
        public int ID { get; set; }

        public string CampaignName { get; set; }

        public string CampaignType { get; set; }

        //acitivity
        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public double ExpectedRevenue { get; set; }

        public double BudgetedCost { get; set; }

        /// <summary>
        /// lead campaign
        /// </summary>
        public int LCampaignID { get; set; }

        public int FollowupID { get; set; }

        public string Status { get; set; }

        public string ExpectedResponse { get; set; }

        public string Description { get; set; }
        
       /// <summary>
       /// update mass camp
       /// </summary>
        public int MassCampID { get; set; }

        public string S_Status { get; set; }

        public string C_Date { get; set; }



    }
}
