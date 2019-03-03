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
using System.Data.SqlClient;


namespace ErinKinnen_CCIS2585Project2
{
    public partial class Form1 : Form
    {
        clsDatabase Database = null;
        public Form1()
        {
            InitializeComponent();
            btnEnterPayrollData.Enabled = false;
        }

        private void btnBrowseEmpData_Click(object sender, EventArgs e)
        {
            var BrowsePayroll = new Form2();
            BrowsePayroll.Show();
        }

        public void ExitApp()
        {
            DialogResult dlgResult;

            dlgResult = MessageBox.Show("Are you sure you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlgResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnForm1Exit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApp();
        }
    }
}
