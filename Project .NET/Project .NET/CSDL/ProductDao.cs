using MySql.Data.MySqlClient;
using Project.NET.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.NET.CSDL
{
    public class ProductDao
    {
        ArrayList listProducer;
        int count = 0;

        public static ArrayList getAllProduct(int limit, int page)
        {
            ArrayList listResult = new ArrayList();
            try
            {
                int offset = (page - 1) * limit;
                String query = "select * from thongtinlaptop LIMIT " + limit + " OFFSET " + offset;
                MySqlCommand ps = KetNoi.GetDBConnection().CreateCommand();
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetInt32(4),
                            resultSet.GetString(5),
                            resultSet.GetString(6),
                            resultSet.GetString(7),
                            resultSet.GetString(8),
                            resultSet.GetString(9),
                            resultSet.GetString(10),
                            resultSet.GetString(11),
                            resultSet.GetString(12),
                            resultSet.GetString(13),
                            resultSet.GetString(14),
                            resultSet.GetString(15),
                            resultSet.GetString(16),
                            resultSet.GetString(17),
                            resultSet.GetString(18),
                            resultSet.GetString(19)
                    );
                    listResult.Add(product);
                }
                return listResult;
            }
            catch(Exception e)
            {
                throw e;
            }
            return null;
            }
        }
}