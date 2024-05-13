using LMS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LMS.Data
{
    public static class AppUsers
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("AppUserGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static AppUser Get(int id)
        {
            OracleCommand cmd = new OracleCommand("AppUserGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("AppUserId", id);
            OracleDataReader reader = cmd.ExecuteReader();
            AppUser appUser = null;
            if (reader.Read())
            {
                appUser = new AppUser();
                appUser.UserName = reader["UserName"].ToString();
                appUser.Password = reader["Password"].ToString();
                appUser.UserType = reader["UserType"].ToString();
                appUser.IsLog = Convert.ToInt32(reader["IsLog"]);
            }
            reader.Close();

            return appUser;

        }
        public static int Add(AppUser appUser)
        {
            int id = 0;
            try
            {
                OracleCommand cmd = new OracleCommand("AppUserAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("UserName", appUser.UserName);
                cmd.Parameters.Add("Password", appUser.Password);
                cmd.Parameters.Add("IsLog", appUser.IsLog);
                cmd.Parameters.Add("UserType", appUser.UserType);
                cmd.Parameters.Add("AppUserId" , OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.Parameters["AppUserId"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
        public static void Update(AppUser appUser)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AppUserUpdate", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AppUserId", appUser.AppUserId);
                cmd.Parameters.Add("UserName", appUser.UserName);
                cmd.Parameters.Add("Password", appUser.Password);
                cmd.Parameters.Add("IsLog", appUser.IsLog);
                cmd.Parameters.Add("UserType", appUser.UserType);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int appUserId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AppUserDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AppUserId", appUserId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static AppUser Login(string userName, string password)
        {
           
            AppUser appUser = new AppUser(); 
            OracleCommand cmd = new OracleCommand("AppUserLogin", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("UserName", userName);
            cmd.Parameters.Add("Password", password);
            OracleDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                
                appUser.UserName = reader["UserName"].ToString();
                appUser.Password = reader["Password"].ToString();
                appUser.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                appUser.IsLog = Convert.ToInt32(reader["IsLog"]);
                appUser.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                appUser.UserType = reader["UserType"].ToString().ToLower() ;
            }
            cmd.ExecuteNonQuery();
            return appUser;

           
        }
    }
}
