using LMS.Data;
using LMS.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class FormCollateral : Form
    {
        private BindingSource bsCollateral;

        public FormCollateral(int userId)
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

                if (dr["UserPermission"].ToString() == "CollateralModify")
                {
                    btnEdit.Enabled = true;
                }
                if (dr["UserPermission"].ToString() == "CollateralCreate")
                {
                    btnNew.Enabled = true;
                }
                if (dr["UserPermission"].ToString() == "CollateralDelete")
                {
                    btnDelete.Enabled = true;
                }


            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int score;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!DoValidation()) return;

            Collateral collateral = new Collateral();
            collateral.CollateralCode = txtCollateralCode.Text.Trim();
            collateral.OwnerName = txtOwnerName.Text.Trim();    
            collateral.OwnerNationalCardNumber = txtOwnerNCN.Text.Trim();
            collateral.CollateralDescription = txtDescription.Text.Trim();
            collateral.CollateralTypeId = Convert.ToInt32(cbCollateralType.SelectedValue.ToString()) ;
            if(score == 1)
            {
                Collaterals.Add(collateral);
                MessageBox.Show("Record is success saving");
            }else if(score == 2)
            {
                if(id > 0)
                {
                    collateral.CollateralId = id;
                    Collaterals.Update(collateral);
                    MessageBox.Show("Record is success updating");
                }
            }
            EnableControl(false);
            Clear();
            Collateral_Load(null, null);
        }
        void EnableControl(bool result)
        {
            txtCollateralCode.Enabled = result;
            txtOwnerName.Enabled = result;
            txtDescription.Enabled = result;
            txtOwnerNCN.Enabled = result;
            cbCollateralType.Enabled = result;
            btnSave.Enabled = result;
            if (result == false)
            {
                epCollateralCode.Clear();
                epCollateralType.Clear();
                epOwnerName.Clear();
                epOwnerNCN.Clear();
            }
        }
        void Clear()
        {
            txtCollateralCode.Clear();
            txtOwnerName.Clear();
            txtDescription.Clear();
            txtOwnerNCN.Clear();
            cbCollateralType.Text = "Select One" ;
        }

        bool DoValidation()
        {
            bool result = true;
            if(txtCollateralCode.Text.Trim() == "")
            {
                epCollateralCode.SetError(txtCollateralCode, "Enter code");
                result = false;
            }
            else
            {
                epCollateralCode.Clear();
            }
            if(txtOwnerName.Text.Trim() == "")
            {
                epOwnerName.SetError(txtOwnerName, "Enter Owner Name");
                result = false;
            }
            else
            {
                epOwnerName.Clear();
            }
            if(txtOwnerNCN.Text.Trim() == "")
            {
                epOwnerNCN.SetError(txtOwnerNCN, "Enter Owner Name");
                result = false;
            }
            else
            {
                epOwnerNCN.Clear();
            }
            return result;
        }

        private void Collateral_Load(object sender, EventArgs e)
        {
            LoadCollateralType();
            LoadData();
        }
        void LoadCollateralType()
        {
            cbCollateralType.DataSource = CollateralTypes.GetAll();
            cbCollateralType.DisplayMember = "CollateralTypeName";
            cbCollateralType.ValueMember = "CollateralTypeId";
        }
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = Collaterals.GetAll();
            bsCollateral = new BindingSource();

            dgCollateral.DataSource = dt;
            bsCollateral.DataSource = dt;


            Setup();
        }
        void Setup()
        {
            dgCollateral.ReadOnly = true;
            dgCollateral.RowHeadersVisible = false;
            dgCollateral.Columns[0].DataPropertyName = "COLLATERALID";
            dgCollateral.Columns[0].Visible = false;
            dgCollateral.Columns[1].DataPropertyName = "OWNERNAME";
            dgCollateral.Columns[1].Visible = true;
            dgCollateral.Columns[1].HeaderText = "Owner Name";
            dgCollateral.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCollateral.Columns[2].DataPropertyName = "COLLATERALCODE";
            dgCollateral.Columns[2].Visible = false;
            dgCollateral.Columns[3].DataPropertyName = "OWNERNATIONALCARDNUMBER";
            dgCollateral.Columns[3].Visible = false;
            dgCollateral.Columns[4].DataPropertyName = "COLLATERALTYPEID";
            dgCollateral.Columns[4].Visible = false;
            dgCollateral.Columns[5].DataPropertyName = "COLLATERALDESCRIPTION";
            dgCollateral.Columns[5].Visible = false;
            dgCollateral.Columns[6].DataPropertyName = "ishidden";
            dgCollateral.Columns[6].Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            score = 1;
            EnableControl(true);
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            score = 2;
            EnableControl(true);
        }
        int id = 0;
        private int userId;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgCollateral.SelectedRows[0].Cells[0].Value.ToString());
            if (id > 0)
            {
                try
                {
                    Collaterals.Delete(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Record is Deleting!.");
            }
            Collateral_Load(null, null);
        }

        private void dgCollateral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgCollateral.SelectedRows[0].Cells[0].Value.ToString());
            if (id > 0)
            {
                Collateral collateral = Collaterals.Get(id);
                txtCollateralCode.Text = collateral.CollateralCode;
                txtDescription.Text = collateral.CollateralDescription;
                txtOwnerName.Text = collateral.OwnerName;
                txtOwnerNCN.Text = collateral.OwnerNationalCardNumber;
                cbCollateralType.SelectedValue = collateral.CollateralTypeId;
            }
        }
    }
}
