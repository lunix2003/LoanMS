using LMS.Data;
using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace LMS.Forms
{
    public partial class CreditOfficer : Form
    {
        private BindingSource bsCreditOfficer;
        private int score;

        public CreditOfficer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }
            Models.CreditOfficer co = new Models.CreditOfficer();
            co.CreditOfficerName = txtCOName.Text.Trim();
            co.Sex = SetGender();
            co.DoB = dtpDoB.Value;
            co.PoB = txtPoB.Text.Trim();
            co.Phone = txtPhone.Text.Trim();
            co.Email = txtEmail.Text.Trim();
            if (score == 1)
            {
                try
                {

                    CreditOfficers.Add(co);
                    MessageBox.Show("Record is saving!.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception is " + ex.Message);
                }
            }
            else if (score == 2)
            {
                int id = int.Parse(dgCreditOfficer.SelectedRows[0].Cells[0].Value.ToString());
                if (id > 0)
                {
                    try
                    {
                        co.CreditOfficerId = id;
                        CreditOfficers.Update(co);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Record is Updating!.");
            }
            else
            {
                MessageBox.Show("the system is erroring!.");
                return;
            }


            EnableControl(false);
            btnSave.Enabled = false;
            CreditOfficer_Load(null, null);

        }

        private void CreditOfficer_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = CreditOfficers.GetAll();
            bsCreditOfficer = new BindingSource();

            dgCreditOfficer.DataSource = dt;
            bsCreditOfficer.DataSource = dt;


            Setup();
        }
        void Setup()
        {
            dgCreditOfficer.ReadOnly = true;
            dgCreditOfficer.RowHeadersVisible = false;
            dgCreditOfficer.Columns[0].DataPropertyName = "CreditOfficerID";
            dgCreditOfficer.Columns[0].Visible = false;
            dgCreditOfficer.Columns[1].DataPropertyName = "CreditOfficerName";
            dgCreditOfficer.Columns[1].Visible = true;
            dgCreditOfficer.Columns[1].HeaderText = "CreditOfficer Name";
            dgCreditOfficer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCreditOfficer.Columns[2].DataPropertyName = "Sex";
            dgCreditOfficer.Columns[2].Visible = false;
            dgCreditOfficer.Columns[3].DataPropertyName = "DOB";
            dgCreditOfficer.Columns[3].Visible = false;
            dgCreditOfficer.Columns[4].DataPropertyName = "POB";
            dgCreditOfficer.Columns[4].Visible = false;
            dgCreditOfficer.Columns[5].DataPropertyName = "Phone";
            dgCreditOfficer.Columns[5].Visible = false;
            dgCreditOfficer.Columns[6].DataPropertyName = "Email";
            dgCreditOfficer.Columns[6].Visible = false;
            dgCreditOfficer.Columns[7].DataPropertyName = "ishidden";
            dgCreditOfficer.Columns[7].Visible = false;
        }

        void EnableControl(bool result)
        {
            txtCOName.Enabled = result;
            txtPoB.Enabled = result;
            txtPhone.Enabled = result;
            txtEmail.Enabled = result;
            dtpDoB.Enabled = result;
            rdFemale.Enabled = result;
            rdMale.Enabled = result;
            if (result == false)
            {
                epCOName.Clear();
                epPoB.Clear();
                epPhone.Clear();
                epGender.Clear();
                epDateOfBirth.Clear();
            }
            

        }
        void Clear()
        {
            EnableControl(true);
            if (score == 1)
            {
                txtCOName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtPoB.Clear();
                dtpDoB.Value = DateTime.Now.Date;
                rdMale.Checked = false;
                rdFemale.Checked = false;
            }
        }
        bool CheckValidate()
        {
            bool result = true;
            if (txtCOName.Text == "")
            {
                epCOName.SetError(txtCOName, "Pls enter credit officer name");
                result = false;
            }
            else
            {
                epCOName.Clear();
            }
            if (txtPhone.Text == "")
            {
                epPhone.SetError(txtPhone, "Pls enter Phone Number");
                result = false;
            }
            else
            {
                epPhone.Clear();
            }
            if (txtPoB.Text == "")
            {
                epPoB.SetError(txtPoB, "Pls enter place of birth");
                result = false;
            }
            else
            {
                epPoB.Clear();
            }
            if (dtpDoB.Value.Date == DateTime.Now.Date)
            {
                epDateOfBirth.SetError(dtpDoB, "Pls select date of birth");
                result = false;
            }
            else
            {
                epDateOfBirth.Clear();
            }
            return result;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCreditOfficer.SelectedRows[0].Cells[0].Value.ToString());
            if (id > 0)
            {
                try
                {
                    CreditOfficers.Delete(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Record is Deleting!.");
            }
            CreditOfficer_Load(null, null);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            score = 2;
            btnSave.Enabled = true;
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
            Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            score = 1;
            btnSave.Enabled = true;
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
            Clear();
        }

        private void dgCreditOfficer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControl(false);
            btnSave.Enabled = false;

            int id = int.Parse(dgCreditOfficer.SelectedRows[0].Cells[0].Value.ToString());
            Models.CreditOfficer co = CreditOfficers.Get(id);
            if (co != null)
            {
                txtCOName.Text = co.CreditOfficerName;
                txtEmail.Text = co.Email;
                txtPhone.Text = co.Phone;
                txtPoB.Text = co.PoB;
                GetGender(co.Sex);
                dtpDoB.Value = co.DoB;
            }
        }

        void GetGender(char gender)
        {
            if (gender == 'F')
            {
                rdFemale.Checked = true;
            }
            else
            {
                rdMale.Checked = true;
            }
        }

        char SetGender()
        {
            char gender;
            if (rdFemale.Checked)
            {
                gender = 'F';
            }
            else
            {
                gender = 'M';
            }
            return gender;
        }
    }
}
