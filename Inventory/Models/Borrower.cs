using Inventory.Database;
using Inventory.Error_Handler;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Borrower : dbConnection
    {
        public string Serial_No { get; set; }
        public string Item { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Department { get; set; }
        public DateTime Date_Borrowed { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string Head { get; set; }
        public string Lab_Assistant { get; set; }

        public void Save()
        {
            using (var cmd = CreateCommand("INSERT INTO tblBorrowers (Serial_No, Item, Firstname, Lastname, Middlename, Department, Date_Borrowed, Status, Remarks, Head, Lab_Assistant) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)"))
            {
                BindParameters(cmd, Serial_No, Item, Firstname, Lastname, Middlename, Department, Date_Borrowed, Status, Remarks, Head, Lab_Assistant);
                GetConnection();
                cmd.ExecuteNonQuery();
                GetConnectionClose();
            }
        }

        public void Update()
        {
            using (var cmd = CreateCommand("UPDATE tblBorrowers SET Item = @p1, Firstname = @p2, Lastname = @p3, Middlename = @p4, Department = @p5, Status = @p6, Remarks = @p7, Head = @p8, Lab_Assistant = @p9 WHERE Serial_No = @p10"))
            {
                BindParameters(cmd, Item, Firstname, Lastname, Middlename, Department, Status, Remarks, Head, Lab_Assistant, Serial_No);
                GetConnection();
                cmd.ExecuteNonQuery(); 
                GetConnectionClose();
            }
        }

        public static Borrower GetBorrowerBySerial(string serial)
        {
            Borrower borrower = null;
            using (var cmd = CreateCommand("SELECT * FROM tblBorrowers WHERE Serial_No= @p1"))
            {
                BindParameters(cmd, serial);
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) borrower = ConvertReaderToBorrower(reader);
                }
                GetConnectionClose();
            }
            return borrower;
        }

        public static List<Borrower> GetAllBorrowers()
        {
            List<Borrower> borrowers = new List<Borrower>();
            using (var cmd = CreateCommand("SELECT * FROM tblBorrowers"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) borrowers.Add(ConvertReaderToBorrower(reader));
                }
                GetConnectionClose();
            }
            return borrowers;
        }

        public static List<Borrower> GetAllBorrowersByDate(string start, string end)
        {
            var borrowers = new List<Borrower>();
            using (var cmd = CreateCommand("SELECT * FROM tblBorrowers WHERE Date_Borrowed BETWEEN '" + start + "' AND '" + end + "'"))
            {
                GetConnection();
                using ( var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) borrowers.Add(ConvertReaderToBorrower(reader));
                }
                GetConnectionClose();
            }
            return borrowers;
        }

        private static Borrower ConvertReaderToBorrower(DbDataReader reader)
        {
            return new Borrower
            {
                Serial_No = reader.GetString(0),
                Item = reader.GetString(1),
                Firstname = reader.GetString(2),
                Lastname = reader.GetString(3),
                Middlename = reader.GetString(4),
                Department = reader.GetString(5),
                Date_Borrowed = reader.GetDateTime(6),
                Status = reader.GetString(7),
                Remarks = reader.GetString(8),
                Head = reader.GetString(9),
                Lab_Assistant = reader.GetString(10),
            };
        }
    }
}
