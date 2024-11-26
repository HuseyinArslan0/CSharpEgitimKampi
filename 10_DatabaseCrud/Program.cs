﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Ekleme İşlemi

            // CRUD -> create read update delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=MATEBOOK-HA;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarılı bir şekilde eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MATEBOOK-HA; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün bilgileri başarılı bir şekilde eklendi!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=MATEBOOK-HA; initial catalog=EgitimKampiDb; integrated security=true");

            //SqlCommand command = new SqlCommand("select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write($"{item} ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MATEBOOK-HA; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine($"Ürün başarıyla silindi");

            #endregion

            #region Ürün Güncelleme İşlemi

            //int productId;
            //string productName;
            //decimal productPrice;

            //Console.Write("Güncellenecek Ürün Id: ");
            //productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Yeni Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Yeni Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MATEBOOK-HA; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("update TblProduct set " +
            //    "ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Veriler başarılı bir şekilde güncellendi!");

            #endregion

            Console.Read();
        }
    }
}