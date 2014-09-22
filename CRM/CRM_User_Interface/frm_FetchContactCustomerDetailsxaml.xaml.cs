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
    /// Interaction logic for frm_FetchContactCustomerDetailsxaml.xaml
    /// </summary>
    public partial class frm_FetchContactCustomerDetailsxaml : Window
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        public int ContactCID;
        public frm_FetchContactCustomerDetailsxaml()
        {
            InitializeComponent();
        }

        private void dgvAdm_FinalProcurement_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = dgvSale_ContactCustDetails.SelectedItem;
            ContactCID = Convert.ToInt32((dgvSale_ContactCustDetails.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            //loadStockProducts();
            frmCRM_Adm_Dashbord ad2 = new frmCRM_Adm_Dashbord();
            txtCCDID.Text = ContactCID.ToString();
            ad2.ContactCDname(txtCCDID.Text);
            DialogResult = true;
            this.Close();

        }
        public void ContactDetails()
        {
            try
            {
                String str;
                //con.Open();
                DataSet ds = new DataSet();
                str = "select  ID,ContactCustID,CTitle + ' ' + FirstName  as Name,LastName,MobileNo,EmialID,MailingStreet from tlb_ContactCustomer " +
                    "WHERE ";

                if (txtFCnt_FName.Text.Trim() != "")
                {
                    str = str + "FirstName LIKE ISNULL('" + txtFCnt_FName.Text.Trim() + "',FirstName+ '%' AND ";
                }
               
                    if (txtFCnt_LName.Text.Trim() != "")
                    {
                        str = str + "LastName LIKE ISNULL('" + txtFCnt_LName.Text.Trim() + "',LastName) + '%' AND ";
                    }

                   if (cmb_FCnt_EID.Text.Trim() != "")
                    {
                        str = str + "ContactCustID LIKE ISNULL('" + cmb_FCnt_EID.Text.Trim() + "',PM.[Product_Name]) + '%' AND ";
                    }



                   str = str + " S_Status='Active'  ORDER BY ContactCustID ASC ";
                //str = str + " S_Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                dgvSale_ContactCustDetails.ItemsSource = ds.Tables[0].DefaultView;
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
            fetch_ContactID();
            ContactDetails();
        }

        private void txtFCnt_FName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ContactDetails();
        }

        private void txtFCnt_LName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ContactDetails();
            
        }
        public void fetch_ContactID()
        {
            try
            {
                con.Open();
                string sqlquery1 = "Select ID,ContactCustID from tlb_ContactCustomer where S_Status='Active' ";
                SqlCommand cmd = new SqlCommand(sqlquery1, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmb_FCnt_EID.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                    cmb_FCnt_EID.ItemsSource = ds.Tables[0].DefaultView;
                    cmb_FCnt_EID.DisplayMemberPath = ds.Tables[0].Columns["ContactCustID"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void cmb_FCnt_EID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContactDetails();
        }

        private void btnAdm_ContactCDetails_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
