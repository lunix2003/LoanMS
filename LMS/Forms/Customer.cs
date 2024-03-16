using LMS.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.Forms
{
	public partial class Customer : Form
	{
		int score = 0;
		BindingSource bsCustomer;
		public Customer()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			LoadData();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Customer_Load(object sender, EventArgs e)
		{
			btnSave.BackColor = Color.FromArgb(166, 187, 205);
			btnSave.Enabled = false;
			EnableControl(false);

			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			score = 1;
			btnSave.Enabled = true;
			if (dtAddress != null)
				dtAddress.Rows.Clear();
			btnSave.BackColor = Color.FromArgb(32, 85, 131);
			Clear();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			score = 2;
			btnSave.Enabled = true;
			btnSave.BackColor = Color.FromArgb(32, 85, 131);
			Clear();


		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!CheckValidate())
			{
				return;
			}
			if(score == 1)
			{
				try
				{
					SqlCommand cmdCus = new SqlCommand($"Insert into Customer(CustomerName,Sex,Phone,Email,DOB,POB,isHidden) output inserted.CustomerId values('{txtCustomerName.Text.Trim()}','M','{txtPhone.Text.Trim()}','{txtEmail.Text.Trim()}','{dtpDoB.Value.ToString("yyyy-MM-dd")}','{txtPoB.Text.Trim()}',0)  ", Connection.GetConnection());
					int id = int.Parse(cmdCus.ExecuteScalar().ToString());
					if(id > 0)
					{
						foreach(DataRow row in dtAddress.Rows)
						{
							SqlCommand cmdAddress = new SqlCommand($"Insert into Address(CustomerId,AddressName) values('{id}','{row["AddressName"]}')", Connection.GetConnection());
							cmdAddress.ExecuteNonQuery();
						}
					}
					MessageBox.Show("Record is saving!.");

				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception is " + ex.Message);
				}
			}
			else if(score == 2)
			{
				int id = int.Parse(dgCustomer.SelectedRows[0].Cells[0].Value.ToString());
				if(id > 0)
				{
					try
					{
						SqlCommand cmd = new SqlCommand($"Update Customer Set CustomerName='{txtCustomerName.Text.Trim()}',Sex='{SetGender()}',Phone='{txtPhone.Text.Trim()}',Email='{txtEmail.Text.Trim()}',DOB='{dtpDoB.Value.ToString("yyyy-MM-dd")}',POB='{txtPoB.Text.Trim()}' where CustomerId='{id}'", Connection.GetConnection());
						cmd.ExecuteNonQuery();
						SqlCommand cmdAddress = new SqlCommand($"Delete from Address where CustomerId='{id}'",Connection.GetConnection());
                        cmdAddress.ExecuteNonQuery();
                        foreach (DataRow row in dtAddress.Rows)
                        {
                            SqlCommand cmdAddr = new SqlCommand($"Insert into Address(CustomerId,AddressName) values('{id}','{row["AddressName"]}')", Connection.GetConnection());
                            cmdAddr.ExecuteNonQuery();
                        }
                    }
					catch(Exception ex)
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



			Customer_Load(null,null);
			

		
		}

		void GetGender(char gender)
		{
			if(gender == 'F')
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


        public void LoadData()
		{
			SqlCommand cmd = new SqlCommand("Select CustomerId,CustomerName from Customer", Connection.GetConnection());
			DataTable dt = new DataTable();
			bsCustomer = new BindingSource();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			dgCustomer.DataSource = dt;
			bsCustomer.DataSource = dt;


			Setup();
		}
		void Setup()
		{
			dgCustomer.ReadOnly = true;
			dgCustomer.RowHeadersVisible = false;
			dgCustomer.Columns[0].DataPropertyName = "CustomerID";
			dgCustomer.Columns[0].Visible = false;
			dgCustomer.Columns[1].DataPropertyName = "CustomerName";
			dgCustomer.Columns[1].Visible = true;
			dgCustomer.Columns[1].HeaderText = "Customer Name";
			dgCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		void EnableControl(bool result)
		{
			txtCustomerName.Enabled = result;
			txtPoB.Enabled = result;
			txtPhone.Enabled = result;
			txtEmail.Enabled = result;
			dtpDoB.Enabled = result;
			rdFemale.Enabled = result;
			rdMale.Enabled = result;
			if (result == false)
			{
				epCustomerName.Clear();
				epPoB.Clear();
				epPhone.Clear();
				epGender.Clear();
				epDateOfBirth.Clear();
				dgAddress.ReadOnly = true;
			}
			else
			{
				dgAddress.ReadOnly = false;
			}

		}
		void Clear()
		{
			EnableControl(true);
			if(score == 1)
			{
				txtCustomerName.Clear();
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
			if(txtCustomerName.Text == "")
			{
				epCustomerName.SetError(txtCustomerName, "Pls enter customer name");
				result = false;
			}
			else
			{
				epCustomerName.Clear();
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
			if(dtpDoB.Value.Date == DateTime.Now.Date)
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
		DataTable dtAddress;
		private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			EnableControl(false);
			btnSave.Enabled = false;

			string id = dgCustomer.SelectedRows[0].Cells[0].Value.ToString();
			SqlCommand cmd = new SqlCommand($"Select * from Customer Where CustomerId='{id}'", Connection.GetConnection());
			SqlDataReader dataReader = cmd.ExecuteReader();
			if (dataReader.Read())
			{
				txtCustomerName.Text = dataReader["CustomerName"].ToString();
				txtEmail.Text = dataReader["Email"].ToString();
				txtPhone.Text = dataReader["Phone"].ToString();
				txtPoB.Text = dataReader["POB"].ToString();
				GetGender(char.Parse(dataReader["Sex"].ToString()));
				dtpDoB.Value = DateTime.Parse(dataReader["DOB"].ToString());
			}
			dataReader.Close();

			SqlCommand cmd1 = new SqlCommand($"Select * from Address where CustomerId={id}", Connection.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
			dtAddress = new DataTable();
			adapter.Fill(dtAddress);
			dgAddress.DataSource = dtAddress;

			dgAddress.RowHeadersVisible = false;
			dgAddress.Columns[0].DataPropertyName = "AddressId";
			dgAddress.Columns[0].Visible = false;
			dgAddress.Columns[1].DataPropertyName = "CustomerID";
			dgAddress.Columns[1].Visible = false;
			dgAddress.Columns[2].DataPropertyName = "AddressName";
			dgAddress.Columns[2].Visible = true;
			dgAddress.Columns[2].HeaderText = "Address";
			dgAddress.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

		}
	}
}
