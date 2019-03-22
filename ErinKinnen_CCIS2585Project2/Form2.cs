using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace ErinKinnen_CCIS2585Project2
{
    public partial class Form2 : Form
    {
        DataSet dsEmp = null;
        Int32 intCurrRow = 0;
        //Int32 intEmpID = 0;
        //clsDatabase Database = null;
        public Form2()
        {
            InitializeComponent();
            
        }

        //*******************************************************
        //** Procedure: Form2_Load()
        //** Description:
        //**   Initializes dataset
        //*******************************************************
        private void Form2_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["AppTitle"] != null)
            {
                
                lblBrowseEmployee.Text = ConfigurationManager.AppSettings["AppTitle"].ToString();
            }
            lblErrorForm2.Text = "";
            LoadEmployees();
            DisplayEmployeePayroll(Convert.ToInt32(txtIDNumber.Text));
        }


        //*******************************************************
        //** Procedure: LoadEmployees()
        //** Description:
        //**   Fills (or refreshes) employee dataset
        //*******************************************************
        private void LoadEmployees()
        {

            //** Remove any existing dataset
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            //** Initialize current row indicator
            intCurrRow = 0;

            dsEmp = clsDatabase.GetEmployees();
            if (dsEmp == null)
            {
                MessageBox.Show("Unable to retrieve employee information", "SELECT");
            }
            else if (dsEmp.Tables.Count < 1)
            {
                MessageBox.Show("Unable to retrieve employee information", "SELECT");
                dsEmp.Dispose();
                dsEmp = null;
            }
            else if (dsEmp.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("No employee information available", "SELECT");
            }
            else
            {
                ShowEmployee();

            }
        }

        //*******************************************************
        //** Procedure: ShowEmployee()
        //** Description:
        //**   Display specified employee record
        //*******************************************************
        private void ShowEmployee()
        {
            txtIDNumber.Text = dsEmp.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
            txtLName.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
            txtFName.Text = dsEmp.Tables[0].Rows[intCurrRow]["FName"].ToString();
            if (dsEmp.Tables[0].Rows[intCurrRow]["MInit"] == DBNull.Value)
            {
                txtMI.Text = "";
            }
            else
            {
                txtMI.Text = dsEmp.Tables[0].Rows[intCurrRow]["MInit"].ToString();
            }
            txtSSAN.Text = dsEmp.Tables[0].Rows[intCurrRow]["SSAN"].ToString();
            txtPay.Text = dsEmp.Tables[0].Rows[intCurrRow]["PayRate"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intCurrRow = 0;
            ShowEmployee();
            DisplayEmployeePayroll(Convert.ToInt32(txtIDNumber.Text));
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            ShowEmployee();
            DisplayEmployeePayroll(Convert.ToInt32(txtIDNumber.Text));
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            intCurrRow -= 1;
            if (intCurrRow < 0)
            {
                intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            }
            ShowEmployee();
            DisplayEmployeePayroll(Convert.ToInt32(txtIDNumber.Text));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intCurrRow += 1;
            if (intCurrRow >= dsEmp.Tables[0].Rows.Count)
            {
                intCurrRow = 0;

            }
            ShowEmployee();
            DisplayEmployeePayroll(Convert.ToInt32(txtIDNumber.Text));


        }

        private void btnExitForm2_Click(object sender, EventArgs e)
        {
            dsEmp.Dispose();
            this.Close();
        }

        //*******************************************************
        //** Procedure: DisplayEmployeePayroll()
        //**   Display payrate and payroll for specified employee
        //*******************************************************
        private void DisplayEmployeePayroll(Int32 intEmpID)
        {
            DataSet dsData;
            Decimal decPayrate;
   
            decPayrate = clsDatabase.GetEmployeePayrate(intEmpID);
            if (decPayrate < 0m)
            {
                lblErrorForm2.Text = "Unable to retrieve payrate for specified employee";
                //txtPayrate.Text = "$0.00";
            }
            else
            {
                txtPay.Text = decPayrate.ToString("c");
            }

            dsData = clsDatabase.GetEmployeePayroll(intEmpID);
            if (dsData == null)
            {
                lblErrorForm2.Text = "Error retrieving payroll info";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblErrorForm2.Text = "Error retrieving payroll info";
                dsData.Dispose();
            }
            else
            {
                dgvPayroll.DataSource = dsData.Tables[0];
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
