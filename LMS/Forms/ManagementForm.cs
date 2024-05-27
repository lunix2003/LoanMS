using LMS.Data;
using LMS.Models;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class ManagementForm : Form
    {
        private DataTable dt;
        private int score;
        private DataTable dtUserPermission;

        public ManagementForm()
        {
            InitializeComponent();
        }


        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableControl(false);
        }

        private void LoadData()
        {

            dgAppUser.DataSource = AppUsers.GetAll();
            dgAppUser.ReadOnly = true;
            dgAppUser.RowHeadersVisible = false;
            dgAppUser.Columns[0].DataPropertyName = "AppUserId";
            dgAppUser.Columns[0].Visible = false;
            dgAppUser.Columns[1].DataPropertyName = "UserName";
            dgAppUser.Columns[1].Visible = true;
            dgAppUser.Columns[1].HeaderText = "User Name";
            dgAppUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgAppUser.Columns[2].DataPropertyName = "Password";
            dgAppUser.Columns[2].Visible = false;
            dgAppUser.Columns[3].DataPropertyName = "IsLog";
            dgAppUser.Columns[3].Visible = false;
            dgAppUser.Columns[4].DataPropertyName = "IsHidden";
            dgAppUser.Columns[4].Visible = false;
            dgAppUser.Columns[5].DataPropertyName = "UserType";
            dgAppUser.Columns[5].Visible = false;
        }
        void LoadPermission()
        {
            if (dgAppUser.SelectedRows.Count > 0)
            {
                int userid = Convert.ToInt32(dgAppUser.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                dtUserPermission = AppUserPermissions.Get(userid);
                foreach (Control control in this.pnPermission.Controls)
                {
                    if (control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
                if (dtUserPermission.Rows.Count > 0)
                {
                    foreach (DataRow row in dtUserPermission.Rows)
                    {
                        CheckBox permission = (CheckBox)this.pnPermission.Controls[row["UserPermission"].ToString()];
                        pnPermission.Controls.Add(permission);
                        if (permission != null)
                            permission.Checked = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }

            AppUser user = new AppUser();
            user.UserName = txtUserName.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            user.IsLog = chIsLog.Checked == true ? 1 : 0;
            user.UserType = cbUserType.Text.Trim();
            if(user != null)
            {
                if (score == 1)
                {
                    int id = AppUsers.Add(user);
                    if (id > 0)
                    {
                        foreach (Control control in this.pnPermission.Controls)
                        {
                            if (control is CheckBox)
                            {
                                bool value = (control as CheckBox).Checked;
                                if (value)
                                {
                                    AppUserPermission permission = new AppUserPermission();
                                    permission.AppUserId = id;
                                    permission.UserPermission = control.Name;
                                    AppUserPermissions.Add(permission);
                                }
                            }
                        }
                        MessageBox.Show("Record has added successfully");
                    }
                }
                else if(score == 2)
                {   
                    int id = Convert.ToInt32(dgAppUser.SelectedRows[0].Cells[0].Value);
                    user.AppUserId = id;
                    if (id > 0)
                    {
                        AppUsers.Update(user);
                        AppUserPermissions.Delete(id);
                        foreach (Control control in this.pnPermission.Controls)
                        {
                            if (control is CheckBox)
                            {
                                bool value = (control as CheckBox).Checked;
                                if (value)
                                {
                                    AppUserPermission permission = new AppUserPermission();
                                    permission.AppUserId = id;
                                    permission.UserPermission = control.Name;
                                    AppUserPermissions.Add(permission);
                                }
                            }
                        }
                        MessageBox.Show("Record has updated successfully");
                    }
                }
                LoadData();
            }
            EnableControl(false);
            btnSave.Enabled = !btnSave.Enabled;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            score = 2;
            EnableControl(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgAppUser.SelectedRows[0].Cells[0].Value);
            if(id > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove this record?", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    AppUsers.Delete(id);
                    MessageBox.Show("Record has Deleted successfully");
                }
                LoadData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            score = 1;
            EnableControl(true);
            Clear();
        }
        void EnableControl(bool result)
        {
            txtUserName.Enabled = result;
            txtPassword.Enabled = result;
            chIsLog.Enabled = result;
            btnSave.Enabled = result;
            cbUserType.Enabled = result;
            //CustomerView.Enabled = result;
            //CustomerModify.Enabled = result;
            //CustomerCreate.Enabled = result;
            //CustomerDelete.Enabled = result;
            //CollateralView.Enabled = result;
            //CollateralModify.Enabled = result;
            //CollateralCreate.Enabled = result;
            //CollateralDelete.Enabled = result;
            //CollateralTypeView.Enabled = result;
            //CollateralTypeModify.Enabled = result;
            //CollateralTypeCreate.Enabled = result;
            //CollateralTypeDelete.Enabled = result;
            //CreditOfficerView.Enabled = result;
            //CreditOfficerModify.Enabled = result;
            //CreditOfficerCreate.Enabled = result;
            //CreditOfficerDelete.Enabled = result;

            foreach (Control control in this.pnPermission.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Enabled = result;
                }
            }
            if (result == false)
            {
                epUsername.Clear();
                epPassword.Clear();
            }

        }
        void Clear()
        {
            EnableControl(true);
            if (score == 1)
            {
                txtUserName.Clear();
                txtPassword.Clear();
                chIsLog.Checked = false;
                cbUserType.Text = string.Empty;
            }
        }

        private void chShowCharater_CheckedChanged(object sender, EventArgs e)
        {
            if(chShowCharater.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        bool CheckValidate()
        {
            bool result = true;
            if (txtUserName.Text == "")
            {
                epUsername.SetError(txtUserName, "Pls enter user name");
                result = false;
            }
            else
            {
                epUsername.Clear();
            }
            if (txtPassword.Text == "")
            {
                epPassword.SetError(txtPassword, "Pls enter Password");
                result = false;
            }
            else
            {
                epPassword.Clear();
            }
            return result;
        }

        private void dgAppUser_SelectionChanged(object sender, EventArgs e)
        {
            pnPermission.BringToFront();
            LoadPermission();
            btnSave.Enabled = false;
            if(dgAppUser.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgAppUser.SelectedRows[0].Cells[0].Value);
                if(id > 0)
                {
                    AppUser user = AppUsers.Get(id);
                    txtPassword.Text = user.Password;
                    txtUserName.Text = user.UserName;
                    chIsLog.Checked = user.IsLog == 0 ? false : true;
                    cbUserType.Text = user.UserType;
                }

            }
            EnableControl(false);
        }


        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
