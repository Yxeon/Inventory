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
    public class Statuss : dbConnection
    {
        public string Stat { get; set; }
        public string Ref_No { get; set; }
        public string Remarks { get; set; }
        public DateTime Date_Diposed { get; set; }

        public static List<Statuss> GetAllStatus()
        {
            List<Statuss> statusList = new List<Statuss>();
            using (var cmd = CreateCommand("SELECT * FROM tblStatus"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) statusList.Add(ConvertReaderToStatus(reader));
                }
                GetConnectionClose();
            }
             return statusList;
        }

        public async void SaveStatus()
        {
            if (CheckStatusExist(Ref_No) != null) return;
            using (var cmd = CreateCommand("INSERT INTO tblStatus (Status, Ref_No, Remarks, Date_Disposed) VALUES (@p1, @p2, @p3, @p4)"))
            {
                BindParameters(cmd, Stat, Ref_No, Remarks, Date_Diposed);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public async void UpdateStatus()
        {
            using (var cmd = CreateCommand("UPDATE tblStatus SET Status=@p1, Remarks=@p2, Date_Disposed=@p3 WHERE Ref_No=@p4"))
            {
                BindParameters(cmd, Stat, Remarks, Date_Diposed, Ref_No);
                GetConnection();
                await cmd.ExecuteNonQueryAsync();
                GetConnectionClose();
            }
        }

        public static Statuss CheckStatusExist(string ref_no)
        {
            Statuss stat = null;
            using (var cmd = CreateCommand("SELECT * FROM tblStatus WHERE Ref_No=@p1"))
            {
                BindParameters(cmd, ref_no);
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) stat = ConvertReaderToStatus(reader);
                }
                GetConnectionClose();
            }
            return stat;
        }

        private static Statuss ConvertReaderToStatus(DbDataReader reader)
        {
            return new Statuss()
            {
                Stat = reader.GetString(0),
                Ref_No = reader.GetString(1),
                Remarks = reader.GetString(2),
                Date_Diposed = reader.GetDateTime(3),
            };
        }
    }
}
