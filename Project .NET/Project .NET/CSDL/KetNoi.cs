using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.NET.CSDL
{
    public class KetNoi
    {
        public static MySqlConnection GetDBConnection()
        {
            String host = "localhost";
            int port = 3306;
            String database = "laptopsellingwebsite";
            String username = "root";
            String password = "";
            return CauHinh.GetDBConnection(host, port, database, username, password);
        }
    }
}