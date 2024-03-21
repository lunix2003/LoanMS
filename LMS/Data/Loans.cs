using LMS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Data
{
    public static class Loans
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("LoanGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static Loan Get(int id)
        {
            OracleCommand cmd = new OracleCommand("LoanGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("LoanId", id);
            OracleDataReader reader = cmd.ExecuteReader();
            Loan loan = null;
            if (reader.Read())
            {
                loan = new Loan();
                loan.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                loan.CollateralId = Convert.ToInt32(reader["CollateralId"].ToString());
                loan.CreditOfficerId = Convert.ToInt32(reader["CreditOfficerId"].ToString());
                loan.LoanDate = Convert.ToDateTime(reader["LoanDate"].ToString());
                loan.LoanCode = reader["LoanCode"].ToString();
                loan.LoanAmount = Convert.ToDouble(reader["LoanAmount"].ToString());
                loan.Currency = Convert.ToChar(reader["Currency"].ToString());
                loan.InterestRate = Convert.ToDouble(reader["InterestRate"].ToString());
                loan.PaymentFrequencyCode = Convert.ToDouble(reader["PaymentFrequencyCode"].ToString());
                loan.Memo = reader["Memo"].ToString();
            }
            reader.Close();

            return loan;

        }
        public static int Add(Loan loan)
        {
            int id = 0;
            try
            {
                OracleCommand cmd = new OracleCommand("LoanAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CustomerId", loan.CustomerId);
                cmd.Parameters.Add("CollateralId", loan.CollateralId);
                cmd.Parameters.Add("CreditOfficerId", loan.CreditOfficerId);
                cmd.Parameters.Add("LoanDate", loan.LoanDate);
                cmd.Parameters.Add("LoanCode", loan.LoanCode);
                cmd.Parameters.Add("LoanAmount", loan.LoanAmount);
                cmd.Parameters.Add("Currency", loan.Currency);
                cmd.Parameters.Add("InterestRate", loan.InterestRate);
                cmd.Parameters.Add("PaymentFrequencyCode", loan.PaymentFrequencyCode);
                cmd.Parameters.Add("Memo", loan.Memo);
                cmd.Parameters.Add("LoanId", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.Parameters["LoanId"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
        public static void Update(Loan loan)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("LoanUpdate", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("LoanId", loan.LoanId);
                cmd.Parameters.Add("CustomerId", loan.CustomerId);
                cmd.Parameters.Add("CollateralId", loan.CollateralId);
                cmd.Parameters.Add("CreditOfficerId", loan.CreditOfficerId);
                cmd.Parameters.Add("LoanDate", loan.LoanDate);
                cmd.Parameters.Add("LoanCode", loan.LoanCode);
                cmd.Parameters.Add("LoanAmount", loan.LoanAmount);
                cmd.Parameters.Add("Currency", loan.Currency);
                cmd.Parameters.Add("InterestRate", loan.InterestRate);
                cmd.Parameters.Add("PaymentFrequencyCode", loan.PaymentFrequencyCode);
                cmd.Parameters.Add("Memo", loan.Memo);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int loanId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("LoanDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("LoanId", loanId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
