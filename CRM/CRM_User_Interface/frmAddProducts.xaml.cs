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
    /// Interaction logic for frmAddProducts.xaml
    /// </summary>
    public partial class frmAddProducts : Window
    {

        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNewProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        static DataTable dtstat = new DataTable();

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {            
            DialogResult = true;
            this.Close();
        }

        public void AllProducts_Details()
        {
            try
            {
                String str;
                //con.Open();
                DataSet ds = new DataSet();
                str = "SELECT P.[ID],P.[Domain_ID],P.[Product_ID],P.[Brand_ID],P.[P_Category],P.[Model_No_ID],P.[Color_ID],P.[Price] " +
                      ",DM.[Domain_Name],PM.[Product_Name], B.[Brand_Name] , PC.[Product_Category] ,MN.[Model_No] ,C.[Color] " +
                      "FROM [Pre_Products] P " +
                      "INNER JOIN [tb_Domain] DM ON DM.[ID]=P.[Domain_ID] " +
                      "INNER JOIN [tlb_Products] PM ON PM.[ID]=P.[Product_ID] " +
                      "INNER JOIN [tlb_Brand] B ON B.[ID]=P.[Brand_ID] " +
                      "INNER JOIN [tlb_P_Category] PC ON PC.[ID]=P.[P_Category]" +
                      "INNER JOIN [tlb_Model] MN ON MN.[ID]=P.[Model_No_ID] " +
                      "INNER JOIN [tlb_Color] C ON C.[ID]=P.[Color_ID] " +
                      "WHERE ";
                if (cmbAdm_AllProducts_Search.Text.Equals("Domain"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "DM.[Domain_Name] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',DM.[Domain_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Product Type"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "PM.[Product_Name] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',PM.[Product_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Brand"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "B.[Brand_Name] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',B.[Brand_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Product Category"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "PC.[Product_Category] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',PC.[Product_Category]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Model"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "MN.[Model_No] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',MN.[Model_No]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Color"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "C.[Color] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',C.[Color]) + '%' AND ";
                    }
                }
                if (cmbAdm_AllProducts_Search.Text.Equals("Price"))
                {
                    if (txtAdm_AllProducts_Search.Text.Trim() != "")
                    {
                        str = str + "P.[Price] LIKE ISNULL('" + txtAdm_AllProducts_Search.Text.Trim() + "',P.[Price]) + '%' AND ";
                    }
                }

                str = str + " P.[S_Status] = 'Active' ORDER BY PM.[Product_Name] ASC ";
                //str = str + " S_Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                dgvAdm_AllProducts.ItemsSource = ds.Tables[0].DefaultView;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AllProducts_Details();
        }

        private void txtAdm_AllProducts_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnFollowupBrowse.IsEnabled = true;
            AllProducts_Details();
        }

        
        

        int PK_ID;

        private void dgvAdm_AllProducts_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            btnFollowupBrowse.IsEnabled = false;
            try
            {
                var id1 = (DataRowView)dgvAdm_AllProducts.SelectedItem; //get specific ID from          DataGrid after click on Edit button in DataGrid   
                PK_ID = Convert.ToInt32(id1.Row["ID"].ToString());
                con.Open();
                //string sqlquery = "SELECT * FROM Pre_Products where ID='" + PK_ID + "' ";
                string sqlquery = "SELECT P.[ID],P.[Domain_ID],P.[Product_ID],P.[Brand_ID],P.[P_Category],P.[Model_No_ID],P.[Color_ID],P.[Price] " +
                      ",DM.[Domain_Name],PM.[Product_Name], B.[Brand_Name] , PC.[Product_Category] ,MN.[Model_No] ,C.[Color] " +
                      "FROM [Pre_Products] P " +
                      "INNER JOIN [tb_Domain] DM ON DM.[ID]=P.[Domain_ID] " +
                      "INNER JOIN [tlb_Products] PM ON PM.[ID]=P.[Product_ID] " +
                      "INNER JOIN [tlb_Brand] B ON B.[ID]=P.[Brand_ID] " +
                      "INNER JOIN [tlb_P_Category] PC ON PC.[ID]=P.[P_Category]" +
                      "INNER JOIN [tlb_Model] MN ON MN.[ID]=P.[Model_No_ID] " +
                      "INNER JOIN [tlb_Color] C ON C.[ID]=P.[Color_ID] " +
                      "WHERE P.[ID]= '" + PK_ID + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtProductsID.Text = dt.Rows[0]["ID"].ToString();
                    txtPRoductName.Text = dt.Rows[0]["Product_Name"].ToString();
                    txtBrandName.Text = dt.Rows[0]["Brand_Name"].ToString();
                    txtPRoductCategory.Text = dt.Rows[0]["Product_Category"].ToString();
                    txtModelNo.Text = dt.Rows[0]["Model_No"].ToString();
                    txtColor.Text = dt.Rows[0]["Color"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                }
                frmCRM_Adm_Dashbord obj = new frmCRM_Adm_Dashbord();
                obj.ProductID123(txtProductsID.Text);
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void btnFollowupBrowse_Click(object sender, RoutedEventArgs e)
        {
            AllProducts_Details();
        }

    }
}
