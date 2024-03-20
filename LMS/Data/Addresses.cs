﻿using LMS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace LMS.Data
{
    public static class Addresses
    {
        public static DataTable Get(int customerId) {
            OracleCommand cmd = new OracleCommand("AddressGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CustomerId", customerId);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static void Add(Address address)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AddressAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AddressName", address.AddressName);
                cmd.Parameters.Add("CustomerId",address.CustomerId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int customerId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AddressDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CustomerId", customerId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
