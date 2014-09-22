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
using Microsoft.Win32;

using CRM_BAL;
using CRM_DAL;
namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for StockProducts.xaml
    /// </summary>
    ///
 
    public partial class StockProducts : Window
    {  public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        public int StockID;
        string Prd;
        double AQTY, Price;
        public StockProducts()
        {
            InitializeComponent();
            
        }

        private void btnAdm_StockDetails_Exit_Click(object sender, RoutedEventArgs e)
        {
            this .Close ();
        }

        private void btnAdm_StockD_Refresh_Click(object sender, RoutedEventArgs e)
        {
            txtAdm_Stock_Filter_Search.Text = "";
            txtAdm_Stock_Filter_Search_Price.Text = "";
            cmbAdm_StockFilter_Search.Text = "Select";
            StockDetails();
        }
        public void StockDetails()
        {
            try
            {
                String str;
                //con.Open();
                DataSet ds = new DataSet();
                str = "SELECT P.[ID],P.[Domain_ID],P.[Product_ID],P.[Brand_ID],P.[P_Category],P.[Model_No_ID],P.[Color_ID],P.[Products123],P.[AvilableQty],P.[SaleQty],P.[NewQty],P.[FinalPrice] " +
                      ",DM.[Domain_Name],PM.[Product_Name], B.[Brand_Name] , PC.[Product_Category] ,MN.[Model_No] ,C.[Color] " +
                      ",PP.[Price] " +
                      "FROM [StockDetails] P " +
                      "INNER JOIN [tb_Domain] DM ON DM.[ID]=P.[Domain_ID] " +
                      "INNER JOIN [tlb_Products] PM ON PM.[ID]=P.[Product_ID] " +
                      "INNER JOIN [tlb_Brand] B ON B.[ID]=P.[Brand_ID] " +
                      "INNER JOIN [tlb_P_Category] PC ON PC.[ID]=P.[P_Category]" +
                      "INNER JOIN [tlb_Model] MN ON MN.[ID]=P.[Model_No_ID] " +
                      "INNER JOIN [tlb_Color] C ON C.[ID]=P.[Color_ID] " +
                      "INNER JOIN [Pre_Products] PP ON PP.[Model_No_ID]=P.[Model_No_ID] " +
                      "WHERE ";

                if (txtAdm_Stock_Filter_Search_Price.Text.Trim() != "")
                {
                    str = str + "P.[FinalPrice] LIKE ISNULL('" + txtAdm_Stock_Filter_Search_Price.Text.Trim() + "',P.[FinalPrice]) + '%' AND ";
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Domain"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "DM.[Domain_Name] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',DM.[Domain_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Product Type"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "PM.[Product_Name] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',PM.[Product_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Brand"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "B.[Brand_Name] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',B.[Brand_Name]) + '%' AND ";
                    }
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Product Category"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "PC.[Product_Category] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',PC.[Product_Category]) + '%' AND ";
                    }
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Model"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "MN.[Model_No] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',MN.[Model_No]) + '%' AND ";
                    }
                }
                if (cmbAdm_StockFilter_Search.Text.Equals("Color"))
                {
                    if (txtAdm_Stock_Filter_Search.Text.Trim() != "")
                    {
                        str = str + "C.[Color] LIKE ISNULL('" + txtAdm_Stock_Filter_Search.Text.Trim() + "',C.[Color]) + '%' AND ";
                    }
                }

                str = str + " P.[S_Status] = 'Active' ORDER BY P.[C_Date] ASC ";
                //str = str + " S_Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                dgvAdm_StockDetails.ItemsSource = ds.Tables[0].DefaultView;
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

        private void txtAdm_Stock_Filter_Search_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            StockDetails(); 
        }

        private void txtAdm_Stock_Filter_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            StockDetails();

        }
        public void LoadStockDetails()
        {
            cmbAdm_StockFilter_Search.Text = "Select";
            cmbAdm_StockFilter_Search.Items.Add("Domain");
            cmbAdm_StockFilter_Search.Items.Add("Product Type");
            cmbAdm_StockFilter_Search.Items.Add("Brand");
            cmbAdm_StockFilter_Search.Items.Add("Product Category");
            cmbAdm_StockFilter_Search.Items.Add("Model");
            cmbAdm_StockFilter_Search.Items.Add("Color");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStockDetails();
            StockDetails();
        }

        private void dgvAdm_FinalProcurement_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dgvAdm_StockDetails.SelectedItem;
            StockID = Convert.ToInt32((dgvAdm_StockDetails.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            //loadStockProducts();
            frmCRM_Adm_Dashbord ad = new frmCRM_Adm_Dashbord();
            txtStockPID.Text = StockID.ToString();
            ad.Productname(txtStockPID.Text);
            DialogResult = true;
            this.Close();

        }
        public void loadStockProducts()
        {
           // cmbInvoiceStockProducts.Text = "---Select---";
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                string qry = "Select  S.ID,S.Domain_ID , S.Product_ID ,S.Brand_ID ,S.P_Category ,S.Model_No_ID ,S.Color_ID " +
                             ",D.Domain_Name + ' , ' + P.Product_Name + ' , ' + B.Brand_Name + ' , ' + PC.Product_Category + ' , ' + M.Model_No + ' , ' + C.Color AS Products " +
                             " S.AvilableQty , S.FinalPrice " +
                             "From StockDetails S " +
                             "INNER JOIN tb_Domain D on D.ID=S.Domain_ID " +
                             "INNER JOIN tlb_Products P on P.ID=S.Product_ID " +
                             "INNER JOIN tlb_Brand B on B.ID=S.Brand_ID " +
                             "INNER JOIN tlb_P_Category PC on PC.ID=S.P_Category " +
                             "INNER JOIN tlb_Model M on M.ID=S.Model_No_ID " +
                             "INNER JOIN tlb_Color C on C.ID=S.Color_ID " +
                             "where S.S_Status='Active' and S.ID='" + StockID + "' ORDER BY S.C_Date ASC ";
                cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // con.Open();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                   // cmbInvoiceStockProducts.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                   // cmbInvoiceStockProducts.ItemsSource = ds.Tables[0].DefaultView;
                   // cmbInvoiceStockProducts.DisplayMemberPath = ds.Tables[0].Columns["Products"].ToString();
                    Prd = ds.Tables[0].Columns["Products"].ToString();
                    AQTY =Convert .ToDouble ( ds.Tables[0].Columns["AvilableQty"]);
                    Price = Convert.ToDouble(ds.Tables[0].Columns["FinalPrice"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }


        }
    }
}
