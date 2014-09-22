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
    /// Interaction logic for frm_FetchEmployeeDetails.xaml
    /// </summary>
    public partial class frm_FetchEmployeeDetails : Window
    { public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        public frm_FetchEmployeeDetails()
        {
            InitializeComponent();

        }
        public string eid;
      public   int FEmpID;
        string FEName, FEName2,cmbname;
        int PK_ID;
        private void dgrdFEmployeeDetails_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                var id1 = (DataRowView)dgrdFEmployeeDetails.SelectedItem; //get specific ID from          DataGrid after click on Edit button in DataGrid   
                PK_ID = Convert.ToInt32(id1.Row["ID"].ToString());
                con.Open();
                //string sqlquery = "SELECT * FROM Pre_Products where ID='" + PK_ID + "' ";
                string sqlquery = "SELECT [ID],[EmployeeFirstName] + ' ' + [EmployeeLastName] AS [EmpName] FROM [tbl_Employee] WHERE [ID]= '" + PK_ID + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFEmpID.Text = dt.Rows[0]["ID"].ToString();
                    txtFEmpName.Text = dt.Rows[0]["EmpName"].ToString();
                }
                frmCRM_Adm_Dashbord obj = new frmCRM_Adm_Dashbord();
                obj.femp(txtFEmpID.Text, txtFEmpName.Text);
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

           // object item = dgrdFEmployeeDetails .SelectedItem;
           // FEmpID = Convert.ToInt32((dgrdFEmployeeDetails.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
           // FEName=(dgrdFEmployeeDetails.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
           // FEName2 = (dgrdFEmployeeDetails.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
           // cmbname = FEName + FEName2;
           // //loadStockProducts();
           // frmCRM_Adm_Dashbord ad = new frmCRM_Adm_Dashbord();
           //// ad.FEmpID = FEmpID;
           //// ad.cmbname = cmbname;
           //// ad.Show();
           // eid = FEmpID.ToString();
           // ad.femp(eid);
            
        }
        public void fetch_EmployeeID()
        {
            try
            {
                 con.Open();
                string sqlquery1 = "Select ID,EmployeeID from tbl_Employee where S_Status='Active' ";
                SqlCommand cmd = new SqlCommand(sqlquery1, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmb_FEmp_EID .SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmb_FEmp_EID.ItemsSource = ds.Tables[0].DefaultView;
                    cmb_FEmp_EID.DisplayMemberPath = ds.Tables[0].Columns["EmployeeID"].ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally { con.Close(); }
        }
        public void fetch_EmployeeDetails()
        {
            try
            {
                con.Open();
                string sqlquery1 = "Select ID,EmployeeID,EmployeeFirstName,EmployeeLastName,Designation,S_Status from tbl_Employee where S_Status='Active' ";
                SqlCommand cmd = new SqlCommand(sqlquery1, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
               if(dt.Rows .Count >0)
               {
                    dgrdFEmployeeDetails .ItemsSource = dt.Rows[0].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetch_EmployeeID();
            searchEmployeeDetails();
        }
        public void searchEmployeeDetails()
        {
            try
            {
                String str;
                con.Open();
              
                str = "Select ID,EmployeeID,EmployeeFirstName,EmployeeLastName,Designation,S_Status from tbl_Employee where  ";

                if (txtFEmp_FName.Text.Trim() != "")
                {
                    str = str + "EmployeeFirstName LIKE ISNULL('" + txtFEmp_FName.Text.Trim() + "',EmployeeFirstName) + '%' AND ";
                }
                if (txtFEmp_LName.Text.Trim() != "")
                {
                    str = str + "EmployeeLastName LIKE ISNULL('" + txtFEmp_LName.Text.Trim() + "',EmployeeLastName) + '%' AND ";
                }
                if (cmb_FEmp_EID.Text.Trim() != "")
                {
                    str = str + "EmployeeID LIKE ISNULL('" + cmb_FEmp_EID.Text.Trim() + "',EmployeeID) + '%' AND ";
                }
                str = str + " S_Status='Active' ORDER BY ID ASC ";
                //str = str + " S_Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                dgrdFEmployeeDetails .ItemsSource = ds.Tables[0].DefaultView;
                //}
            }
            catch (Exception)
            {
                
                throw;
            }
            finally { con.Close(); }
        }

        private void cmb_FEmp_EID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchEmployeeDetails();
        }

        private void txtFEmp_LName_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchEmployeeDetails();
        }

        private void txtFEmp_FName_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchEmployeeDetails();
        }

     

        private void btnFEmp_Refresh_Click(object sender, RoutedEventArgs e)
        {
            txtFEmp_FName.Text = "";
            txtFEmp_LName.Text = "";
            cmb_FEmp_EID.ItemsSource = null;
            fetch_EmployeeID();
        }

        private void btnFEmpExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFEmp_Done_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
