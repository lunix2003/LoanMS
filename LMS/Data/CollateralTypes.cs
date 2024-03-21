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
    public static class CollateralTypes
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("CollateralTypeGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static void Add(CollateralType collateralType)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralTypeAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralTypeName", collateralType.CollateralTypeName);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Update(CollateralType collateralType)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralTypeUpdate", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralTypeId", collateralType.CollateralTypeId);
                cmd.Parameters.Add("CollateralTypeName", collateralType.CollateralTypeName);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int collateralTypeId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralTypeDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralTypeId", collateralTypeId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
