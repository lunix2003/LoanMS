namespace LMS.Forms
{
    partial class ManagementForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgAppUser = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CollateralTypeDelete = new System.Windows.Forms.CheckBox();
            this.AppUserDelete = new System.Windows.Forms.CheckBox();
            this.CustomerDelete = new System.Windows.Forms.CheckBox();
            this.CollateralDelete = new System.Windows.Forms.CheckBox();
            this.CreditOfficerDelete = new System.Windows.Forms.CheckBox();
            this.LoanDelete = new System.Windows.Forms.CheckBox();
            this.CollateralTypeModify = new System.Windows.Forms.CheckBox();
            this.AppUserModify = new System.Windows.Forms.CheckBox();
            this.CustomerModify = new System.Windows.Forms.CheckBox();
            this.CollateralModify = new System.Windows.Forms.CheckBox();
            this.CreditOfficerModify = new System.Windows.Forms.CheckBox();
            this.LoanModify = new System.Windows.Forms.CheckBox();
            this.CollateralTypeView = new System.Windows.Forms.CheckBox();
            this.AppUserView = new System.Windows.Forms.CheckBox();
            this.CustomerView = new System.Windows.Forms.CheckBox();
            this.CollateralView = new System.Windows.Forms.CheckBox();
            this.CreditOfficerView = new System.Windows.Forms.CheckBox();
            this.LoanView = new System.Windows.Forms.CheckBox();
            this.CollateralTypeCreate = new System.Windows.Forms.CheckBox();
            this.AppUserCreate = new System.Windows.Forms.CheckBox();
            this.CollateralCreate = new System.Windows.Forms.CheckBox();
            this.CreditOfficerCreate = new System.Windows.Forms.CheckBox();
            this.CustomerCreate = new System.Windows.Forms.CheckBox();
            this.LoanCreate = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.chShowCharater = new System.Windows.Forms.CheckBox();
            this.chIsLog = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppUser)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnContent.SuspendLayout();
            this.pnPermission.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 792);
            this.panel2.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgAppUser);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(393, 746);
            this.panel6.TabIndex = 1;
            // 
            // dgAppUser
            // 
            this.dgAppUser.AllowUserToAddRows = false;
            this.dgAppUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAppUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAppUser.Location = new System.Drawing.Point(3, 3);
            this.dgAppUser.Name = "dgAppUser";
            this.dgAppUser.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.dgAppUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAppUser.RowTemplate.Height = 24;
            this.dgAppUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAppUser.Size = new System.Drawing.Size(387, 740);
            this.dgAppUser.TabIndex = 0;
            this.dgAppUser.SelectionChanged += new System.EventHandler(this.dgAppUser_SelectionChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel5.Size = new System.Drawing.Size(393, 46);
            this.panel5.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(131, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(121, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 36);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(260, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 36);
            this.panel7.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(270, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1518, 81);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Management";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = global::LMS.Properties.Resources.iconnavigationclose_24px;
            this.btnClose.Location = new System.Drawing.Point(1451, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.panel9);
            this.pnContent.Controls.Add(this.pnPermission);
            this.pnContent.Controls.Add(this.panel3);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(393, 81);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1125, 792);
            this.pnContent.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 192);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1125, 1);
            this.panel9.TabIndex = 10;
            // 
            // pnPermission
            // 
            this.pnPermission.AutoScroll = true;
            this.pnPermission.Controls.Add(this.label9);
            this.pnPermission.Controls.Add(this.label12);
            this.pnPermission.Controls.Add(this.label7);
            this.pnPermission.Controls.Add(this.label2);
            this.pnPermission.Controls.Add(this.label8);
            this.pnPermission.Controls.Add(this.label10);
            this.pnPermission.Controls.Add(this.label5);
            this.pnPermission.Controls.Add(this.CollateralTypeDelete);
            this.pnPermission.Controls.Add(this.AppUserDelete);
            this.pnPermission.Controls.Add(this.CustomerDelete);
            this.pnPermission.Controls.Add(this.CollateralDelete);
            this.pnPermission.Controls.Add(this.CreditOfficerDelete);
            this.pnPermission.Controls.Add(this.LoanDelete);
            this.pnPermission.Controls.Add(this.CollateralTypeModify);
            this.pnPermission.Controls.Add(this.AppUserModify);
            this.pnPermission.Controls.Add(this.CustomerModify);
            this.pnPermission.Controls.Add(this.CollateralModify);
            this.pnPermission.Controls.Add(this.CreditOfficerModify);
            this.pnPermission.Controls.Add(this.LoanModify);
            this.pnPermission.Controls.Add(this.CollateralTypeView);
            this.pnPermission.Controls.Add(this.AppUserView);
            this.pnPermission.Controls.Add(this.CustomerView);
            this.pnPermission.Controls.Add(this.CollateralView);
            this.pnPermission.Controls.Add(this.CreditOfficerView);
            this.pnPermission.Controls.Add(this.LoanView);
            this.pnPermission.Controls.Add(this.CollateralTypeCreate);
            this.pnPermission.Controls.Add(this.AppUserCreate);
            this.pnPermission.Controls.Add(this.CollateralCreate);
            this.pnPermission.Controls.Add(this.CreditOfficerCreate);
            this.pnPermission.Controls.Add(this.CustomerCreate);
            this.pnPermission.Controls.Add(this.LoanCreate);
            this.pnPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPermission.Location = new System.Drawing.Point(0, 192);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Padding = new System.Windows.Forms.Padding(10);
            this.pnPermission.Size = new System.Drawing.Size(1125, 600);
            this.pnPermission.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(90, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Form CollateralType";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label12.Location = new System.Drawing.Point(90, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 31);
            this.label12.TabIndex = 3;
            this.label12.Text = "Form Manage User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(90, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Form Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permissions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(92, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Form Collateral";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label10.Location = new System.Drawing.Point(92, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 31);
            this.label10.TabIndex = 3;
            this.label10.Text = "Form Credit Officer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(92, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Form Loan";
            // 
            // CollateralTypeDelete
            // 
            this.CollateralTypeDelete.AutoSize = true;
            this.CollateralTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralTypeDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralTypeDelete.Location = new System.Drawing.Point(737, 377);
            this.CollateralTypeDelete.Name = "CollateralTypeDelete";
            this.CollateralTypeDelete.Size = new System.Drawing.Size(80, 29);
            this.CollateralTypeDelete.TabIndex = 6;
            this.CollateralTypeDelete.Text = "Delete";
            this.CollateralTypeDelete.UseVisualStyleBackColor = true;
            // 
            // AppUserDelete
            // 
            this.AppUserDelete.AutoSize = true;
            this.AppUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppUserDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppUserDelete.Location = new System.Drawing.Point(737, 549);
            this.AppUserDelete.Name = "AppUserDelete";
            this.AppUserDelete.Size = new System.Drawing.Size(80, 29);
            this.AppUserDelete.TabIndex = 6;
            this.AppUserDelete.Text = "Delete";
            this.AppUserDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSize = true;
            this.CustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDelete.Location = new System.Drawing.Point(737, 194);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(80, 29);
            this.CustomerDelete.TabIndex = 6;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CollateralDelete
            // 
            this.CollateralDelete.AutoSize = true;
            this.CollateralDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralDelete.Location = new System.Drawing.Point(739, 291);
            this.CollateralDelete.Name = "CollateralDelete";
            this.CollateralDelete.Size = new System.Drawing.Size(80, 29);
            this.CollateralDelete.TabIndex = 6;
            this.CollateralDelete.Text = "Delete";
            this.CollateralDelete.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerDelete
            // 
            this.CreditOfficerDelete.AutoSize = true;
            this.CreditOfficerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditOfficerDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditOfficerDelete.Location = new System.Drawing.Point(739, 463);
            this.CreditOfficerDelete.Name = "CreditOfficerDelete";
            this.CreditOfficerDelete.Size = new System.Drawing.Size(80, 29);
            this.CreditOfficerDelete.TabIndex = 6;
            this.CreditOfficerDelete.Text = "Delete";
            this.CreditOfficerDelete.UseVisualStyleBackColor = true;
            // 
            // LoanDelete
            // 
            this.LoanDelete.AutoSize = true;
            this.LoanDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanDelete.Location = new System.Drawing.Point(739, 108);
            this.LoanDelete.Name = "LoanDelete";
            this.LoanDelete.Size = new System.Drawing.Size(80, 29);
            this.LoanDelete.TabIndex = 6;
            this.LoanDelete.Text = "Delete";
            this.LoanDelete.UseVisualStyleBackColor = true;
            // 
            // CollateralTypeModify
            // 
            this.CollateralTypeModify.AutoSize = true;
            this.CollateralTypeModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralTypeModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralTypeModify.Location = new System.Drawing.Point(515, 377);
            this.CollateralTypeModify.Name = "CollateralTypeModify";
            this.CollateralTypeModify.Size = new System.Drawing.Size(87, 29);
            this.CollateralTypeModify.TabIndex = 6;
            this.CollateralTypeModify.Text = "Modify";
            this.CollateralTypeModify.UseVisualStyleBackColor = true;
            // 
            // AppUserModify
            // 
            this.AppUserModify.AutoSize = true;
            this.AppUserModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppUserModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppUserModify.Location = new System.Drawing.Point(515, 549);
            this.AppUserModify.Name = "AppUserModify";
            this.AppUserModify.Size = new System.Drawing.Size(87, 29);
            this.AppUserModify.TabIndex = 6;
            this.AppUserModify.Text = "Modify";
            this.AppUserModify.UseVisualStyleBackColor = true;
            // 
            // CustomerModify
            // 
            this.CustomerModify.AutoSize = true;
            this.CustomerModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerModify.Location = new System.Drawing.Point(515, 194);
            this.CustomerModify.Name = "CustomerModify";
            this.CustomerModify.Size = new System.Drawing.Size(87, 29);
            this.CustomerModify.TabIndex = 6;
            this.CustomerModify.Text = "Modify";
            this.CustomerModify.UseVisualStyleBackColor = true;
            // 
            // CollateralModify
            // 
            this.CollateralModify.AutoSize = true;
            this.CollateralModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralModify.Location = new System.Drawing.Point(517, 291);
            this.CollateralModify.Name = "CollateralModify";
            this.CollateralModify.Size = new System.Drawing.Size(87, 29);
            this.CollateralModify.TabIndex = 6;
            this.CollateralModify.Text = "Modify";
            this.CollateralModify.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerModify
            // 
            this.CreditOfficerModify.AutoSize = true;
            this.CreditOfficerModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditOfficerModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditOfficerModify.Location = new System.Drawing.Point(517, 463);
            this.CreditOfficerModify.Name = "CreditOfficerModify";
            this.CreditOfficerModify.Size = new System.Drawing.Size(87, 29);
            this.CreditOfficerModify.TabIndex = 6;
            this.CreditOfficerModify.Text = "Modify";
            this.CreditOfficerModify.UseVisualStyleBackColor = true;
            // 
            // LoanModify
            // 
            this.LoanModify.AutoSize = true;
            this.LoanModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanModify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanModify.Location = new System.Drawing.Point(517, 108);
            this.LoanModify.Name = "LoanModify";
            this.LoanModify.Size = new System.Drawing.Size(87, 29);
            this.LoanModify.TabIndex = 6;
            this.LoanModify.Text = "Modify";
            this.LoanModify.UseVisualStyleBackColor = true;
            // 
            // CollateralTypeView
            // 
            this.CollateralTypeView.AutoSize = true;
            this.CollateralTypeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralTypeView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralTypeView.Location = new System.Drawing.Point(331, 377);
            this.CollateralTypeView.Name = "CollateralTypeView";
            this.CollateralTypeView.Size = new System.Drawing.Size(67, 29);
            this.CollateralTypeView.TabIndex = 6;
            this.CollateralTypeView.Text = "View";
            this.CollateralTypeView.UseVisualStyleBackColor = true;
            // 
            // AppUserView
            // 
            this.AppUserView.AutoSize = true;
            this.AppUserView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppUserView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppUserView.Location = new System.Drawing.Point(331, 549);
            this.AppUserView.Name = "AppUserView";
            this.AppUserView.Size = new System.Drawing.Size(67, 29);
            this.AppUserView.TabIndex = 6;
            this.AppUserView.Text = "View";
            this.AppUserView.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.CustomerView.AutoSize = true;
            this.CustomerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerView.Location = new System.Drawing.Point(331, 194);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(67, 29);
            this.CustomerView.TabIndex = 6;
            this.CustomerView.Text = "View";
            this.CustomerView.UseVisualStyleBackColor = true;
            // 
            // CollateralView
            // 
            this.CollateralView.AutoSize = true;
            this.CollateralView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralView.Location = new System.Drawing.Point(333, 291);
            this.CollateralView.Name = "CollateralView";
            this.CollateralView.Size = new System.Drawing.Size(67, 29);
            this.CollateralView.TabIndex = 6;
            this.CollateralView.Text = "View";
            this.CollateralView.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerView
            // 
            this.CreditOfficerView.AutoSize = true;
            this.CreditOfficerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditOfficerView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditOfficerView.Location = new System.Drawing.Point(333, 463);
            this.CreditOfficerView.Name = "CreditOfficerView";
            this.CreditOfficerView.Size = new System.Drawing.Size(67, 29);
            this.CreditOfficerView.TabIndex = 6;
            this.CreditOfficerView.Text = "View";
            this.CreditOfficerView.UseVisualStyleBackColor = true;
            // 
            // LoanView
            // 
            this.LoanView.AutoSize = true;
            this.LoanView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanView.Location = new System.Drawing.Point(333, 108);
            this.LoanView.Name = "LoanView";
            this.LoanView.Size = new System.Drawing.Size(67, 29);
            this.LoanView.TabIndex = 6;
            this.LoanView.Text = "View";
            this.LoanView.UseVisualStyleBackColor = true;
            // 
            // CollateralTypeCreate
            // 
            this.CollateralTypeCreate.AutoSize = true;
            this.CollateralTypeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralTypeCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralTypeCreate.Location = new System.Drawing.Point(128, 377);
            this.CollateralTypeCreate.Name = "CollateralTypeCreate";
            this.CollateralTypeCreate.Size = new System.Drawing.Size(80, 29);
            this.CollateralTypeCreate.TabIndex = 6;
            this.CollateralTypeCreate.Text = "Create";
            this.CollateralTypeCreate.UseVisualStyleBackColor = true;
            // 
            // AppUserCreate
            // 
            this.AppUserCreate.AutoSize = true;
            this.AppUserCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppUserCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppUserCreate.Location = new System.Drawing.Point(128, 549);
            this.AppUserCreate.Name = "AppUserCreate";
            this.AppUserCreate.Size = new System.Drawing.Size(80, 29);
            this.AppUserCreate.TabIndex = 6;
            this.AppUserCreate.Text = "Create";
            this.AppUserCreate.UseVisualStyleBackColor = true;
            // 
            // CollateralCreate
            // 
            this.CollateralCreate.AutoSize = true;
            this.CollateralCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollateralCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollateralCreate.Location = new System.Drawing.Point(130, 291);
            this.CollateralCreate.Name = "CollateralCreate";
            this.CollateralCreate.Size = new System.Drawing.Size(80, 29);
            this.CollateralCreate.TabIndex = 6;
            this.CollateralCreate.Text = "Create";
            this.CollateralCreate.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerCreate
            // 
            this.CreditOfficerCreate.AutoSize = true;
            this.CreditOfficerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditOfficerCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditOfficerCreate.Location = new System.Drawing.Point(130, 463);
            this.CreditOfficerCreate.Name = "CreditOfficerCreate";
            this.CreditOfficerCreate.Size = new System.Drawing.Size(80, 29);
            this.CreditOfficerCreate.TabIndex = 6;
            this.CreditOfficerCreate.Text = "Create";
            this.CreditOfficerCreate.UseVisualStyleBackColor = true;
            // 
            // CustomerCreate
            // 
            this.CustomerCreate.AutoSize = true;
            this.CustomerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCreate.Location = new System.Drawing.Point(128, 194);
            this.CustomerCreate.Name = "CustomerCreate";
            this.CustomerCreate.Size = new System.Drawing.Size(80, 29);
            this.CustomerCreate.TabIndex = 6;
            this.CustomerCreate.Text = "Create";
            this.CustomerCreate.UseVisualStyleBackColor = true;
            // 
            // LoanCreate
            // 
            this.LoanCreate.AutoSize = true;
            this.LoanCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanCreate.Location = new System.Drawing.Point(130, 108);
            this.LoanCreate.Name = "LoanCreate";
            this.LoanCreate.Size = new System.Drawing.Size(80, 29);
            this.LoanCreate.TabIndex = 6;
            this.LoanCreate.Text = "Create";
            this.LoanCreate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbUserType);
            this.panel3.Controls.Add(this.chShowCharater);
            this.panel3.Controls.Add(this.chIsLog);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 192);
            this.panel3.TabIndex = 8;
            // 
            // cbUserType
            // 
            this.cbUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUserType.Enabled = false;
            this.cbUserType.Font = new System.Drawing.Font("Garamond", 12F);
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbUserType.Location = new System.Drawing.Point(713, 49);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(391, 30);
            this.cbUserType.TabIndex = 9;
            // 
            // chShowCharater
            // 
            this.chShowCharater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chShowCharater.AutoSize = true;
            this.chShowCharater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chShowCharater.Location = new System.Drawing.Point(601, 79);
            this.chShowCharater.Name = "chShowCharater";
            this.chShowCharater.Size = new System.Drawing.Size(14, 13);
            this.chShowCharater.TabIndex = 6;
            this.chShowCharater.UseVisualStyleBackColor = true;
            this.chShowCharater.CheckedChanged += new System.EventHandler(this.chShowCharater_CheckedChanged);
            // 
            // chIsLog
            // 
            this.chIsLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chIsLog.AutoSize = true;
            this.chIsLog.Enabled = false;
            this.chIsLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chIsLog.Location = new System.Drawing.Point(249, 124);
            this.chIsLog.Name = "chIsLog";
            this.chIsLog.Size = new System.Drawing.Size(14, 13);
            this.chIsLog.TabIndex = 6;
            this.chIsLog.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(499, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(85, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtPassword.Location = new System.Drawing.Point(249, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(371, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(682, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "User Type :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(85, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Is Log :";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtUserName.Location = new System.Drawing.Point(249, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(371, 30);
            this.txtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(85, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name :";
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 873);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppUser)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnPermission.ResumeLayout(false);
            this.pnPermission.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgAppUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnPermission;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chShowCharater;
        private System.Windows.Forms.CheckBox chIsLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CollateralTypeDelete;
        private System.Windows.Forms.CheckBox CustomerDelete;
        private System.Windows.Forms.CheckBox CollateralDelete;
        private System.Windows.Forms.CheckBox LoanDelete;
        private System.Windows.Forms.CheckBox CollateralTypeModify;
        private System.Windows.Forms.CheckBox CustomerModify;
        private System.Windows.Forms.CheckBox CollateralModify;
        private System.Windows.Forms.CheckBox LoanModify;
        private System.Windows.Forms.CheckBox CollateralTypeView;
        private System.Windows.Forms.CheckBox CustomerView;
        private System.Windows.Forms.CheckBox CollateralView;
        private System.Windows.Forms.CheckBox LoanView;
        private System.Windows.Forms.CheckBox CollateralTypeCreate;
        private System.Windows.Forms.CheckBox CollateralCreate;
        private System.Windows.Forms.CheckBox CustomerCreate;
        private System.Windows.Forms.CheckBox LoanCreate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AppUserDelete;
        private System.Windows.Forms.CheckBox CreditOfficerDelete;
        private System.Windows.Forms.CheckBox AppUserModify;
        private System.Windows.Forms.CheckBox CreditOfficerModify;
        private System.Windows.Forms.CheckBox AppUserView;
        private System.Windows.Forms.CheckBox CreditOfficerView;
        private System.Windows.Forms.CheckBox AppUserCreate;
        private System.Windows.Forms.CheckBox CreditOfficerCreate;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbUserType;
    }
}