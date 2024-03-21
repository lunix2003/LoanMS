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
    public static class CreditOfficers
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("CreditOfficerGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static CreditOfficer Get(int id)
        {
            OracleCommand cmd = new OracleCommand("CreditOfficerGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CreditOfficerId", id);
            OracleDataReader reader = cmd.ExecuteReader();
            CreditOfficer co = null;
            if (reader.Read())
            {
                co = new CreditOfficer();
                co.CreditOfficerName = reader["CreditOfficerName"].ToString();
                co.Sex = char.Parse(reader["Sex"].ToString());
                co.DoB = DateTime.Parse(reader["DOB"].ToString());
                co.PoB = reader["POB"].ToString();
                co.Phone = reader["Phone"].ToString();
                co.Email = reader["Email"].ToString();
            }
            reader.Close();

            return co;
            
        }
        public static void Add(CreditOfficer creditOfficer)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CreditOfficerAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CreditOfficerName", creditOfficer.CreditOfficerName);
                cmd.Parameters.Add("Sex", creditOfficer.Sex);
                cmd.Parameters.Add("DOB", creditOfficer.DoB);
                cmd.Parameters.Add("POB", creditOfficer.PoB);
                cmd.Parameters.Add("Phone", creditOfficer.Phone);
                cmd.Parameters.Add("Email", creditOfficer.Email);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Update(CreditOfficer creditOfficer)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CreditOfficerUpdate", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CreditOfficerId", creditOfficer.CreditOfficerId);
                cmd.Parameters.Add("CreditOfficerName", creditOfficer.CreditOfficerName);
                cmd.Parameters.Add("Sex", creditOfficer.Sex);
                cmd.Parameters.Add("DOB", creditOfficer.DoB);
                cmd.Parameters.Add("POB", creditOfficer.PoB);
                cmd.Parameters.Add("Phone", creditOfficer.Phone);
                cmd.Parameters.Add("Email", creditOfficer.Email);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int creditOfficerId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CreditOfficerDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CreditOfficerId", creditOfficerId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
