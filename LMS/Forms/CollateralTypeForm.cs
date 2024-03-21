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
    public partial class CollateralTypeForm : Form
    {
        public CollateralTypeForm()
        {
            InitializeComponent();
        }
        int number = 0;
        private BindingSource bsCollateralType;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(number == 1)
            {

            }
            else
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            number = 2;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            number = 1;
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
        }
    }
}
