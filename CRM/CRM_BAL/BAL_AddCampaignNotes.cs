using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BAL
{
    public class BAL_AddCampaignNotes
    {
        public int Flag { get; set; }

        public int Id { get; set; }

        public int CampaignId { get; set; }

        public string CampaignNotes { get; set; }

        public string S_Status { get; set; }

        public string C_Date { get; set; }
    }
}
