﻿using LMS.Data;
using LMS.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class LoanForm : Form
    {
        DataTable dt;
        public LoanForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            CheckUser();
        }
        void CheckUser()
        {
            DataTable dt = AppUserPermissions.Get(userId);
            foreach (DataRow dr in dt.Rows)
            {
                
                if (dr["UserPermission"].ToString() == "LoanModify")
                {
                    btnEdit.Enabled = true;
                }
                if (dr["UserPermission"].ToString() == "LoanCreate")
                {
                    btnNew.Enabled = true;
                }
                if (dr["UserPermission"].ToString() == "LoanDelete")
                {
                    btnRemove.Enabled = true;
                }
                

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            if (!DoValidation()) return;

            Loan loan = new Loan();
            loan.LoanCode = txtCode.Text.Trim();
            loan.LoanDate = dtpLoanDate.Value;
            loan.CollateralId = Convert.ToInt32(cbCollateralCode.SelectedValue);
            loan.CustomerId = Convert.ToInt32(cbCustomerName.SelectedValue);
            loan.Currency = GetCurrency();
            loan.CreditOfficerId = Convert.ToInt32(cbCOName.SelectedValue);
            loan.InterestRate = Convert.ToDouble(txtRate.Text.Trim());
            loan.LoanAmount = Convert.ToDouble(txtAmount.Text.Trim());
            loan.PaymentFrequencyCode = txtPFCode.Text == "" ? 0 : Convert.ToDouble(txtPFCode.Text.Trim());
            loan.Memo = txtMemo.Text.Trim();
            if(num == 0)
            {
                if(loan != null)
                {
                    int id = Loans.Add(loan);
                    if(id > 0)
                    {
                        foreach(DataRow row in dataTb.Rows)
                        {
                            LoanDetail detail = new LoanDetail();
                            detail.LoanId = id;
                            detail.PaidDate = Convert.ToDateTime(row["Date"].ToString());
                            detail.Interest = Convert.ToDouble(row["Interest"].ToString());
                            detail.BeginningBalance = Convert.ToDouble(row["BeginningBalance"].ToString());
                            detail.Principle = Convert.ToDouble(row["Principal"].ToString());
                            detail.EndingBalance = Convert.ToDouble(row["EndingBalance"].ToString());
                            detail.Payment = Convert.ToDouble(row["Payment"].ToString());
                            detail.PeriodNo = Convert.ToInt32(row["No"].ToString());
                            detail.Note = row["Note"].ToString();
                            if (!Convert.IsDBNull(row["Paid"]))
                                detail.IsPaid = GetIsPaid(Convert.ToBoolean(row["Paid"]));
                            else detail.IsPaid = 0;
                            if (detail != null)
                            {
                                LoanDetails.Add(detail);
                            }
                        }
                        MessageBox.Show("Record has Saved successfully");
                        lblId.Text = id.ToString();
                    }
                    LoadLoan();
                }
            }
            else if(num == 1)
            {
                loan.LoanId = Convert.ToInt32(lblId.Text.Trim());
                if(loan != null)
                {
                    Loans.Update(loan);
                    if(liste == 0)
                    {
                        for(int i = 0; i < dgLoanDetail.Rows.Count; i++)
                        {
                            LoanDetail detail = new LoanDetail();
                            detail.LoanDetailId = Convert.ToInt32(dgLoanDetail.Rows[i].Cells["LoanDetailId"].Value);
                            if (!Convert.IsDBNull(dgLoanDetail.Rows[i].Cells["IsPaid"].Value))
                                detail.IsPaid = GetIsPaid(Convert.ToBoolean(dgLoanDetail.Rows[i].Cells["IsPaid"].Value));
                            else detail.IsPaid = 0;
                            detail.Note = dgLoanDetail.Rows[i].Cells["Note"].Value.ToString();

                            LoanDetails.Update(detail);
                        }
                    }
                    else
                    {
                        LoanDetails.Delete(loan.LoanId);
                        foreach (DataRow row in dataTb.Rows)
                        {
                            LoanDetail detail = new LoanDetail();
                            detail.LoanId = loan.LoanId;
                            detail.PaidDate = Convert.ToDateTime(row["Date"].ToString());
                            detail.Interest = Convert.ToDouble(row["Interest"].ToString());
                            detail.BeginningBalance = Convert.ToDouble(row["BeginningBalance"].ToString());
                            detail.Principle = Convert.ToDouble(row["Principal"].ToString());
                            detail.EndingBalance = Convert.ToDouble(row["EndingBalance"].ToString());
                            detail.Payment = Convert.ToDouble(row["Payment"].ToString());
                            detail.PeriodNo = Convert.ToInt32(row["No"].ToString());
                            detail.Note = row["Note"].ToString();
                            if (!Convert.IsDBNull(row["Paid"]))
                                detail.IsPaid = GetIsPaid(Convert.ToBoolean(row["Paid"]));
                            else detail.IsPaid = 0;
                            if (detail != null)
                            {
                                LoanDetails.Add(detail);
                            }
                        }
                    }
                    MessageBox.Show("Record has Updated");
                    liste = 0;
                    LoadLoan();
                }
                dt = new DataTable();
            }
        }

        private int GetIsPaid(bool result)
        {
            if (result)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private char GetCurrency()
        {
            char result;
            if(cbCurrency.Text == "$")
            {
                result = '$';
            }
            else
            {
                result = 'R';
            }
            return result;
        }

        void LoadCustomer()
        {
            cbCustomerName.DataSource = Customers.GetAll();
            cbCustomerName.DisplayMember = "CustomerName";
            cbCustomerName.ValueMember = "CustomerId";
        }
        void LoadCollateral()
        {
            cbCollateralCode.DataSource = Collaterals.GetAll();
            cbCollateralCode.DisplayMember = "CollateralCode";
            cbCollateralCode.ValueMember = "CollateralId";
        }
        void LoadCreditOfficer()
        {
            cbCOName.DataSource = CreditOfficers.GetAll();
            cbCOName.DisplayMember = "CreditOfficerName";
            cbCOName.ValueMember = "CreditOfficerId";
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            InitialData();
            LoadLoan();
        }
        public void InitialData()
        {
            LoadCollateral();
            LoadCreditOfficer();
            LoadCustomer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            Clear();
            num = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            txtAmount.Enabled = false;
            txtRate.Enabled = false;
            txtDuration.Enabled = false;
            cbCurrency.Enabled = false;
            btnGenerate.Enabled = false;
            num = 1;
            cbCurrency.SelectedIndex = 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            if ( id > 0)
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete this record?","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    Loans.Delete(id);
                    Loan_Load(null, null);
                }
            }
        }
        int period_val;
        int days, months,years;
        double principle_val, Rate, beginBalance,endBalance,interest_val,payment_val,amount;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            liste = 1;
            dtpLoanDate.Value = DateTime.Now;
            months = Convert.ToInt32(dtpLoanDate.Value.Month);
            years = Convert.ToInt32(dtpLoanDate.Value.Year);
            period_val = Convert.ToInt32(txtDuration.Text.Trim()) * 12;
            principle_val = Convert.ToDouble(txtAmount.Text.Trim()) / period_val;
            Rate = Convert.ToDouble(txtRate.Text.Trim());
            endBalance= amount = Convert.ToDouble(txtAmount.Text.Trim());
            double monthlyInterestRate = Rate / 1200;
            payment_val = amount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, Convert.ToInt32(txtDuration.Text.Trim()) * 12));
            double totalPayment = payment_val * 12 * Convert.ToInt32(txtDuration.Text.Trim());
            double totalInterest = 0;
            dataTb = null;
            if (dataTb == null)
            {
                btnGenerate.Enabled = false;
                dataTb = new DataTable();
                dataTb.Columns.AddRange(new DataColumn[] {
                        new DataColumn("LoanDetailId", typeof(int)),
                        new DataColumn("LoanId", typeof(int)),
                        new DataColumn("No", typeof(int)),
                        new DataColumn("BeginningBalance", typeof(double)),
                        new DataColumn("Principal",typeof(double)),
                        new DataColumn("Interest", typeof(double)),
                        new DataColumn("Payment", typeof(double)),
                        new DataColumn("EndingBalance", typeof(double)),
                        new DataColumn("Paid", typeof(bool)),
                        new DataColumn("Date", typeof(string)),
                        new DataColumn("Note", typeof(string))
                });
                for (int j = 1; j <= period_val; j++)
                {
                    days = Convert.ToInt32(dtpLoanDate.Value.Day);

                    beginBalance = endBalance;
                    interest_val = beginBalance * ((Rate / 100) / 12.0);
                    principle_val = payment_val - interest_val;
                    endBalance = beginBalance - principle_val;
                    totalInterest += interest_val;
                    dataTb.Rows.Add(null,null,j.ToString(), Math.Round(beginBalance,2).ToString("#,##0.00"), Math.Round(principle_val,2).ToString("#,#00.00"), Math.Round(interest_val,2).ToString("#,#00.00"), Math.Round(payment_val,2).ToString("#,#00.0000"), Math.Round(endBalance,2).ToString("#,#00.00"),0, days + "/" + months + "/" + years);
                    if (months == 12)
                    {
                        months = 1;
                        years += 1;
                    }
                    else
                    {
                        months += 1;
                    }
                }

            }

            SetProperty();
            dgLoanDetail.DataSource = dataTb;

            lblTotalCostOfLoan.Text = totalPayment.ToString("#,#00.00");
            lblNumberOfPayment.Text = dgLoanDetail.Rows.Count.ToString();   
            lblMonthlyPayment.Text = payment_val.ToString("#,#00.00");
            lblTotalInterest.Text = totalInterest.ToString("#,#00.00");
            
        }

        private void lblId_Click(object sender, EventArgs e)
        {
            LoanSearch ls = new LoanSearch();
            if(ls.ShowDialog() == DialogResult.OK)
            {
                lblId.Text = LoanSearch.id.ToString() ;
                LoadLoan();
            }
        }

        DataTable dtLoan;
        private BindingSource bsLoan;
        private double totalCostOfLoan= 0;

        private void btnRight_Click(object sender, EventArgs e)
        {
            bsLoan.CancelEdit();
            bsLoan.MoveNext();
            totalCostOfLoan = 0;
            totalInterest = 0;
            LoadLoanDetail();
            EnableControls(false);
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            bsLoan.CancelEdit();
            bsLoan.MovePrevious();
            totalCostOfLoan = 0;
            totalInterest = 0;
            LoadLoanDetail();
            EnableControls(false);
        }

        private double totalInterest;
        private int num;
        private int liste = 0;

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = e.KeyChar;
            if(ascii >= 48 && ascii <= 57)
            {
                e.Handled = false;
            }
            else if(ascii == 46 || ascii == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private DataTable dataTb;
        private readonly int userId;

        void LoadLoan()
        {
            dtLoan = new DataTable();
            dtLoan = Loans.GetAll(0);
            bsLoan = new BindingSource();
            bsLoan.DataSource = dtLoan;

            CurrencyManager cm;

            cbCustomerName.DataBindings.Clear();
            cbCollateralCode.DataBindings.Clear();
            cbCOName.DataBindings.Clear();
            cbCurrency.DataBindings.Clear();
            txtAmount.DataBindings.Clear();
            txtCode.DataBindings.Clear();
            txtDuration.DataBindings.Clear();
            txtMemo.DataBindings.Clear();
            txtPFCode.DataBindings.Clear();
            txtRate.DataBindings.Clear();
            dtpLoanDate.DataBindings.Clear();
            lblId.DataBindings.Clear();
            
            cbCollateralCode.DataBindings.Add("SelectedValue",bsLoan,"CollateralId");
            cbCustomerName.DataBindings.Add("SelectedValue", bsLoan, "CustomerId");
            cbCOName.DataBindings.Add("SelectedValue", bsLoan, "CreditOfficerId");
            cbCurrency.DataBindings.Add("Text", bsLoan, "Currency");
            txtAmount.DataBindings.Add("Text", bsLoan, "LoanAmount");
            txtCode.DataBindings.Add("Text", bsLoan, "LoanCode");
            //txtDuration.DataBindings.Add("Text", bsLoan, "Currency");
            lblId.DataBindings.Add("Text", bsLoan, "LoanId");
            txtMemo.DataBindings.Add("Text",bsLoan,"Memo");
            txtPFCode.DataBindings.Add("Text",bsLoan, "PAYMENTFREQUENCYCODE");
            txtRate.DataBindings.Clear();
            dtpLoanDate.DataBindings.Add("Text",bsLoan,"LoanDate");

            LoadLoanDetail();
        }
        void SetProperty()
        {
            dgLoanDetail.RowHeadersVisible = false;
            dgLoanDetail.AllowUserToAddRows = false;
            dgLoanDetail.Columns[0].DataPropertyName = "LoanDetailId";
            dgLoanDetail.Columns[0].Visible = false;
            dgLoanDetail.Columns[1].DataPropertyName = "LoanId";
            dgLoanDetail.Columns[1].Visible = false;
            dgLoanDetail.Columns[2].DataPropertyName = "PeriodNo";
            dgLoanDetail.Columns[2].Width = 50;
            dgLoanDetail.Columns[2].Visible = true;
            dgLoanDetail.Columns[2].HeaderText = "No";
            dgLoanDetail.Columns[3].HeaderText = "Beginning Balance";
            dgLoanDetail.Columns[3].Width = 200;
            dgLoanDetail.Columns[3].DataPropertyName = "BEGINNINGBALANCE";
            dgLoanDetail.Columns[3].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[3].Visible = true;
            dgLoanDetail.Columns[4].HeaderText = "Principal";
            dgLoanDetail.Columns[4].Name = "Principle";
            dgLoanDetail.Columns[4].Width = 150;
            dgLoanDetail.Columns[4].DataPropertyName = "Principal";
            dgLoanDetail.Columns[4].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[4].Visible = true;
            dgLoanDetail.Columns[5].HeaderText = "Interest";
            dgLoanDetail.Columns[5].Width = 150;
            dgLoanDetail.Columns[5].DataPropertyName = "Interest";
            dgLoanDetail.Columns[5].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[5].Visible = true;
            dgLoanDetail.Columns[6].HeaderText = "Payment";
            dgLoanDetail.Columns[6].Width = 150;
            dgLoanDetail.Columns[6].DataPropertyName = "Payment";
            dgLoanDetail.Columns[6].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[6].Visible = true;
            dgLoanDetail.Columns[7].HeaderText = "Ending Balance";
            dgLoanDetail.Columns[7].Width = 200;
            dgLoanDetail.Columns[7].DataPropertyName = "ENDINGBALANCE";
            dgLoanDetail.Columns[7].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[7].Visible = true;
            dgLoanDetail.Columns[8].HeaderText = "Paid";
            dgLoanDetail.Columns[8].DataPropertyName = "ISPAID";
            DataGridViewCheckBoxColumn column = (DataGridViewCheckBoxColumn)dgLoanDetail.Columns[8];
            column.DataPropertyName = "ISPAID";

            dgLoanDetail.Columns[8].Width = 50;
            dgLoanDetail.Columns[8].Visible = true;
            dgLoanDetail.Columns[9].HeaderText = "Date";
            dgLoanDetail.Columns[9].Width = 200;
            dgLoanDetail.Columns[9].DataPropertyName = "PAIDDATE";
            dgLoanDetail.Columns[9].Visible = true;
            dgLoanDetail.Columns[10].HeaderText = "Note";
            dgLoanDetail.Columns[10].DataPropertyName = "NOTE";
            dgLoanDetail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLoanDetail.Columns[10].Visible = true;
        }
        void LoadLoanDetail()
        {
            int id = Convert.ToInt32(lblId.Text);
            dgLoanDetail.RowHeadersVisible = false;
            dgLoanDetail.AllowUserToAddRows = false;
            dgLoanDetail.Columns[0].DataPropertyName = "LoanDetailId";
            dgLoanDetail.Columns[0].Visible = false;
            dgLoanDetail.Columns[1].DataPropertyName = "LoanId";
            dgLoanDetail.Columns[1].Visible = false;
            dgLoanDetail.Columns[2].DataPropertyName = "PeriodNo";
            dgLoanDetail.Columns[2].Width = 50;
            dgLoanDetail.Columns[2].Visible = true;
            dgLoanDetail.Columns[2].HeaderText = "No";
            dgLoanDetail.Columns[3].HeaderText = "Beginning Balance";
            dgLoanDetail.Columns[3].Width = 200;
            dgLoanDetail.Columns[3].DataPropertyName = "BEGINNINGBALANCE";
            dgLoanDetail.Columns[3].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[3].Visible = true;
            dgLoanDetail.Columns[4].HeaderText = "Principal";
            dgLoanDetail.Columns[4].Width = 150;
            dgLoanDetail.Columns[4].DataPropertyName = "Principle";
            dgLoanDetail.Columns[4].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[4].Visible = true;
            dgLoanDetail.Columns[5].HeaderText = "Interest";
            dgLoanDetail.Columns[5].Width = 150;
            dgLoanDetail.Columns[5].DataPropertyName = "Interest";
            dgLoanDetail.Columns[5].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[5].Visible = true;
            dgLoanDetail.Columns[6].HeaderText = "Payment";
            dgLoanDetail.Columns[6].Width = 150;
            dgLoanDetail.Columns[6].DataPropertyName = "Payment";
            dgLoanDetail.Columns[6].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[6].Visible = true;
            dgLoanDetail.Columns[7].HeaderText = "Ending Balance";
            dgLoanDetail.Columns[7].Width = 200;
            dgLoanDetail.Columns[7].DataPropertyName = "ENDINGBALANCE";
            dgLoanDetail.Columns[7].DefaultCellStyle.Format = cbCurrency.Text == "$" ? "$ #,#00.00" : "R #,#00.00";
            dgLoanDetail.Columns[7].Visible = true;
            dgLoanDetail.Columns[8].HeaderText = "Paid";
            dgLoanDetail.Columns[8].DataPropertyName = "ISPAID";
            DataGridViewCheckBoxColumn column = (DataGridViewCheckBoxColumn)dgLoanDetail.Columns[8];
            column.DataPropertyName = "ISPAID";

            dgLoanDetail.Columns[8].Width = 50;
            dgLoanDetail.Columns[8].Visible = true;
            dgLoanDetail.Columns[9].HeaderText = "Date";
            dgLoanDetail.Columns[9].Width = 200;
            dgLoanDetail.Columns[9].DataPropertyName = "PAIDDATE";
            dgLoanDetail.Columns[9].Visible = true;
            dgLoanDetail.Columns[10].HeaderText = "Note";
            dgLoanDetail.Columns[10].DataPropertyName = "NOTE";
            dgLoanDetail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLoanDetail.Columns[10].Visible = true;
            dgLoanDetail.DataSource = LoanDetails.GetAll(id);
            dt = LoanDetails.GetAll(id);

            if(dgLoanDetail.Rows.Count > 0)
            {
                interest_val = Convert.ToDouble(dgLoanDetail.Rows[0].Cells["Interest"].Value.ToString());
                beginBalance = Convert.ToDouble(dgLoanDetail.Rows[0].Cells["BeginningBalance"].Value.ToString());
                int count = dgLoanDetail.RowCount;
                txtDuration.Text = (count / 12).ToString();

                txtRate.Text = (((interest_val * 100) / beginBalance) * 12).ToString("#,##0.00");

                //totalCostOfLoan = Convert.ToDouble(dgLoanDetail.Rows[0].Cells["Payment"].Value.ToString()) * count;

                totalInterest = 0;
                for (int i = 0; i < count; i++)
                {
                    totalInterest += Convert.ToDouble(dgLoanDetail.Rows[i].Cells["Interest"].Value.ToString());
                    totalCostOfLoan += Convert.ToDouble(dgLoanDetail.Rows[i].Cells["Payment"].Value.ToString());
                }

                lblTotalCostOfLoan.Text = cbCurrency.Text == "R" ? Math.Round(totalCostOfLoan, 2).ToString("R #,##0.00") : Math.Round(totalCostOfLoan, 2).ToString("$ #,##0.00");
                lblNumberOfPayment.Text = count.ToString();
                lblMonthlyPayment.Text = cbCurrency.Text == "R" ? Math.Round(Convert.ToDouble(dgLoanDetail.Rows[0].Cells["Payment"].Value), 2).ToString("R #,##0.00") : Math.Round(Convert.ToDouble(dgLoanDetail.Rows[0].Cells["Payment"].Value), 2).ToString("$ #,##0.00");
                lblTotalInterest.Text = cbCurrency.Text == "R" ? Math.Round(Convert.ToDouble(totalInterest), 2).ToString("R #,##0.00") : Math.Round(Convert.ToDouble(totalInterest), 2).ToString("$ #,##0.00");
            }
            //if(date.Year > DateTime.Now.Year || date.Month > DateTime.Now.Month && date.Day > DateTime.Now.Day && status > 0)
            //{
            //    MessageBox.Show("Hello");
            //}


        }
        bool DoValidation()
        {
            bool result = true;
            if(cbCollateralCode.SelectedIndex < 0)
            {
                epCollateralCode.SetError(cbCollateralCode, "Select CollateralCode");
                result = false;
            }
            else
            {
                epCollateralCode.Clear();
            }
            if(cbCOName.SelectedIndex < 0)
            {
                epCOName.SetError(cbCOName, "Select Credit Officer");
                result = false;
            }
            else
            {
                epCOName.Clear();
            }
            if(cbCurrency.SelectedIndex < 0)
            {
                epCurrency.SetError(cbCurrency, "Select Currency");
                result = false;
            }
            else
            {
                epCurrency.Clear();
            }
            if(cbCustomerName.SelectedIndex < 0)
            {
                epCustomer.SetError(cbCustomerName, "Select Customer");
                result = false;
            }
            else
            {
                epCustomer.Clear();
            }
            if(txtAmount.Text == "")
            {
                epAmount.SetError(txtAmount, "Enter amount value");
                result = false;
            }
            else
            {
                epAmount.Clear();
            }
            if (txtDuration.Text == "")
            {
                epDuration.SetError(txtDuration, "Pls Enter Duration of Year");
                result = false;
            }
            else
            {
                epDuration.Clear();
            }
            if(txtRate.Text == "")
            {
                epRate.SetError(txtRate, "Pls enter annul rate");
                result = false;
            }
            else
            {
                epRate.Clear();
            }
            return result;
        }

        void Clear()
        {
            txtAmount.Clear();
            txtAmount.Clear();
            txtCode.Clear();
            txtDuration.Clear();
            txtMemo.Clear();
            txtPFCode.Clear();
            txtRate.Clear();
            cbCollateralCode.SelectedIndex = 0;
            cbCOName.SelectedIndex = 0;
            cbCurrency.SelectedIndex = 0;
            cbCustomerName.SelectedIndex = 0;
        }
        void EnableControls(bool result)
        {
            cbCollateralCode.Enabled  = result;
            cbCustomerName.Enabled = result;
            cbCollateralCode.Enabled = result;
            cbCOName.Enabled = result;
            cbCurrency.Enabled = result;
            txtAmount.Enabled = result;
            txtCode.Enabled = result;
            txtDuration.Enabled = result;
            txtMemo.Enabled = result;
            txtPFCode.Enabled = result;
            txtRate.Enabled = result;
            dtpLoanDate.Enabled = result;
            btnSave.Enabled = result;
            btnGenerate.Enabled = result;
            dgLoanDetail.ReadOnly = !result;
            dgLoanDetail.Columns[0].ReadOnly = true;
            dgLoanDetail.Columns[1].ReadOnly = true;
            dgLoanDetail.Columns[2].ReadOnly = true;
            dgLoanDetail.Columns[3].ReadOnly = true;
            dgLoanDetail.Columns[4].ReadOnly = true;
            dgLoanDetail.Columns[5].ReadOnly = true;
            dgLoanDetail.Columns[6].ReadOnly = true;
            dgLoanDetail.Columns[7].ReadOnly = true;
            dgLoanDetail.Columns[8].ReadOnly = !result;
            if(liste != 1)
            {
                dgLoanDetail.Columns[9].ReadOnly = true;
                dgLoanDetail.Columns[10].ReadOnly = !result;
            }
        }
    }
}
