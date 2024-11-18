using Inventory.Database;
using Inventory.Error_Handler;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Models
{
    public class Product : dbConnection
    {
        public string Ref_No { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string End_User { get; set; }
        public string Diagnosed { get; set; }
        public string Picture { get; set; }
        public DateTime Date_Delivered { get; set; }

        public string Serial_Number { get; set; }
        public DateTime Date_Checked { get; set; }

        public string Remarks { get; set; }
        public DateTime Date_Disposed { get; set; }

        private static Product CheckProduct(string referenceNo)
        {
            Product product = null;
            using (var cmd = CreateCommand("SELECT * FROM tblProduct WHERE Ref_No = @p1"))
            {
                BindParameters(cmd, referenceNo);
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) product = ConvertReaderToProduct(reader);
                }
                GetConnectionClose();
            }
            return product;
        }

        public async void AddProduct()
        {
            if (CheckProduct(Ref_No) != null) throw new Level1Exception("Product reference already exist");
            using (var cmd = CreateCommand("INSERT INTO tblProduct (Ref_No, Item, Description, End_User, Diagnosed, Picture, Date_Delivered) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)"))
            {
                BindParameters(cmd, Ref_No, Item, Description, End_User, Diagnosed, Picture, Date_Delivered);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public static Product SearchProduct(string refereenceNo)
        {
            Product product = null;
            using (var cmd = CreateCommand("SELECT * FROM tblProduct WHERE Ref_No = @p1"))
            {
                BindParameters(cmd, refereenceNo);
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) product = ConvertReaderToProduct(reader);
                }
                GetConnectionClose();
            }
            return product;
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var cmd = CreateCommand("SELECT * FROM tblProduct"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) products.Add(ConvertReaderToProduct(reader));
                }
                GetConnectionClose();
            }
            return products;
        }

        public static List<Product> SearchProductBy(string column, string text)
        {
            List<Product> products = new List<Product>();
            using(var cmd = CreateCommand("SELECT * FROM tblProduct WHERE " + column + " LIKE '" + text + "%'"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) products.Add(ConvertReaderToProduct(reader));
                }
                GetConnectionClose();
            }
            return products;
        }

        public async void UpdateProduct()
        {
            using (var cmd = CreateCommand("UPDATE tblProduct SET Item = @p2, Description = @p3, End_User = @p4, Diagnosed = @p5, Picture = @p6 WHERE Ref_No = @p1"))
            {
                BindParameters(cmd, Ref_No, Item, Description, End_User, Diagnosed, Picture);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public async void DeleteProduct()
        {
            using (var cmd = CreateCommand("DELETE FROM tblProduct WHERE Ref_No = @p1"))
            {
                BindParameters(cmd, Ref_No);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();   
                GetConnectionClose();
            }
        }

        public static List<Product> GetAllProductsWithStatus()
        {
            List<Product> products = new List<Product>();
            using (var cmd = CreateCommand("SELECT dbo.tblProduct.*, dbo.tblCheckup.Serial_No, dbo.tblCheckup.Date_Checked, dbo.tblStatus.Remarks, dbo.tblStatus.Date_Disposed " +
                                            "FROM dbo.tblProduct " +
                                            "INNER JOIN dbo.tblStatus ON dbo.tblProduct.Ref_no = dbo.tblStatus.Ref_No " +
                                            "INNER JOIN dbo.tblCheckup ON dbo.tblProduct.Ref_no = dbo.tblCheckup.Ref_No"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) products.Add(ConvertViewToProduct(reader));
                }
                GetConnectionClose();
            }
            return products;
        }

        public static List<Product> GetAllProductsWithStatusByDate(string start, string end)
        {
            List<Product> products = new List<Product>();
            using (var cmd = CreateCommand("SELECT dbo.tblProduct.*, dbo.tblCheckup.Serial_No, dbo.tblCheckup.Date_Checked, dbo.tblStatus.Remarks, dbo.tblStatus.Date_Disposed " +
                                            "FROM dbo.tblProduct " +
                                            "INNER JOIN dbo.tblStatus ON dbo.tblProduct.Ref_no = dbo.tblStatus.Ref_No " +
                                            "INNER JOIN dbo.tblCheckup ON dbo.tblProduct.Ref_no = dbo.tblCheckup.Ref_No " +
                                            "WHERE dbo.tblStatus.Date_Disposed BETWEEN '" + start + "' AND '" + end + "'" ))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) products.Add(ConvertViewToProduct(reader));
                }
                GetConnectionClose();
            }
            return products;
        }

        public static Product ConvertViewToProduct(DbDataReader reader)
        {
            return new Product()
            {
                Ref_No = reader.GetString(0),
                Item = reader.GetString(1),
                Description = reader.GetString(2),
                End_User = reader.GetString(3),
                Diagnosed = reader.GetString(4),
                Picture = reader.GetString(5),
                Date_Delivered = reader.GetDateTime(6),
                Serial_Number = reader.GetString(7),
                Date_Checked = reader.GetDateTime(8),
                Remarks = reader.GetString(9),
                Date_Disposed = reader.GetDateTime(10),
            };
        }

        public static Product ConvertReaderToProduct(DbDataReader reader)
        {
            return new Product()
            {
                Ref_No = reader.GetString(0),
                Item = reader.GetString(1),
                Description = reader.GetString(2),
                End_User = reader.GetString(3),
                Diagnosed = reader.GetString(4),
                Picture = reader.GetString(5),
                Date_Delivered = reader.GetDateTime(6),
            };
        }
    }
}
