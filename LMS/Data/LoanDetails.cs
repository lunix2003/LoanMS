using LMS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
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
                OracleCommand cmd = new OracleCommand("LOANDETAILADD", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_LOANID", OracleDbType.Int32).Value = loanDetail.LoanId;
                cmd.Parameters.Add("P_PERIODNO", OracleDbType.Int32).Value = loanDetail.PeriodNo;
                cmd.Parameters.Add("P_BEGINNINGBALANCE", OracleDbType.Double).Value  = loanDetail.BeginningBalance;
                cmd.Parameters.Add("P_PRINCIPLE", OracleDbType.Double).Value=  loanDetail.Principle;
                cmd.Parameters.Add("P_INTEREST", OracleDbType.Double).Value = loanDetail.Interest;
                cmd.Parameters.Add("P_PAYMENT", OracleDbType.Double).Value = loanDetail.Payment;
                cmd.Parameters.Add("P_ENDINGBALANCE", OracleDbType.Double).Value = loanDetail.EndingBalance;
                cmd.Parameters.Add("P_ISPAID", OracleDbType.Int32).Value = loanDetail.IsPaid;
                cmd.Parameters.Add("P_PAIDDATE", OracleDbType.Date).Value = loanDetail.PaidDate;
                cmd.Parameters.Add("P_NOTE", OracleDbType.NVarchar2).Value = loanDetail.Note;
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
