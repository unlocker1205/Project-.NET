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
                String query = "select * from thongtinlaptop LIMIT @limit OFFSET @offset ";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@limit", limit);
                ps.Parameters.AddWithValue("@offset", offset);
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
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
            return null;
        }

        public int getTotalPage()
        {
            try
            {
                String query = "select count(*) as total from thongtinlaptop";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                connection.Close();
                return resultSet.GetInt32("total");
            }
            catch (Exception e)
            {
                throw e;
            }
            return 0;
        }

        public ArrayList getAllProduct()
        {
            ArrayList listResult = new ArrayList();
            try
            {
                String query = "select * from thongtinlaptop";
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
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listResult.Add(product);
                }
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getAllProduct(String temp, int limit, int page)
        {
            ArrayList listResult = new ArrayList();
            try
            {
                int offset = (page - 1) * limit;
                String query;
                if (temp != null)
                {
                    query = "select * from thongtinlaptop" + " ORDER BY GIABAN " + "@temp" + " LIMIT " + "@limit" + " OFFSET " + "@offset";
                }
                else
                {
                    query = "select * from thongtinlaptop" + " LIMIT " + "@limit" + " OFFSET " + "@offset";
                }
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                if (temp != null)
                {
                    ps.Parameters.AddWithValue("@temp", temp);
                    ps.Parameters.AddWithValue("@limit", limit);
                    ps.Parameters.AddWithValue("@offset", offset);
                }
                else
                {
                    ps.Parameters.AddWithValue("@limit", limit);
                    ps.Parameters.AddWithValue("@offset", offset);
                }
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listResult.Add(product);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            
            return listResult;
        }

        public ArrayList getAllProducer()
        {
            listProducer = new ArrayList();
            try
            {
                String query = "select * from hangsx";
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
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5),
                            resultSet.GetString(6));
                    listProducer.Add(produccer);
                }
                resultSet.Close();
                return listProducer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getTopProduct1(int num)
        {
            ArrayList listProduct = new ArrayList();
            try
            {
                foreach (ManufacturerModel x in listProducer)
                {
                    String query = "select * from thongtinlaptop JOIN hangsx on HANG = TENHANG WHERE HANG = @hang ORDER BY thongtinlaptop.GIABAN DESC LIMIT @limit";
                    MySqlConnection connection = KetNoi.GetDBConnection();
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    MySqlCommand ps = connection.CreateCommand();
                    ps.Parameters.AddWithValue("@hang", x.TenHang);
                    ps.Parameters.AddWithValue("@limit", num);
                    ps.CommandText = query;
                    MySqlDataReader resultSet = ps.ExecuteReader();
                    while (resultSet.Read())
                    {
                        ProductModel product = new ProductModel(resultSet.GetString(1),
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
                                resultSet.GetString(19));
                        listProduct.Add(product);
                    }
                    connection.Close();
                }
               
                return listProduct;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getTopProductBestSeller(int num)
        {
            ArrayList listProductBestSeller = new ArrayList();
            try
            {
                foreach (ManufacturerModel x in listProducer)
                {
                    String query = "select * from thongtinlaptop ORDER BY thongtinlaptop.GIABAN DESC LIMIT @limit";
                    MySqlConnection connection = KetNoi.GetDBConnection();
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    MySqlCommand ps = connection.CreateCommand();
                    ps.Parameters.AddWithValue("@limit", num);
                    ps.CommandText = query;
                    MySqlDataReader resultSet = ps.ExecuteReader();
                    while (resultSet.Read())
                    {
                        ProductModel product = new ProductModel(resultSet.GetString(1),
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
                                resultSet.GetString(19));
                        listProductBestSeller.Add(product);
                    }
                    connection.Close();
                }
                return listProductBestSeller;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProductManufacturer(String manufacturer)
        {
            ArrayList listProductManufacturer = new ArrayList();
            try
            {
                String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", manufacturer);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listProductManufacturer.Add(product);
                }
                connection.Close();
                return listProductManufacturer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProductManufacturer(String manufacturer, int limit, int page)
        {
            ArrayList listProductManufacturer = new ArrayList();
            try
            {
                int offset = (page - 1) * limit;
                String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang LIMIT " + "@limit" + " OFFSET " + "@offset";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", manufacturer);
                ps.Parameters.AddWithValue("@limit", limit);
                ps.Parameters.AddWithValue("@offset", offset);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listProductManufacturer.Add(product);
                }
                connection.Close();
                return listProductManufacturer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProductManufacturer(String manufacturer, String temp, int limit, int page)
        {
            ArrayList listProductManufacturer = new ArrayList();
            try
            {
                int offset = (page - 1) * limit;
                String query;
                if (temp != null)
                {
                    query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang" + " ORDER BY GIABAN " + "@temp" + " LIMIT " + "@limit" + " OFFSET " + "@offset";
                }
                else
                {
                    query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang " + " LIMIT " + "@limit" + " OFFSET " + "@offset";
                }
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                if (temp != null)
                {
                    ps.Parameters.AddWithValue("@hang", manufacturer);
                    ps.Parameters.AddWithValue("@temp", temp);
                    ps.Parameters.AddWithValue("@limit", limit);
                    ps.Parameters.AddWithValue("@offset", offset);
                }
                else
                {
                    ps.Parameters.AddWithValue("@hang", manufacturer);
                    ps.Parameters.AddWithValue("@limit", limit);
                    ps.Parameters.AddWithValue("@offset", offset);
                }
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listProductManufacturer.Add(product);
                }
                connection.Close();
                return listProductManufacturer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProducerWithID(String producer)
        {
            ArrayList listProducer = new ArrayList();
            try
            {
                String query = "SELECT * FROM HANGSX WHERE TENHANG = @producer";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@producer", producer);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5),
                            resultSet.GetString(6));
                    listProducer.Add(produccer);
                }
                resultSet.Close();
                connection.Close();
                return listProducer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProductWithID(String ID)
        {
            ArrayList listProductWithID = new ArrayList();
            try
            {
                String query = "SELECT * FROM THONGTINLAPTOP WHERE MALAPTOP = @id";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@id", ID);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listProductWithID.Add(product);
                }
                resultSet.Close();
                connection.Close();
                return listProductWithID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getProductWithProducer(String producer)
        {
            ArrayList listProductWithID = new ArrayList();
            try
            {
                String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", producer);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(1),
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
                            resultSet.GetString(19));
                    listProductWithID.Add(product);
                }
                resultSet.Close();
                connection.Close();
                return listProductWithID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList getTopProducer(int num)
        {
            ArrayList listTopProducer = new ArrayList();
            try
            {
                String query = "select * from hangsx limit @limit";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@limit", num);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5),
                            resultSet.GetString(6));
                    listTopProducer.Add(produccer);
                }
                resultSet.Close();
                connection.Close();
                return listTopProducer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList sortWithPrice(int highPrice, int lowPrice)
        {
            ArrayList result = new ArrayList();
            try
            {
                String query = "select * from THONGTINLAPTOP WHERE GIABAN BETWEEN @highPrice and @lowPrice";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@highPrice", highPrice);
                ps.Parameters.AddWithValue("@lowPrice", lowPrice);
                ps.CommandText = query;
                MySqlDataReader rs = ps.ExecuteReader();
                while (rs.Read())
                {
                    ProductModel product = new ProductModel(rs.GetString(1),
                            rs.GetString(2),
                            rs.GetString(3),
                            rs.GetInt32(4),
                            rs.GetString(5),
                            rs.GetString(6),
                            rs.GetString(7),
                            rs.GetString(8),
                            rs.GetString(9),
                            rs.GetString(10),
                            rs.GetString(11),
                            rs.GetString(12),
                            rs.GetString(13),
                            rs.GetString(14),
                            rs.GetString(15),
                            rs.GetString(16),
                            rs.GetString(17),
                            rs.GetString(18),
                            rs.GetString(19));
                    result.Add(product);
                }
                connection.Close();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ArrayList sortPriceWithProducer(int highPrice, int lowPrice, String hangSX)
        {
            ArrayList result = new ArrayList();
            try
            {
                String query = "select * from THONGTINLAPTOP WHERE HANG = @hang AND GIABAN BETWEEN @highPrice and @lowPrice";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", hangSX);
                ps.Parameters.AddWithValue("@highPrice", highPrice);
                ps.Parameters.AddWithValue("@lowPrice", lowPrice);
                ps.CommandText = query;
                MySqlDataReader rs = ps.ExecuteReader();
                while (rs.Read())
                {
                    ProductModel product = new ProductModel(rs.GetString(1),
                            rs.GetString(2),
                            rs.GetString(3),
                            rs.GetInt32(4),
                            rs.GetString(5),
                            rs.GetString(6),
                            rs.GetString(7),
                            rs.GetString(8),
                            rs.GetString(9),
                            rs.GetString(10),
                            rs.GetString(11),
                            rs.GetString(12),
                            rs.GetString(13),
                            rs.GetString(14),
                            rs.GetString(15),
                            rs.GetString(16),
                            rs.GetString(17),
                            rs.GetString(18),
                            rs.GetString(19));
                    result.Add(product);
                }
                connection.Close();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int getTotalPageByProducer(String producer)
        {
            try
            {
                String query = "select count(*) as total from thongtinlaptop where hang = @hang";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", producer);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                connection.Close();
                return resultSet.GetInt32("total");
            }
            catch (Exception e)
            {
                throw e;
            }
            return 0;
        }
    }
}