using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Pos.DL
{
    public class Helper

    {
        static string ConnectionString = @"Server=localHost;Database=mit_pos;Uid=root;Password=;";

        public static Boolean ExecuteNonQuery(string _Query)
        {

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                bool result = false;
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction trans = null;
                try
                {
                    cmd.CommandTimeout = 0;
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = _Query;
                    cmd.Connection = con;

                    trans = con.BeginTransaction();
                    try
                    {
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            result = true;
                        }
                        trans.Commit();

                    }
                    catch (Exception ex)
                    {
                        result = false;
                        trans.Rollback();
                        throw ex;
                    }
                    return result;
                }
                finally
                {
                    trans = null;
                }
            }
        }
        public static System.Data.DataTable executeQuery(String _Query)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = _Query;
                    cmd.Connection = con;
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
