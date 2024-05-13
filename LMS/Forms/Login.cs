using LMS.Data;
using LMS.Models;
using System;
using System.Windows.Forms;

namespace LMS.Forms
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
			if(!DoValidation()) return;
			try
			{
				AppUser appUser = AppUsers.Login(txtUsername.Text.Trim(),txtPassword.Text.Trim());
				if(appUser.AppUserId > 0)
				{
					if(appUser.IsLog == 1)
					{
						MessageBox.Show("User was Log");
						return;
					}

					MessageBox.Show("Login Success");
					MainForm form = new MainForm(appUser);
					form.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Invalid Username or Password");
				}
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        private bool DoValidation()
        {
			bool result = true;
			if(txtUsername.Text == "")
			{
				epUsername.SetError(txtUsername, "Pls enter username");
				result = false;
			}
			else
			{
				epUsername.Clear();
			}
			if(txtPassword.Text == "")
			{
				epPassword.SetError(txtPassword, "Pls enter password");
				result = false;
			}
			else
			{
				epPassword.Clear();
			}
			return result;

        }

        private void chshowpassword_CheckedChanged(object sender, EventArgs e)
        {
			if (chshowpassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
        }
    }
}
