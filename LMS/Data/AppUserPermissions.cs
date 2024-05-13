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
    public static class AppUserPermissions
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("AppUserPermissionGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static DataTable Get(int id)
        {
            OracleCommand cmd = new OracleCommand("AppUserPermissionGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("AppUserId", id);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt ;

        }
        
        public static void Add(AppUserPermission appUserPermission)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AppUserPermissionAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AppUserId", appUserPermission.AppUserId);
                cmd.Parameters.Add("UserPermission", appUserPermission.UserPermission);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int userId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AppUserPermissionDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AppUserId", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
