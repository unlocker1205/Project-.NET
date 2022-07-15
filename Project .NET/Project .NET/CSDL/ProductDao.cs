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
        public static List<ManufacturerModel> listProducer;
        public static int count = 0;

        public static List<ProductModel> getAllProduct(int limit, int page)
        {
            List<ProductModel> listResult = new List<ProductModel>();
            try
            {
                String query = "select * from thongtinlaptop LIMIT @limit OFFSET @offset";
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
                    ProductModel product = new ProductModel(
                            resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18)
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
        //
        public ProductModel getDetailProduct(String idProduct)
        {
            ProductModel productModel = null;
            try
            {
                String query = "select * from thongtinlaptop where MALAPTOP = @idProduct";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.CommandText = query;
                ps.Parameters.AddWithValue("@idProduct", idProduct);
                MySqlDataReader resultSet = ps.ExecuteReader();

                while (resultSet.Read())
                {
                    productModel = new ProductModel(
                        resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
                }
                connection.Close();
                return productModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int getTotalPage()
        {
            int result = 0;
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
                resultSet.Read();
                result = resultSet.GetInt32("total");
                connection.Close();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

        //Luan
        public static List<ProductModel> getAllProduct()
        {
            List<ProductModel> listResult = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<String> getAllColor()
        {
            List<String> listResult = new List<String>();
            try
            {
                String query = "select distinct MAU from thongtinlaptop";
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
                    listResult.Add(resultSet.GetString(0));
                }
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<String> getAllRam()
        {
            List<String> listResult = new List<String>();
            try
            {
                String query = "select distinct RAM from thongtinlaptop";
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
                    listResult.Add(resultSet.GetString(0));
                }
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<String> getAllSeries()
        {
            List<String> listResult = new List<String>();
            try
            {
                String query = "select distinct SERIES from thongtinlaptop";
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
                    listResult.Add(resultSet.GetString(0));
                }
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<String> getAllVGAs()
        {
            List<String> listResult = new List<String>();
            try
            {
                String query = "select distinct VGA from thongtinlaptop";
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
                    String vgaName = resultSet.GetString(0);
                    String name = vgaName.Split(' ')[0];
                    if (!listResult.Contains(name))
                        listResult.Add(name);
                }
                connection.Close();
                return listResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Luan
        public static List<ProductModel> getAllProduct(String temp, int limit, int page)
        {
            List<ProductModel> listResult = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(
                            resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ManufacturerModel> getAllProducer()
        {
            listProducer = new List<ManufacturerModel>();
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
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5));
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

        public static List<ProductModel> getTopProduct1(int num)
        {
            List<ProductModel> listProduct = new List<ProductModel>();
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
                        ProductModel product = new ProductModel(resultSet.GetString(0),
                                resultSet.GetString(1),
                                resultSet.GetString(2),
                                resultSet.GetInt32(3),
                                resultSet.GetString(4),
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
                                resultSet.GetString(18));
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

        public static List<ProductModel> getTopProductBestSeller(int num)
        {
            List<ProductModel> listProductBestSeller = new List<ProductModel>();
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
                        ProductModel product = new ProductModel(resultSet.GetString(0),
                                resultSet.GetString(1),
                                resultSet.GetString(2),
                                resultSet.GetInt32(3),
                                resultSet.GetString(4),
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
                                resultSet.GetString(18));
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

        public static List<ProductModel> getProductManufacturer(String manufacturer)
        {
            List<ProductModel> listProductManufacturer = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ProductModel> getProductManufacturer(String manufacturer, int limit, int page)
        {
            List<ProductModel> listProductManufacturer = new List<ProductModel>();
            try
            {
                String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = @hang LIMIT " + "@limit" + " OFFSET " + "@offset";
                MySqlConnection connection = KetNoi.GetDBConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand ps = connection.CreateCommand();
                ps.Parameters.AddWithValue("@hang", manufacturer);
                ps.Parameters.AddWithValue("@limit", limit);
                ps.Parameters.AddWithValue("@offset", page);
                ps.CommandText = query;
                MySqlDataReader resultSet = ps.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ProductModel> getProductManufacturer(String manufacturer, String temp, int limit, int page)
        {
            List<ProductModel> listProductManufacturer = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ManufacturerModel> getProducerWithID(String producer)
        {
            List<ManufacturerModel> listProducer = new List<ManufacturerModel>();
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
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5));
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

        public static List<ProductModel> getProductWithID(String ID)
        {
            List<ProductModel> listProductWithID = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ProductModel> getProductWithProducer(String producer)
        {
            List<ProductModel> listProductWithID = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetInt32(3),
                            resultSet.GetString(4),
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
                            resultSet.GetString(18));
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

        public static List<ManufacturerModel> getTopProducer(int num)
        {
            List<ManufacturerModel> listTopProducer = new List<ManufacturerModel>();
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
                    ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(0),
                            resultSet.GetString(1),
                            resultSet.GetString(2),
                            resultSet.GetString(3),
                            resultSet.GetString(4),
                            resultSet.GetString(5));
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

        public static List<ProductModel> sortWithPrice(int highPrice, int lowPrice)
        {
            List<ProductModel> result = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(rs.GetString(0),
                            rs.GetString(1),
                            rs.GetString(2),
                            rs.GetInt32(3),
                            rs.GetString(4),
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
                            rs.GetString(18));
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

        public static List<ProductModel> sortPriceWithProducer(int highPrice, int lowPrice, String hangSX)
        {
            List<ProductModel> result = new List<ProductModel>();
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
                    ProductModel product = new ProductModel(rs.GetString(0),
                            rs.GetString(1),
                            rs.GetString(2),
                            rs.GetInt32(3),
                            rs.GetString(4),
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
                            rs.GetString(18));
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

        public static int getTotalPageByProducer(String producer)
        {
            int result = 0;
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
                resultSet.Read();
                result = resultSet.GetInt32("total");
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }

    
}