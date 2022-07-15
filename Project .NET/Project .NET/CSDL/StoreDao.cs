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

    public class StoreDao
    {
        public int[] getInventoryAndImport()
        {
            int[] inventoryAndImport = new int[2];
            String query = "select sum(SLNHAP) as nhap , sum(SLXUAT) as xuat from khohang ";
            try
            {
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();

                while (resultSet.Read())
                {
                    inventoryAndImport[0] = resultSet.GetInt32(0);
                    inventoryAndImport[1] = resultSet.GetInt32(1);
                }
                connection.Close();
                return inventoryAndImport;
            }
            catch (Exception e)
            {
                throw e;
            }
            return inventoryAndImport; 
        }
        public List<ItemStore> getListStore(int limit, int page)
        {
            List<ItemStore> itemStores = new List<ItemStore>();
            String query = "SELECT * FROM laptopsellingwebsite.khohang limit @limit offset @offset ";
            try
            {
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.CommandText = query;
                ps.Parameters.AddWithValue("@limit", limit);
                ps.Parameters.AddWithValue("@offset", page);
                MySqlDataReader resultSet = ps.ExecuteReader();

                while (resultSet.Read())
                {
                    ItemStore itemStore = new ItemStore(resultSet.GetString(0),
                        resultSet.GetInt32(1), resultSet.GetInt32(2), resultSet.GetInt32(3));
                    itemStores.Add(itemStore);
                }
                connection.Close();
                return itemStores;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
