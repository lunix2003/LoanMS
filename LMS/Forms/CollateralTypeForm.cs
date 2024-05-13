using LMS.Data;
using LMS.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace LMS.Forms
{
    public partial class CollateralTypeForm : Form
    {
        public CollateralTypeForm()
        {
            InitializeComponent();
        }
        int number = 0;
        private BindingSource bsCollateralType;
        private int score;

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
            Models.CollateralType co = new Models.CollateralType();
            co.CollateralTypeName = txtCollateralTypeName.Text.Trim();
            if (score == 1)
            {
                try
                {

                   CollateralTypes.Add(co);
                    MessageBox.Show("Record is saving!.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception is " + ex.Message);
                }
            }
            else if (score == 2)
            {
                int id = int.Parse(dgCollateralType.SelectedRows[0].Cells[0].Value.ToString());
                if (id > 0)
                {
                    try
                    {
                        co.CollateralTypeId = id;
                        CollateralTypes.Update(co);
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
            CollateralTypeForm_Load(null, null);
        }
        bool CheckValidate()
        {
            bool result = true;
            if (txtCollateralTypeName.Text == "")
            {
                eoCollateralTypeName.SetError(txtCollateralTypeName, "Pls enter collateral type name");
                result = false;
            }
            else
            {
                eoCollateralTypeName.Clear();
            }
            
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgCollateralType.SelectedRows[0].Cells[0].Value.ToString());
            if(id > 0)
            {
                CollateralTypes.Delete(id);
                MessageBox.Show("Updating is success");
            }
            CollateralTypeForm_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            score = 2;
            EnableControl(true);
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            score = 1;
            EnableControl(true);
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
            Clear();
        }
        void Clear()
        {
            if (score == 1)
            {
                txtCollateralTypeName.Clear();
            }
        }
        void EnableControl(bool result)
        {
            txtCollateralTypeName.Enabled = result;
            btnSave.Enabled = result;
            if (result == false)
            {
                eoCollateralTypeName.Clear();
            }


        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = CollateralTypes.GetAll();
            bsCollateralType = new BindingSource();

            dgCollateralType.DataSource = dt;
            bsCollateralType.DataSource = dt;

            Setup();
        }
        void Setup()
        {
            dgCollateralType.ReadOnly = true;
            dgCollateralType.RowHeadersVisible = false;
            dgCollateralType.Columns[0].DataPropertyName = "CollateralTypeID";
            dgCollateralType.Columns[0].Visible = false;
            dgCollateralType.Columns[1].DataPropertyName = "CollateralTypeName";
            dgCollateralType.Columns[1].Visible = true;
            dgCollateralType.Columns[1].HeaderText = "CollateralType Name";
            dgCollateralType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CollateralTypeForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableControl(false);
        }

        private void dgCollateralType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgCollateralType.SelectedRows[0].Cells[0].Value.ToString());
            if(id > 0)
            {
                CollateralType collateralType = CollateralTypes.Get(id);
                if (collateralType != null)
                {
                    txtCollateralTypeName.Text = collateralType.CollateralTypeName;
                }
                EnableControl(false);
            }
        }
    }
}
