using LMS.Data;
using LMS.Models;
using System;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class LoanSearch : Form
    {
        public LoanSearch()
        {
            InitializeComponent();
        }
        public static int id = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text);
            Loan ln = Loans.Get(id);
            if (ln != null)
            {
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            this.Hide();
            
        }
    }
}
