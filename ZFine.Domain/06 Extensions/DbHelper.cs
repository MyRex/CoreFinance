﻿/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ZFine.Domain.Extensions
{
    public class DbHelper
    {
        private static string connstring = "";//ConfigurationManager.ConnectionStrings["ZFineDbContext"].ConnectionString;
        public static int ExecuteSqlCommand(string cmdText)
        {
            using (DbConnection conn = new MySqlConnection(connstring))
            {
                DbCommand cmd = new MySqlCommand();
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                return cmd.ExecuteNonQuery();
            }
        }
        private static void PrepareCommand(DbCommand cmd, DbConnection conn, DbTransaction isOpenTrans, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (isOpenTrans != null)
                cmd.Transaction = isOpenTrans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                cmd.Parameters.AddRange(cmdParms);
            }
        }
    }
}