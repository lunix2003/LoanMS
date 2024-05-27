using LMS.Data;
using LMS.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadData();
        }
        void SetProperty()
        {
            dgLoanView.RowHeadersVisible = false;
            dgLoanView.AllowUserToAddRows = false;
            dgLoanView.Columns[0].DataPropertyName = "LoanId";
            dgLoanView.Columns[0].Width = 100;
            dgLoanView.Columns[0].HeaderText = "#No";
            dgLoanView.Columns[0].Visible = true;
            dgLoanView.Columns[1].HeaderText = "Customer Name";
            dgLoanView.Columns[1].Width = 250;
            dgLoanView.Columns[1].DataPropertyName = "CustomerName";
            dgLoanView.Columns[1].Visible = true;
            dgLoanView.Columns[2].HeaderText = "Collateral Code";
            dgLoanView.Columns[2].Width = 250;
            dgLoanView.Columns[2].DataPropertyName = "CollateralCode";
            dgLoanView.Columns[2].Visible = true;
            dgLoanView.Columns[3].HeaderText = "Credit Officer";
            dgLoanView.Columns[3].Width = 250;
            dgLoanView.Columns[3].DataPropertyName = "CreditOfficerName";
            dgLoanView.Columns[3].Visible = true;
            dgLoanView.Columns[4].HeaderText = "Loan Code";
            dgLoanView.Columns[4].Width = 150;
            dgLoanView.Columns[4].DataPropertyName = "LoanCode";
            dgLoanView.Columns[4].Visible = true;
            dgLoanView.Columns[5].HeaderText = "Loan Date";
            dgLoanView.Columns[5].Width = 200;
            dgLoanView.Columns[5].DataPropertyName = "LoanDate";
            dgLoanView.Columns[5].Visible = true;
            dgLoanView.Columns[6].HeaderText = "Loan Amount";
            dgLoanView.Columns[6].DataPropertyName = "LoanAmount";
            dgLoanView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLoanView.Columns[6].Visible = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadData()
        {
            DataTable dt = Loans.GetView();
            dgLoanView.DataSource = dt;
            SetProperty();
            double amount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                amount += Convert.ToDouble(dr["LoanAmount"]);
            }
            DataTable dtCus = Customers.GetAll();
            double total_customer = 0;
            foreach (DataRow dr in dtCus.Rows)
            {
                total_customer++;
            }
            lblTotalLoan.Text = amount.ToString("$ #,#00.00");
            lblCustomerCount.Text = total_customer.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
