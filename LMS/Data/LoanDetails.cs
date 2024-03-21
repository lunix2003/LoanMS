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
    public static class LoanDetails
    {
        public static DataTable GetAll(int id)
        {
            OracleCommand cmd = new OracleCommand("LoanDetailGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("LoanId", id);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        
        public static void Add(LoanDetail loanDetail)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("LoanDetailAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("LoanId", loanDetail.LoanId);
                cmd.Parameters.Add("PeriodNo", loanDetail.PeriodNo);
                cmd.Parameters.Add("BeginningBalance", loanDetail.BeginningBalance);
                cmd.Parameters.Add("Principle", loanDetail.Principle);
                cmd.Parameters.Add("Interest", loanDetail.Interest);
                cmd.Parameters.Add("Payment", loanDetail.Payment);
                cmd.Parameters.Add("EndingBalance", loanDetail.EndingBalance);
                cmd.Parameters.Add("IsPaid", loanDetail.IsPaid);
                cmd.Parameters.Add("PaidDate", loanDetail.PaidDate);
                cmd.Parameters.Add("Note", loanDetail.Note);
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
                OracleCommand cmd = new OracleCommand("LoanDetailDelete", Connection.GetConnection());
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
