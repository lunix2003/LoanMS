﻿using LMS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS.Data
{
    public static class Collaterals
    {
        public static DataTable GetAll()
        {
            OracleCommand cmd = new OracleCommand("CollateralGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static Collateral Get(int id)
        {
            OracleCommand cmd = new OracleCommand("CollateralGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CollateralId", id);
            Collateral collateral = null;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                collateral = new Collateral();
                collateral.CollateralCode = dr["CollateralCode"].ToString();
                collateral.CollateralDescription = dr["CollateralDescription"].ToString();
                collateral.CollateralTypeId = Convert.ToInt32(dr["CollateralTypeId"].ToString());
                collateral.OwnerName = dr["OwnerName"].ToString();
                collateral.OwnerNationalCardNumber = dr["OwnerNationalCardNumber"].ToString();
                
            }
            dr.Close();
            return collateral;
        }
        public static void Add(Collateral collateral)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralCode", collateral.CollateralCode);
                cmd.Parameters.Add("OwnerName", collateral.OwnerName);
                cmd.Parameters.Add("OwnerNationalCardNumber", collateral.OwnerNationalCardNumber);
                cmd.Parameters.Add("CollateralTypeId", collateral.CollateralTypeId);
                cmd.Parameters.Add("CollateralDescription", collateral.CollateralDescription);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Update(Collateral collateral)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralUpdate", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralId", collateral.CollateralId);
                cmd.Parameters.Add("CollateralCode", collateral.CollateralCode);
                cmd.Parameters.Add("OwnerName", collateral.OwnerName);
                cmd.Parameters.Add("OwnerNationalCardNumber", collateral.OwnerNationalCardNumber);
                cmd.Parameters.Add("CollateralTypeId", collateral.CollateralTypeId);
                cmd.Parameters.Add("CollateralDescription", collateral.CollateralDescription);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Delete(int collateralId)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("CollateralDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CollateralId", collateralId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
