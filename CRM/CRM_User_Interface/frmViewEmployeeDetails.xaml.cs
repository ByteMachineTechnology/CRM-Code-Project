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
using System.Text.RegularExpressions;
using CRM_BAL;
using CRM_DAL;

namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for frmViewEmployeeDetails.xaml
    /// </summary>
    public partial class frmViewEmployeeDetails : Window
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        static int PK_ID;

        public frmViewEmployeeDetails()
        {
            InitializeComponent();
        }

        #region Button Event
        private void btnEmp_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdm_Emp_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdm_Emp_Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdm_Emp_Exit_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion Button Event

        public void EmployeeID(string EmpID)
        {
            txtAdm_EmployeeID.Text = EmpID;
        }

        public void FillData()
        {
            try
            {
                con.Open();
                string sqlquery = "SELECT * FROM tbl_Employee where ID='" + txtAdm_EmployeeID.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblEmployeeID.Content = dt.Rows[0]["EmployeeID"].ToString();
                    txtAdm_EmpFirstName.Text = dt.Rows[0]["EmployeeFirstName"].ToString();
                    txtAdm_EmpLastName.Text = dt.Rows[0]["EmployeeLastName"].ToString();
                    dtpAdm_Emp_DOB.SelectedDate = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"].ToString());
                    txtAdm_Emp_Address.Text = dt.Rows[0]["EmpAddress"].ToString();
                    txtAdm_Emp_MobileNo.Text = dt.Rows[0]["MobileNo"].ToString();
                    txtAdm_Emp_PhoneNo.Text = dt.Rows[0]["PhoneNo"].ToString();
                    cmbEmp_City.Text = dt.Rows[0]["EmpCity"].ToString();
                    txtAdm_Emp_Zip.Text = dt.Rows[0]["EmpZipNo"].ToString();
                    cmbEmp_State.Text = dt.Rows[0]["EmpState"].ToString();
                    cmbEmp_Country.Text = dt.Rows[0]["EmpCountry"].ToString();
                    txtAdm_Emp_Designation.Text = dt.Rows[0]["Designation"].ToString();
                    dtpAdm_Emp_DOJ.SelectedDate = Convert.ToDateTime(dt.Rows[0]["DateOfJoining"].ToString());
                    cmbAdm_Emp_YearExp.SelectedItem = dt.Rows[0]["NoOfYears"].ToString();
                    lblYears.Content = dt.Rows[0]["Years"].ToString();
                    cmbAdm_Emp_Months.SelectedItem = dt.Rows[0]["NoOfMonths"].ToString();
                    lblMonths.Content = dt.Rows[0]["Months"].ToString();
                    txtAdm_Emp_Salary.Text = dt.Rows[0]["Salary"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            btnAdm_Emp_Save.Content = "Update";
        }
        public void LoadNoOfYears1()
        {
            cmbAdm_Emp_YearExp.Text = "Select Year";
            cmbAdm_Emp_YearExp.Items.Add("0");
            cmbAdm_Emp_YearExp.Items.Add("1");
            cmbAdm_Emp_YearExp.Items.Add("2");
            cmbAdm_Emp_YearExp.Items.Add("3");
            cmbAdm_Emp_YearExp.Items.Add("4");
            cmbAdm_Emp_YearExp.Items.Add("5");
            cmbAdm_Emp_YearExp.Items.Add("6");
            cmbAdm_Emp_YearExp.Items.Add("7");
            cmbAdm_Emp_YearExp.Items.Add("8");
            cmbAdm_Emp_YearExp.Items.Add("9");
            cmbAdm_Emp_YearExp.Items.Add("10");
            cmbAdm_Emp_YearExp.Items.Add("11");
            cmbAdm_Emp_YearExp.Items.Add("12");
            cmbAdm_Emp_YearExp.Items.Add("13");
            cmbAdm_Emp_YearExp.Items.Add("14");
            cmbAdm_Emp_YearExp.Items.Add("15");
        }

        public void LoadNoOfMonths1()
        {
            cmbAdm_Emp_Months.Text = "Select Months";
            cmbAdm_Emp_Months.Items.Add("0");
            cmbAdm_Emp_Months.Items.Add("1");
            cmbAdm_Emp_Months.Items.Add("2");
            cmbAdm_Emp_Months.Items.Add("3");
            cmbAdm_Emp_Months.Items.Add("4");
            cmbAdm_Emp_Months.Items.Add("5");
            cmbAdm_Emp_Months.Items.Add("6");
            cmbAdm_Emp_Months.Items.Add("7");
            cmbAdm_Emp_Months.Items.Add("8");
            cmbAdm_Emp_Months.Items.Add("9");
            cmbAdm_Emp_Months.Items.Add("10");
            cmbAdm_Emp_Months.Items.Add("11");
        }

        public void EEMPLOYEEid1()
        {

            int id1 = 0;
            // SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select (COUNT(ID)) from tbl_Employee", con);
            id1 = Convert.ToInt32(cmd.ExecuteScalar());
            id1 = id1 + 1;
            lblEmployeeID.Content = "# Emp /" + id1.ToString();
            con.Close();


        }

        public void Load_Employee_City1()
        {
            cmbEmp_City.Text = "Select";
            string q = "SELECT distinct(EmpCity) As EmpCity FROM tbl_Employee ";
            cmd = new SqlCommand(q, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //cmbInsurance_CustName.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                cmbEmp_City.ItemsSource = ds.Tables[0].DefaultView;
                cmbEmp_City.DisplayMemberPath = ds.Tables[0].Columns["EmpCity"].ToString();
            }
        }

        public void Load_Employee_State1()
        {
            cmbEmp_State.Text = "Select";
            string q = "SELECT distinct(EmpState) As EmpState FROM tbl_Employee ";
            cmd = new SqlCommand(q, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //cmbInsurance_CustName.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                cmbEmp_State.ItemsSource = ds.Tables[0].DefaultView;
                cmbEmp_State.DisplayMemberPath = ds.Tables[0].Columns["EmpState"].ToString();
            }
        }

        public void Load_Employee_Country1()
        {
            cmbEmp_Country.Text = "Select";
            string q = "SELECT distinct(EmpCountry) As EmpCountry FROM tbl_Employee ";
            cmd = new SqlCommand(q, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //cmbInsurance_CustName.SelectedValuePath = ds.Tables[0].Columns["ID"].ToString();
                cmbEmp_Country.ItemsSource = ds.Tables[0].DefaultView;
                cmbEmp_Country.DisplayMemberPath = ds.Tables[0].Columns["EmpCountry"].ToString();
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void cmbAdm_Emp_YearExp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbAdm_Emp_Months.Visibility = System.Windows.Visibility.Visible;
            lblMonths.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
