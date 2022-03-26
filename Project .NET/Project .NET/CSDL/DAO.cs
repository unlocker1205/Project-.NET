using java.lang;
using java.util;
using MySql.Data.MySqlClient;
using Project.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.NET.CSDL
{
    public class DAO
    {
        //private static ProductModelDao instance;
        List<ManufacturerModel> listProducer;
        //int count = 0;


        //public static ProductModelDao getInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new ProductModelDao();
        //    }
        //    return instance;
        //}

        //    public List<ProductModel> getAllProductModel(){
        //        return JDBIConnection.get().withHandle(handle -> {
        //           return handle.createQuery("select * from thongtinlaptop").mapToBean(ProductModel.class).stream().collect(Collectors.toList());
        //        });
        //    }

        public List<ProductModel> getAllProductModel(int limit, int page)
        {
            List<ProductModel> listResult = new List<ProductModel>();
            try
            {
                int offset = (page - 1) * limit;
                string query = "select * from thongtinlaptop LIMIT " + limit + " OFFSET " + offset;
                MySqlCommand command = KetNoi.GetDBConnection().CreateCommand();
                command.CommandText = query;
                MySqlDataReader resultSet = command.ExecuteReader();
                while (resultSet.Read())
                {
                    ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
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
                    listResult.Add(ProductModel);
                }
                return listResult;
            }
            catch (SqlException e) {
              
            }
            return null;
            }

        //    public int getTotalPage()
        //    {
        //        try
        //        {
        //            String query = "select count(*) as total from thongtinlaptop";
        //            PreparedStatement ps = DBConnect.getInstance().get(query);
        //            ResultSet resultSet = ps.executeQuery();
        //            resultSet.next();
        //            return resultSet.getInt("total");
        //        }
        //        catch (SQLException | ClassNotFoundException e) {
        //        e.printStackTrace();
        //    }
        //    return 0;
        //}

        //        public List getAllProductModel()
        //        {
        //            List<ProductModel> listResult = new List<>();
        //            try
        //            {
        //                String query = "select * from thongtinlaptop";
        //                PreparedStatement ps = DBConnect.getInstance().get(query);
        //                ResultSet resultSet = ps.executeQuery();
        //                while (resultSet.next())
        //                {
        //                    ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
        //                            resultSet.GetString(2),
        //                            resultSet.GetString(3),
        //                            resultSet.getInt(4),
        //                            resultSet.GetString(5),
        //                            resultSet.GetString(6),
        //                            resultSet.GetString(7),
        //                            resultSet.GetString(8),
        //                            resultSet.GetString(9),
        //                            resultSet.GetString(10),
        //                            resultSet.GetString(11),
        //                            resultSet.GetString(12),
        //                            resultSet.GetString(13),
        //                            resultSet.GetString(14),
        //                            resultSet.GetString(15),
        //                            resultSet.GetString(16),
        //                            resultSet.GetString(17),
        //                            resultSet.GetString(18),
        //                            resultSet.GetString(19));
        //                    listResult.add(ProductModel);
        //                }
        //            }
        //            catch (SQLException | ClassNotFoundException e) {
        //                e.printStackTrace();
        //            }
        //            return listResult;
        //            }

        //            public List getAllProductModel(String temp, int limit, int page)
        //            {
        //                List<ProductModel> listResult = new List<>();
        //                try
        //                {
        //                    int offset = (page - 1) * limit;
        //                    String query;
        //                    if (temp != null)
        //                    {
        //                        query = "select * from thongtinlaptop" + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
        //                    }
        //                    else
        //                    {
        //                        query = "select * from thongtinlaptop" + " LIMIT " + limit + " OFFSET " + offset;
        //                    }
        //                    PreparedStatement ps = DBConnect.getInstance().get(query);
        //                    ResultSet resultSet = ps.executeQuery();
        //                    while (resultSet.next())
        //                    {
        //                        ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
        //                                resultSet.GetString(2),
        //                                resultSet.GetString(3),
        //                                resultSet.getInt(4),
        //                                resultSet.GetString(5),
        //                                resultSet.GetString(6),
        //                                resultSet.GetString(7),
        //                                resultSet.GetString(8),
        //                                resultSet.GetString(9),
        //                                resultSet.GetString(10),
        //                                resultSet.GetString(11),
        //                                resultSet.GetString(12),
        //                                resultSet.GetString(13),
        //                                resultSet.GetString(14),
        //                                resultSet.GetString(15),
        //                                resultSet.GetString(16),
        //                                resultSet.GetString(17),
        //                                resultSet.GetString(18),
        //                                resultSet.GetString(19));
        //                        listResult.add(ProductModel);
        //                    }
        //                }
        //                catch (SQLException | ClassNotFoundException e) {
        //                e.printStackTrace();
        //            }
        //            return listResult;
        //        }

        public List<ManufacturerModel> getAllProducer()
        {
            listProducer = new List<ManufacturerModel>();
            try
            {
                string query = "select * from hangsx";
                MySqlCommand command = KetNoi.GetDBConnection().CreateCommand();
                command.CommandText = query;
                MySqlDataReader resultSet = command.ExecuteReader();
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
                return listProducer;
            }
            catch (SqlException e) {

            }
            return null;
            }

        public List<ProductModel> getTopProductModel1(int num)
        {
            List<ProductModel> listProductModel = new List<ProductModel>();
            try
            {
                foreach (ManufacturerModel x in listProducer)
                {
                    string query = "select * from thongtinlaptop JOIN hangsx on HANG = TENHANG WHERE HANG = @hang ORDER BY thongtinlaptop.GIABAN DESC LIMIT @numLimit";
                    MySqlCommand command = KetNoi.GetDBConnection().CreateCommand();
                    command.Parameters.AddWithValue("@hang", x.TenHang);
                    command.Parameters.AddWithValue("@numLimit", num);
                    command.CommandText = query;
                    MySqlDataReader resultSet = command.ExecuteReader();
                    while (resultSet.Read())
                    {
                        ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
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
                        listProductModel.Add(ProductModel);
                    }
                }
                return listProductModel;
            }
            catch (SqlException e) {

            }
            return null;
            }

            //public List getTopProductModelBestSeller(int num)
            //{
            //    List<ProductModel> listProductModelBestSeller = new List<>();
            //    try
            //    {
            //        for (ManufacturerModel x : listProducer) {
            //    String query = "select * from thongtinlaptop ORDER BY thongtinlaptop.GIABAN DESC LIMIT ?";
            //    PreparedStatement ps = DBConnect.getInstance().get(query);
            //    ps.setInt(1, num);
            //    ResultSet resultSet = ps.executeQuery();
            //    while (resultSet.next())
            //    {
            //        ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                resultSet.GetString(2),
            //                resultSet.GetString(3),
            //                resultSet.getInt(4),
            //                resultSet.GetString(5),
            //                resultSet.GetString(6),
            //                resultSet.GetString(7),
            //                resultSet.GetString(8),
            //                resultSet.GetString(9),
            //                resultSet.GetString(10),
            //                resultSet.GetString(11),
            //                resultSet.GetString(12),
            //                resultSet.GetString(13),
            //                resultSet.GetString(14),
            //                resultSet.GetString(15),
            //                resultSet.GetString(16),
            //                resultSet.GetString(17),
            //                resultSet.GetString(18),
            //                resultSet.GetString(19));
            //        listProductModelBestSeller.add(ProductModel);
            //    }
            //}
            //return listProductModelBestSeller;
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //}

            //public List getProductModelManufacturerModel(String ManufacturerModel)
            //{
            //    List<ProductModel> listProductModelManufacturerModel = new List<>();
            //    try
            //    {
            //        String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, ManufacturerModel);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.getInt(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6),
            //                    resultSet.GetString(7),
            //                    resultSet.GetString(8),
            //                    resultSet.GetString(9),
            //                    resultSet.GetString(10),
            //                    resultSet.GetString(11),
            //                    resultSet.GetString(12),
            //                    resultSet.GetString(13),
            //                    resultSet.GetString(14),
            //                    resultSet.GetString(15),
            //                    resultSet.GetString(16),
            //                    resultSet.GetString(17),
            //                    resultSet.GetString(18),
            //                    resultSet.GetString(19));
            //            listProductModelManufacturerModel.add(ProductModel);
            //        }
            //        //            }
            //        return listProductModelManufacturerModel;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getProductModelManufacturerModel(String ManufacturerModel, int limit, int page)
            //{
            //    List<ProductModel> listProductModelManufacturerModel = new List<>();
            //    try
            //    {
            //        int offset = (page - 1) * limit;
            //        String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = ? LIMIT " + limit + " OFFSET " + offset;
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, ManufacturerModel);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.getInt(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6),
            //                    resultSet.GetString(7),
            //                    resultSet.GetString(8),
            //                    resultSet.GetString(9),
            //                    resultSet.GetString(10),
            //                    resultSet.GetString(11),
            //                    resultSet.GetString(12),
            //                    resultSet.GetString(13),
            //                    resultSet.GetString(14),
            //                    resultSet.GetString(15),
            //                    resultSet.GetString(16),
            //                    resultSet.GetString(17),
            //                    resultSet.GetString(18),
            //                    resultSet.GetString(19));
            //            listProductModelManufacturerModel.add(ProductModel);
            //        }
            //        //            }
            //        return listProductModelManufacturerModel;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getProductModelManufacturerModel(String ManufacturerModel, String temp, int limit, int page)
            //{
            //    List<ProductModel> listProductModelManufacturerModel = new List<>();
            //    try
            //    {
            //        int offset = (page - 1) * limit;
            //        String query;
            //        if (temp != null)
            //        {
            //            query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = ?" + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //        }
            //        else
            //        {
            //            query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = ? " + " LIMIT " + limit + " OFFSET " + offset;
            //        }
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, ManufacturerModel);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.getInt(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6),
            //                    resultSet.GetString(7),
            //                    resultSet.GetString(8),
            //                    resultSet.GetString(9),
            //                    resultSet.GetString(10),
            //                    resultSet.GetString(11),
            //                    resultSet.GetString(12),
            //                    resultSet.GetString(13),
            //                    resultSet.GetString(14),
            //                    resultSet.GetString(15),
            //                    resultSet.GetString(16),
            //                    resultSet.GetString(17),
            //                    resultSet.GetString(18),
            //                    resultSet.GetString(19));
            //            listProductModelManufacturerModel.add(ProductModel);
            //        }
            //        //            }
            //        return listProductModelManufacturerModel;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getProducerWithID(String producer)
            //{
            //    List<ManufacturerModel> listProducer = new List<>();
            //    try
            //    {
            //        String query = "SELECT * FROM HANGSX WHERE TENHANG = ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, producer);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.GetString(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6));
            //            listProducer.add(produccer);
            //        }
            //        resultSet.close();
            //        ps.close();
            //        return listProducer;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getProductModelWithID(String ID)
            //{
            //    List<ProductModel> listProductModelWithID = new List<>();
            //    try
            //    {
            //        String query = "SELECT * FROM THONGTINLAPTOP WHERE MALAPTOP = ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, ID);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.getInt(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6),
            //                    resultSet.GetString(7),
            //                    resultSet.GetString(8),
            //                    resultSet.GetString(9),
            //                    resultSet.GetString(10),
            //                    resultSet.GetString(11),
            //                    resultSet.GetString(12),
            //                    resultSet.GetString(13),
            //                    resultSet.GetString(14),
            //                    resultSet.GetString(15),
            //                    resultSet.GetString(16),
            //                    resultSet.GetString(17),
            //                    resultSet.GetString(18),
            //                    resultSet.GetString(19));
            //            listProductModelWithID.add(ProductModel);
            //        }
            //        resultSet.close();
            //        ps.close();
            //        return listProductModelWithID;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getProductModelWithProducer(String producer)
            //{
            //    List<ProductModel> listProductModelWithID = new List<>();
            //    try
            //    {
            //        String query = "SELECT * FROM THONGTINLAPTOP WHERE HANG = ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, producer);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.getInt(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6),
            //                    resultSet.GetString(7),
            //                    resultSet.GetString(8),
            //                    resultSet.GetString(9),
            //                    resultSet.GetString(10),
            //                    resultSet.GetString(11),
            //                    resultSet.GetString(12),
            //                    resultSet.GetString(13),
            //                    resultSet.GetString(14),
            //                    resultSet.GetString(15),
            //                    resultSet.GetString(16),
            //                    resultSet.GetString(17),
            //                    resultSet.GetString(18),
            //                    resultSet.GetString(19));
            //            listProductModelWithID.add(ProductModel);
            //        }
            //        resultSet.close();
            //        ps.close();
            //        return listProductModelWithID;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List getTopProducer(int num)
            //{
            //    List listTopProducer = new List<>();
            //    try
            //    {
            //        String query = "select * from hangsx limit ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setInt(1, num);
            //        ResultSet resultSet = ps.executeQuery();
            //        while (resultSet.next())
            //        {
            //            ManufacturerModel produccer = new ManufacturerModel(resultSet.GetString(1),
            //                    resultSet.GetString(2),
            //                    resultSet.GetString(3),
            //                    resultSet.GetString(4),
            //                    resultSet.GetString(5),
            //                    resultSet.GetString(6));
            //            listTopProducer.add(produccer);
            //        }
            //        resultSet.close();
            //        ps.close();
            //        return listTopProducer;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return null;
            //    }

            //    public List sortWithPrice(int highPrice, int lowPrice)
            //{
            //    List result = new List();
            //    try
            //    {
            //        String query = "select * from THONGTINLAPTOP WHERE GIABAN BETWEEN ? and ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setInt(1, lowPrice);
            //        ps.setInt(2, highPrice);
            //        ResultSet rs = ps.executeQuery();
            //        while (rs.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //                    rs.GetString(2),
            //                    rs.GetString(3),
            //                    rs.getInt(4),
            //                    rs.GetString(5),
            //                    rs.GetString(6),
            //                    rs.GetString(7),
            //                    rs.GetString(8),
            //                    rs.GetString(9),
            //                    rs.GetString(10),
            //                    rs.GetString(11),
            //                    rs.GetString(12),
            //                    rs.GetString(13),
            //                    rs.GetString(14),
            //                    rs.GetString(15),
            //                    rs.GetString(16),
            //                    rs.GetString(17),
            //                    rs.GetString(18),
            //                    rs.GetString(19));
            //            result.add(ProductModel);
            //        }
            //        return result;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //    }

            //    public List sortPriceWithProducer(int highPrice, int lowPrice, String hangSX)
            //{
            //    List result = new List();
            //    try
            //    {
            //        String query = "select * from THONGTINLAPTOP WHERE HANG = ? AND GIABAN BETWEEN ? and ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, hangSX);
            //        ps.setInt(2, lowPrice);
            //        ps.setInt(3, highPrice);
            //        ResultSet rs = ps.executeQuery();
            //        while (rs.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //                    rs.GetString(2),
            //                    rs.GetString(3),
            //                    rs.getInt(4),
            //                    rs.GetString(5),
            //                    rs.GetString(6),
            //                    rs.GetString(7),
            //                    rs.GetString(8),
            //                    rs.GetString(9),
            //                    rs.GetString(10),
            //                    rs.GetString(11),
            //                    rs.GetString(12),
            //                    rs.GetString(13),
            //                    rs.GetString(14),
            //                    rs.GetString(15),
            //                    rs.GetString(16),
            //                    rs.GetString(17),
            //                    rs.GetString(18),
            //                    rs.GetString(19));
            //            result.add(ProductModel);
            //        }
            //        return result;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //    }

            //    public List<ProductModel> sortProductModel(Multimap<String, String> map, String temp)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (!joinString.equals("") && !queryTemp.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " AND " + " %s " + " ORDER BY GIABAN " + temp;
            //}
            //else if (joinString.equals("") && !queryTemp.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " ORDER BY GIABAN " + temp;
            //}
            //else if (queryTemp.equals("") && !joinString.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE" + " %s " + " ORDER BY GIABAN " + temp;
            //}
            //else
            //{
            //    query = "select * from THONGTINLAPTOP " + " ORDER BY GIABAN " + temp;
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //int count = 1;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps.toString());
            //ResultSet rs = ps.executeQuery();
            //while (rs.next())
            //{
            //    ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //            rs.GetString(2),
            //            rs.GetString(3),
            //            rs.getInt(4),
            //            rs.GetString(5),
            //            rs.GetString(6),
            //            rs.GetString(7),
            //            rs.GetString(8),
            //            rs.GetString(9),
            //            rs.GetString(10),
            //            rs.GetString(11),
            //            rs.GetString(12),
            //            rs.GetString(13),
            //            rs.GetString(14),
            //            rs.GetString(15),
            //            rs.GetString(16),
            //            rs.GetString(17),
            //            rs.GetString(18),
            //            rs.GetString(19));
            //    result.add(ProductModel);
            //}
            //return result;
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //}

            //public List<ProductModel> sortProductModel(Multimap<String, String> map, String temp, int limit, int page)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        int offset = (page - 1) * limit;
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (temp != null)
            //{
            //    if (!joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " AND " + " %s " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (queryTemp.equals("") && !joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + " %s " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else
            //    {
            //        query = "select * from THONGTINLAPTOP " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //}
            //else
            //{
            //    if (!joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " AND " + " %s " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + queryTemp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (queryTemp.equals("") && !joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE" + " %s " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else
            //    {
            //        query = "select * from THONGTINLAPTOP " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //int count = 1;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps.toString());
            //ResultSet rs = ps.executeQuery();
            //while (rs.next())
            //{
            //    ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //            rs.GetString(2),
            //            rs.GetString(3),
            //            rs.getInt(4),
            //            rs.GetString(5),
            //            rs.GetString(6),
            //            rs.GetString(7),
            //            rs.GetString(8),
            //            rs.GetString(9),
            //            rs.GetString(10),
            //            rs.GetString(11),
            //            rs.GetString(12),
            //            rs.GetString(13),
            //            rs.GetString(14),
            //            rs.GetString(15),
            //            rs.GetString(16),
            //            rs.GetString(17),
            //            rs.GetString(18),
            //            rs.GetString(19));
            //    result.add(ProductModel);
            //}
            //return result;
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //}

            //public int sortProductModelTotalPage(Multimap<String, String> map)
            //{
            //    try
            //    {
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (!joinString.equals("") && !queryTemp.equals(""))
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + queryTemp + " AND " + " %s ";
            //}
            //else if (!queryTemp.equals("") && joinString.equals(""))
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + queryTemp;
            //}
            //else
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + " %s ";
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //int count = 1;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps.toString());
            //ResultSet rs = ps.executeQuery();
            //rs.next();
            //return rs.getInt("total");
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return 0;
            //}
            //}

            //public int sortProductModelTotalPageByProducer(Multimap<String, String> map, String hangsx)
            //{
            //    try
            //    {
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (!joinString.equals("") && !queryTemp.equals(""))
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + " HANG = " + "?" + " AND " + queryTemp + " AND " + " %s ";
            //}
            //else if (!queryTemp.equals("") && joinString.equals(""))
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + " HANG = " + "?" + queryTemp;
            //}
            //else
            //{
            //    query = "select count(*) as total from THONGTINLAPTOP " + "WHERE" + " HANG = " + "?" + " %s ";
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //ps.setString(1, hangsx);
            //int count = 2;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps.toString());
            //ResultSet rs = ps.executeQuery();
            //rs.next();
            //return rs.getInt("total");
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return 0;
            //}
            //}

            //public List<ProductModel> sortProductModelWithProducer(Map<String, String> map, String hangsx)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        String query = "";
            //        String joinString = map.entrySet().stream()
            //                .map(e-> (!e.getKey().equalsIgnoreCase("GIABAN")) ?
            //                        (e.getKey() + " IN " + "(" + e.getValue() + ")") :
            //                        (e.getKey() + " BETWEEN " + e.getValue()))
            //                .collect(joining(" AND "));
            //        if (!joinString.equals(""))
            //        {
            //            query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND %s " + " ORDER BY GIABAN ";
            //        }
            //        else
            //        {
            //            query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " ORDER BY GIABAN ";
            //        }
            //        String sqlQuery = String.format(query, joinString);
            //        PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //        ps.setString(1, hangsx);
            //        System.out.println(ps);
            //        ResultSet rs = ps.executeQuery();
            //        while (rs.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //                    rs.GetString(2),
            //                    rs.GetString(3),
            //                    rs.getInt(4),
            //                    rs.GetString(5),
            //                    rs.GetString(6),
            //                    rs.GetString(7),
            //                    rs.GetString(8),
            //                    rs.GetString(9),
            //                    rs.GetString(10),
            //                    rs.GetString(11),
            //                    rs.GetString(12),
            //                    rs.GetString(13),
            //                    rs.GetString(14),
            //                    rs.GetString(15),
            //                    rs.GetString(16),
            //                    rs.GetString(17),
            //                    rs.GetString(18),
            //                    rs.GetString(19));
            //            result.add(ProductModel);
            //        }
            //        return result;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //    }

            //    public List<ProductModel> sortProductModelWithProducer(Multimap<String, String> map, String hangsx, String temp)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (!joinString.equals("") && !queryTemp.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " AND %s " + " ORDER BY GIABAN " + temp;
            //}
            //else if (!queryTemp.equals("") && joinString.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " ORDER BY GIABAN " + temp;
            //}
            //else if (queryTemp.equals("") && !joinString.equals(""))
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND %s " + " ORDER BY GIABAN " + temp;
            //}
            //else
            //{
            //    query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " ORDER BY GIABAN " + temp;
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //ps.setString(1, hangsx);
            //int count = 2;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps);
            //ResultSet rs = ps.executeQuery();
            //while (rs.next())
            //{
            //    ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //            rs.GetString(2),
            //            rs.GetString(3),
            //            rs.getInt(4),
            //            rs.GetString(5),
            //            rs.GetString(6),
            //            rs.GetString(7),
            //            rs.GetString(8),
            //            rs.GetString(9),
            //            rs.GetString(10),
            //            rs.GetString(11),
            //            rs.GetString(12),
            //            rs.GetString(13),
            //            rs.GetString(14),
            //            rs.GetString(15),
            //            rs.GetString(16),
            //            rs.GetString(17),
            //            rs.GetString(18),
            //            rs.GetString(19));
            //    result.add(ProductModel);
            //}
            //return result;
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //}

            //public List<ProductModel> sortProductModelWithProducer(Multimap<String, String> map, String hangsx, String temp, int limit, int page)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        int offset = (page - 1) * limit;
            //        String queryTemp = "";
            //        Multimap<String, String> mapTemp = TreeMultimap.create();
            //        if (map.keys().contains("GIABAN"))
            //        {
            //            queryTemp = " GIABAN BETWEEN " + map.get("GIABAN").stream().map(e-> "?")
            //                    .collect(Collectors.joining(" AND "));
            //            for (String x : map.get("GIABAN")) {
            //    mapTemp.put("GIABAN", x);
            //}
            //map.removeAll("GIABAN");
            //            }
            //            String joinString = map.asMap()
            //                    .entrySet()
            //                    .stream()
            //                    .map(e->e.getValue()
            //                            .stream()
            //                            .map(v-> (!e.getKey().equalsIgnoreCase("GIABAN")) ? (e.getKey() + " = " + "?") : (e.getKey() + " IN " + "?"))
            //                            .collect(Collectors.joining(" OR ", "(", ")")))
            //                    .collect(Collectors.joining(" AND "));

            //String query = "";
            //if (temp != null)
            //{
            //    if (!joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " AND %s " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (!queryTemp.equals("") && joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (queryTemp.equals("") && !joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND %s " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " ORDER BY GIABAN " + temp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //}
            //else
            //{
            //    if (!joinString.equals("") && !queryTemp.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " AND %s " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (!queryTemp.equals("") && joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND " + queryTemp + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else if (queryTemp.equals("") && !joinString.equals(""))
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " AND %s " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //    else
            //    {
            //        query = "select * from THONGTINLAPTOP " + "WHERE HANG = " + " ? " + " LIMIT " + limit + " OFFSET " + offset;
            //    }
            //}
            //String sqlQuery = String.format(query, joinString);
            //PreparedStatement ps = DBConnect.getInstance().get(sqlQuery);
            //for (String x : mapTemp.get("GIABAN"))
            //{
            //    map.put("GIABAN", x);
            //}
            //ps.setString(1, hangsx);
            //int count = 2;
            //for (String x : map.values())
            //{
            //    ps.setString(count++, x);
            //}
            //System.out.println(ps);
            //ResultSet rs = ps.executeQuery();
            //while (rs.next())
            //{
            //    ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //            rs.GetString(2),
            //            rs.GetString(3),
            //            rs.getInt(4),
            //            rs.GetString(5),
            //            rs.GetString(6),
            //            rs.GetString(7),
            //            rs.GetString(8),
            //            rs.GetString(9),
            //            rs.GetString(10),
            //            rs.GetString(11),
            //            rs.GetString(12),
            //            rs.GetString(13),
            //            rs.GetString(14),
            //            rs.GetString(15),
            //            rs.GetString(16),
            //            rs.GetString(17),
            //            rs.GetString(18),
            //            rs.GetString(19));
            //    result.add(ProductModel);
            //}
            //return result;
            //        } catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //}

            //public int getTotalPageByProducer(String producer)
            //{
            //    try
            //    {
            //        String query = "select count(*) as total from thongtinlaptop where hang = ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        ps.setString(1, producer);
            //        ResultSet resultSet = ps.executeQuery();
            //        resultSet.next();
            //        return resultSet.getInt("total");
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return 0;
            //    }

            //    public List<ProductModel> search(String txt)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        String query = "select * from THONGTINLAPTOP " + " WHERE " + " TENLAPTOP " + " LIKE ? "
            //                + " OR " + " HANG " + " LIKE ? " + " OR " + " SERIES " + " LIKE ? " +
            //                " OR " + " MAU " + " LIKE ? " + " OR " + " CPU " + " LIKE ? " + " OR " + " VGA "
            //                + " LIKE ? " + " OR " + " RAM " + " LIKE ? " + " OR " + " OCUNG " + " LIKE ?";
            //        int count = query.length() - query.replace("?", "").length();
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        for (int i = 1; i <= count; i++)
            //        {
            //            ps.setString(i, "%" + txt + "%");
            //        }
            //        ResultSet rs = ps.executeQuery();
            //        while (rs.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //                    rs.GetString(2),
            //                    rs.GetString(3),
            //                    rs.getInt(4),
            //                    rs.GetString(5),
            //                    rs.GetString(6),
            //                    rs.GetString(7),
            //                    rs.GetString(8),
            //                    rs.GetString(9),
            //                    rs.GetString(10),
            //                    rs.GetString(11),
            //                    rs.GetString(12),
            //                    rs.GetString(13),
            //                    rs.GetString(14),
            //                    rs.GetString(15),
            //                    rs.GetString(16),
            //                    rs.GetString(17),
            //                    rs.GetString(18),
            //                    rs.GetString(19));
            //            result.add(ProductModel);
            //        }
            //        return result;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //    }

            //    public int getTotalPageSearch(String txt)
            //{
            //    try
            //    {
            //        String query = "select count(*) as total from THONGTINLAPTOP " + " WHERE " + " TENLAPTOP " + " LIKE ? "
            //                + " OR " + " HANG " + " LIKE ? " + " OR " + " SERIES " + " LIKE ? " +
            //                " OR " + " MAU " + " LIKE ? " + " OR " + " CPU " + " LIKE ? " + " OR " + " VGA "
            //                + " LIKE ? " + " OR " + " RAM " + " LIKE ? " + " OR " + " OCUNG " + " LIKE ?";
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        int count = query.length() - query.replace("?", "").length();
            //        for (int i = 1; i <= count; i++)
            //        {
            //            ps.setString(i, "%" + txt + "%");
            //        }
            //        ResultSet resultSet = ps.executeQuery();
            //        resultSet.next();
            //        return resultSet.getInt("total");
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //}
            //return 0;
            //    }

            //    public List<ProductModel> searchClick(String txt)
            //{
            //    List<ProductModel> result = new List();
            //    try
            //    {
            //        String query = "select * from THONGTINLAPTOP " + " WHERE " + " TENLAPTOP " + " LIKE ? "
            //                + " OR " + " HANG " + " LIKE ? " + " OR " + " SERIES " + " LIKE ? " +
            //                " OR " + " MAU " + " LIKE ? " + " OR " + " CPU " + " LIKE ? " + " OR " + " VGA "
            //                + " LIKE ? " + " OR " + " RAM " + " LIKE ? " + " OR " + " OCUNG " + " LIKE ?";
            //        int count = query.length() - query.replace("?", "").length();
            //        PreparedStatement ps = DBConnect.getInstance().get(query);
            //        for (int i = 1; i <= count; i++)
            //        {
            //            ps.setString(i, "%" + txt + "%");
            //        }
            //        ResultSet rs = ps.executeQuery();
            //        while (rs.next())
            //        {
            //            ProductModel ProductModel = new ProductModel(rs.GetString(1),
            //                    rs.GetString(2),
            //                    rs.GetString(3),
            //                    rs.getInt(4),
            //                    rs.GetString(5),
            //                    rs.GetString(6),
            //                    rs.GetString(7),
            //                    rs.GetString(8),
            //                    rs.GetString(9),
            //                    rs.GetString(10),
            //                    rs.GetString(11),
            //                    rs.GetString(12),
            //                    rs.GetString(13),
            //                    rs.GetString(14),
            //                    rs.GetString(15),
            //                    rs.GetString(16),
            //                    rs.GetString(17),
            //                    rs.GetString(18),
            //                    rs.GetString(19));
            //            result.add(ProductModel);
            //        }
            //        return result;
            //    }
            //    catch (SQLException | ClassNotFoundException e) {
            //    e.printStackTrace();
            //    return null;
            //}
            //    }
        }
}