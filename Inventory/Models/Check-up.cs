using Inventory.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    internal class Check_up : dbConnection
    {
        public string Serial_Number { get; set; }
        public string Ref_No { get; set; }
        public DateTime Date_Delivered { get; set; }
        public string History { get; set; }
        public DateTime Date_Checked { get; set; }

        Statuss stat;
        public void GenerateSerialNumber()
        {
            string result = DateTime.Now.ToString("yyyyMMdd");
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM tblCheckup WHERE CAST(Date_Checked AS DATE)= CAST(GETDATE() AS DATE)"))
            {
                GetConnection();
                int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                result += count.ToString("D3");
                GetConnectionClose();
            }
            Serial_Number = result;
        }

        public static String GenerateSerialNumberForm()
        {
            string result = DateTime.Now.ToString("yyyyMMdd");
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM tblCheckup WHERE CAST(Date_Checked AS DATE)= CAST(GETDATE() AS DATE)"))
            {
                GetConnection();
                int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                result += count.ToString("D3");
                GetConnectionClose();
            }
            return result;
        }

        public async void AddCheckup()
        {
            GenerateSerialNumber();
            using (var cmd = CreateCommand("INSERT INTO tblCheckup (Serial_No, Ref_No, Date_Delivered, History, Date_Checked) VALUES (@p1, @p2, @p3, @p4, @p5)"))
            {
                BindParameters(cmd, Serial_Number, Ref_No, Date_Delivered, History, Date_Checked);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public async void UpdateCheckup()
        {
            using (var cmd = CreateCommand("UPDATE tblCheckup SET History=@p1, Date_Checked=@p2 WHERE Serial_No=@p3"))
            {
                BindParameters(cmd, History, Date_Checked, Serial_Number);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public static Check_up CheckCheckupExist(string ref_no)
        {
            Check_up checkup = null;
            using (var cmd = CreateCommand("SELECT * FROM tblCheckup WHERE Ref_No= @p1"))
            {
                BindParameters(cmd, ref_no);
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) checkup = ConvertReaderToCheckUp(reader);
                }
                GetConnectionClose();
            }
            return checkup;
        }

        public static List<Check_up> GetAllCheckUp()
        {
            List<Check_up> checkups = new List<Check_up>();
            using (var cmd = CreateCommand("SELECT * FROM tblCheckup"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) checkups.Add(ConvertReaderToCheckUp(reader));
                }
                GetConnectionClose();
            }
            return checkups;
        }

        private static Check_up ConvertReaderToCheckUp(DbDataReader reader)
        {
            return new Check_up()
            { 
                Serial_Number = reader.GetString(0),
                Ref_No = reader.GetString(1),
                Date_Delivered = reader.GetDateTime(2),
                History = reader.GetString(3),
                Date_Checked = reader.GetDateTime(4),
            };
        }
    }
}
