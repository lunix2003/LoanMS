namespace LMS.Forms
{
    partial class LoanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCOName = new System.Windows.Forms.ComboBox();
            this.cbCollateralCode = new System.Windows.Forms.ComboBox();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPFCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgLoanDetail = new System.Windows.Forms.DataGridView();
            this.LoanDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lbtotalcost = new System.Windows.Forms.Label();
            this.lbtotalinterest = new System.Windows.Forms.Label();
            this.lbnumberofpayment = new System.Windows.Forms.Label();
            this.lblTotalCostOfLoan = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblNumberOfPayment = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lbmonthly = new System.Windows.Forms.Label();
            this.btnleft = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.epCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCollateralCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCOName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCurrency = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanDetail)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCollateralCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cbCOName);
            this.panel3.Controls.Add(this.cbCollateralCode);
            this.panel3.Controls.Add(this.cbCustomerName);
            this.panel3.Controls.Add(this.cbCurrency);
            this.panel3.Controls.Add(this.dtpLoanDate);
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.txtDuration);
            this.panel3.Controls.Add(this.txtRate);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMemo);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.txtPFCode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1574, 369);
            this.panel3.TabIndex = 12;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(65, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 22);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "0";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(15, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "ID :";
            // 
            // cbCOName
            // 
            this.cbCOName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCOName.Enabled = false;
            this.cbCOName.Font = new System.Drawing.Font("Garamond", 12F);
            this.cbCOName.FormattingEnabled = true;
            this.cbCOName.Location = new System.Drawing.Point(387, 143);
            this.cbCOName.Name = "cbCOName";
            this.cbCOName.Size = new System.Drawing.Size(391, 30);
            this.cbCOName.TabIndex = 10;
            // 
            // cbCollateralCode
            // 
            this.cbCollateralCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCollateralCode.Enabled = false;
            this.cbCollateralCode.Font = new System.Drawing.Font("Garamond", 12F);
            this.cbCollateralCode.FormattingEnabled = true;
            this.cbCollateralCode.Location = new System.Drawing.Point(387, 95);
            this.cbCollateralCode.Name = "cbCollateralCode";
            this.cbCollateralCode.Size = new System.Drawing.Size(391, 30);
            this.cbCollateralCode.TabIndex = 9;
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCustomerName.Enabled = false;
            this.cbCustomerName.Font = new System.Drawing.Font("Garamond", 12F);
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(387, 43);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(391, 30);
            this.cbCustomerName.TabIndex = 8;
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCurrency.Enabled = false;
            this.cbCurrency.Font = new System.Drawing.Font("Garamond", 12F);
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "$",
            "R"});
            this.cbCurrency.Location = new System.Drawing.Point(1019, 92);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(391, 30);
            this.cbCurrency.TabIndex = 7;
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpLoanDate.Enabled = false;
            this.dtpLoanDate.Font = new System.Drawing.Font("Garamond", 12F);
            this.dtpLoanDate.Location = new System.Drawing.Point(1019, 43);
            this.dtpLoanDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtpLoanDate.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(391, 30);
            this.dtpLoanDate.TabIndex = 6;
            this.dtpLoanDate.Value = new System.DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(657, 317);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 35);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(444, 317);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(305, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnNew.Enabled = false;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(167, 317);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 35);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtDuration.Location = new System.Drawing.Point(715, 250);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(63, 30);
            this.txtDuration.TabIndex = 3;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtRate.Location = new System.Drawing.Point(387, 250);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(79, 30);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtCode.Location = new System.Drawing.Point(387, 194);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(391, 30);
            this.txtCode.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(491, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loan Period In (Year) :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(141, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Collateral Code :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(141, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annual Interest Rate(%) :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(141, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Code :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(141, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "CO Name :";
            // 
            // txtMemo
            // 
            this.txtMemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemo.Enabled = false;
            this.txtMemo.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtMemo.Location = new System.Drawing.Point(1019, 245);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(391, 107);
            this.txtMemo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label12.Location = new System.Drawing.Point(863, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Memo :";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtAmount.Location = new System.Drawing.Point(1019, 143);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(391, 30);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtPFCode
            // 
            this.txtPFCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPFCode.Enabled = false;
            this.txtPFCode.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtPFCode.Location = new System.Drawing.Point(1019, 194);
            this.txtPFCode.Name = "txtPFCode";
            this.txtPFCode.Size = new System.Drawing.Size(391, 30);
            this.txtPFCode.TabIndex = 3;
            this.txtPFCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label10.Location = new System.Drawing.Point(863, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(863, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "PFCode :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(863, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Currency :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(863, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(141, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 81);
            this.panel1.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = global::LMS.Properties.Resources.iconnavigationclose_24px;
            this.btnClose.Location = new System.Drawing.Point(1507, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1574, 2);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1574, 55);
            this.panel4.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label13.Location = new System.Drawing.Point(681, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 38);
            this.label13.TabIndex = 0;
            this.label13.Text = "Repayment Schedule";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgLoanDetail);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 507);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(1574, 274);
            this.panel5.TabIndex = 15;
            // 
            // dgLoanDetail
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nokora", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLoanDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLoanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanDetailId,
            this.LoanId,
            this.Period,
            this.BeginningBalance,
            this.Principle,
            this.Interest,
            this.Payment,
            this.EndingBalance,
            this.IsPaid,
            this.PaidDate,
            this.Note});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLoanDetail.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgLoanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLoanDetail.Location = new System.Drawing.Point(4, 4);
            this.dgLoanDetail.Name = "dgLoanDetail";
            this.dgLoanDetail.ReadOnly = true;
            this.dgLoanDetail.RowHeadersVisible = false;
            this.dgLoanDetail.RowHeadersWidth = 51;
            this.dgLoanDetail.RowTemplate.Height = 24;
            this.dgLoanDetail.Size = new System.Drawing.Size(1566, 266);
            this.dgLoanDetail.TabIndex = 0;
            // 
            // LoanDetailId
            // 
            this.LoanDetailId.HeaderText = "LoanDetailId";
            this.LoanDetailId.MinimumWidth = 6;
            this.LoanDetailId.Name = "LoanDetailId";
            this.LoanDetailId.ReadOnly = true;
            this.LoanDetailId.Width = 125;
            // 
            // LoanId
            // 
            this.LoanId.HeaderText = "LoanId";
            this.LoanId.MinimumWidth = 6;
            this.LoanId.Name = "LoanId";
            this.LoanId.ReadOnly = true;
            this.LoanId.Width = 125;
            // 
            // Period
            // 
            this.Period.HeaderText = "Period";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.Width = 125;
            // 
            // BeginningBalance
            // 
            this.BeginningBalance.HeaderText = "Begin";
            this.BeginningBalance.MinimumWidth = 6;
            this.BeginningBalance.Name = "BeginningBalance";
            this.BeginningBalance.ReadOnly = true;
            this.BeginningBalance.Width = 125;
            // 
            // Principle
            // 
            this.Principle.HeaderText = "Principle";
            this.Principle.MinimumWidth = 6;
            this.Principle.Name = "Principle";
            this.Principle.ReadOnly = true;
            this.Principle.Width = 125;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.MinimumWidth = 6;
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            this.Interest.Width = 125;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 125;
            // 
            // EndingBalance
            // 
            this.EndingBalance.HeaderText = "Ending";
            this.EndingBalance.MinimumWidth = 6;
            this.EndingBalance.Name = "EndingBalance";
            this.EndingBalance.ReadOnly = true;
            this.EndingBalance.Width = 125;
            // 
            // IsPaid
            // 
            this.IsPaid.HeaderText = "Paid";
            this.IsPaid.MinimumWidth = 6;
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            this.IsPaid.Width = 125;
            // 
            // PaidDate
            // 
            this.PaidDate.HeaderText = "Date";
            this.PaidDate.MinimumWidth = 6;
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.ReadOnly = true;
            this.PaidDate.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.lbtotalcost);
            this.panel6.Controls.Add(this.lbtotalinterest);
            this.panel6.Controls.Add(this.lbnumberofpayment);
            this.panel6.Controls.Add(this.lblTotalCostOfLoan);
            this.panel6.Controls.Add(this.lblTotalInterest);
            this.panel6.Controls.Add(this.lblNumberOfPayment);
            this.panel6.Controls.Add(this.lblMonthlyPayment);
            this.panel6.Controls.Add(this.lbmonthly);
            this.panel6.Controls.Add(this.btnleft);
            this.panel6.Controls.Add(this.btnRight);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 781);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1574, 55);
            this.panel6.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1749, 419);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "<   >";
            // 
            // lbtotalcost
            // 
            this.lbtotalcost.AutoSize = true;
            this.lbtotalcost.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lbtotalcost.Location = new System.Drawing.Point(985, 22);
            this.lbtotalcost.Name = "lbtotalcost";
            this.lbtotalcost.Size = new System.Drawing.Size(185, 22);
            this.lbtotalcost.TabIndex = 9;
            this.lbtotalcost.Text = "Total Cost Of Loan :";
            // 
            // lbtotalinterest
            // 
            this.lbtotalinterest.AutoSize = true;
            this.lbtotalinterest.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lbtotalinterest.Location = new System.Drawing.Point(684, 21);
            this.lbtotalinterest.Name = "lbtotalinterest";
            this.lbtotalinterest.Size = new System.Drawing.Size(135, 22);
            this.lbtotalinterest.TabIndex = 9;
            this.lbtotalinterest.Text = "Total Interest :";
            // 
            // lbnumberofpayment
            // 
            this.lbnumberofpayment.AutoSize = true;
            this.lbnumberofpayment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lbnumberofpayment.Location = new System.Drawing.Point(355, 21);
            this.lbnumberofpayment.Name = "lbnumberofpayment";
            this.lbnumberofpayment.Size = new System.Drawing.Size(196, 22);
            this.lbnumberofpayment.TabIndex = 9;
            this.lbnumberofpayment.Text = "Number Of Payment :";
            // 
            // lblTotalCostOfLoan
            // 
            this.lblTotalCostOfLoan.AutoSize = true;
            this.lblTotalCostOfLoan.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCostOfLoan.Location = new System.Drawing.Point(1185, 22);
            this.lblTotalCostOfLoan.Name = "lblTotalCostOfLoan";
            this.lblTotalCostOfLoan.Size = new System.Drawing.Size(42, 22);
            this.lblTotalCostOfLoan.TabIndex = 8;
            this.lblTotalCostOfLoan.Text = "0.00";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalInterest.Location = new System.Drawing.Point(837, 22);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(42, 22);
            this.lblTotalInterest.TabIndex = 8;
            this.lblTotalInterest.Text = "0.00";
            // 
            // lblNumberOfPayment
            // 
            this.lblNumberOfPayment.AutoSize = true;
            this.lblNumberOfPayment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfPayment.Location = new System.Drawing.Point(583, 22);
            this.lblNumberOfPayment.Name = "lblNumberOfPayment";
            this.lblNumberOfPayment.Size = new System.Drawing.Size(42, 22);
            this.lblNumberOfPayment.TabIndex = 8;
            this.lblNumberOfPayment.Text = "0.00";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPayment.Location = new System.Drawing.Point(218, 22);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(42, 22);
            this.lblMonthlyPayment.TabIndex = 8;
            this.lblMonthlyPayment.Text = "0.00";
            // 
            // lbmonthly
            // 
            this.lbmonthly.AutoSize = true;
            this.lbmonthly.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.lbmonthly.Location = new System.Drawing.Point(32, 21);
            this.lbmonthly.Name = "lbmonthly";
            this.lbmonthly.Size = new System.Drawing.Size(169, 22);
            this.lbmonthly.TabIndex = 8;
            this.lbmonthly.Text = "Monthly Payment :";
            // 
            // btnleft
            // 
            this.btnleft.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnleft.Image = global::LMS.Properties.Resources.iconnavigationchevron_left_24px;
            this.btnleft.Location = new System.Drawing.Point(1325, 13);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(39, 35);
            this.btnleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnleft.TabIndex = 7;
            this.btnleft.TabStop = false;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRight.Image = global::LMS.Properties.Resources.iconnavigationchevron_right_24px;
            this.btnRight.Location = new System.Drawing.Point(1380, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(39, 35);
            this.btnRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRight.TabIndex = 6;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1441, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epCustomer
            // 
            this.epCustomer.ContainerControl = this;
            // 
            // epCollateralCode
            // 
            this.epCollateralCode.ContainerControl = this;
            // 
            // epCOName
            // 
            this.epCOName.ContainerControl = this;
            // 
            // epRate
            // 
            this.epRate.ContainerControl = this;
            // 
            // epDuration
            // 
            this.epDuration.ContainerControl = this;
            // 
            // epCurrency
            // 
            this.epCurrency.ContainerControl = this;
            // 
            // epAmount
            // 
            this.epAmount.ContainerControl = this;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 836);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanForm";
            this.Text = "Loan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Loan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanDetail)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCollateralCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPFCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ComboBox cbCOName;
        private System.Windows.Forms.ComboBox cbCollateralCode;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox btnRight;
        private System.Windows.Forms.PictureBox btnleft;
        private System.Windows.Forms.Label lbtotalcost;
        private System.Windows.Forms.Label lbtotalinterest;
        private System.Windows.Forms.Label lbnumberofpayment;
        private System.Windows.Forms.Label lbmonthly;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTotalCostOfLoan;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblNumberOfPayment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider epCustomer;
        private System.Windows.Forms.ErrorProvider epCollateralCode;
        private System.Windows.Forms.ErrorProvider epCOName;
        private System.Windows.Forms.ErrorProvider epRate;
        private System.Windows.Forms.ErrorProvider epDuration;
        private System.Windows.Forms.ErrorProvider epCurrency;
        private System.Windows.Forms.ErrorProvider epAmount;
        private System.Windows.Forms.DataGridView dgLoanDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingBalance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}