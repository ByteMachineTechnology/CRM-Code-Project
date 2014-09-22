using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using CRM_User_Interface;

namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for frmAddCampaign.xaml
    /// </summary>
    public partial class frmAddCampaign : Window
    {

        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;

        public frmAddCampaign()
        {
            InitializeComponent();

            AllCampaign_Details();
        }

        #region Button Event
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void btnFollowupSearch_Click(object sender, RoutedEventArgs e)
        {
            AllCampaign_Details();
        }
        #endregion Button Event

        static DataTable dtstat = new DataTable();

        public void AllCampaign_Details()
        {
            try
            {
                String str;
                //con.Open();
                DataSet ds = new DataSet();
                str = "SELECT [ID],[CampaignName],[CampaignType],[StartDate],[EndDate],[ExpectedRevenue],[BudgetedCost],[Status] " +
                      ",[ExpectedResponse],[Description] " +
                      "FROM [tlb_FollowUpCampaign] " +
                      "WHERE ";

                if (txtSearchCampaignName.Text.Trim() != "")
                {
                    str = str + "[CampaignName] LIKE ISNULL ('" + txtSearchCampaignName.Text.Trim() + "',[CampaignName]) + '%' AND ";
                }

                str = str + " [S_Status] = 'Active' ORDER BY [CampaignName] ASC ";
                //str = str + " S_Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                dgvCampaignDetails.ItemsSource = ds.Tables[0].DefaultView;
                //}
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        int PK_ID;

        private void dgvCampaignDetails_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            btnFollowupSearch.IsEnabled = false;
            try
            {
                var id1 = (DataRowView)dgvCampaignDetails.SelectedItem; //get specific ID from          DataGrid after click on Edit button in DataGrid   
                PK_ID = Convert.ToInt32(id1.Row["ID"].ToString());
                con.Open();
                //string sqlquery = "SELECT * FROM Pre_Products where ID='" + PK_ID + "' ";
                string sqlquery = "SELECT [ID],[CampaignName],[CampaignType],[StartDate],[EndDate],[ExpectedRevenue],[BudgetedCost],[Status] " +
                      ",[ExpectedResponse],[Description] " +
                      "FROM [tlb_FollowUpCampaign] " +
                      "WHERE [ID]= '" + PK_ID + "'";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtCampaignID.Text = dt.Rows[0]["ID"].ToString();
                    txtCampaignName.Text = dt.Rows[0]["CampaignName"].ToString();
                    txtCampaignType.Text = dt.Rows[0]["CampaignType"].ToString();
                    dtpStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                    dtpEndDate.Text = dt.Rows[0]["EndDate"].ToString();
                    txtStatus.Text = dt.Rows[0]["Status"].ToString();
                }
            }
            catch
            {
                throw;
            }
            finally 
            {
                con.Close();
            }
            frmCRM_Adm_Dashbord obj = new frmCRM_Adm_Dashbord();
            obj.CampaignID123(txtCampaignID.Text);
        }

        private void txtSearchCampaignName_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnFollowupSearch.IsEnabled = true;
            AllCampaign_Details();
        }
    }
}
