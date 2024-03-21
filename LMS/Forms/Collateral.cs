using LMS.Data;
using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class Collateral : Form
    {
        private BindingSource bsCollateral;

        public Collateral()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Collateral_Load(object sender, EventArgs e)
        {
            //LoadCollateralType();
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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCollateral.SelectedRows[0].Cells[0].Value.ToString());
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
    }
}
