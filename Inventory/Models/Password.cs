using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Inventory.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Password : dbConnection
    {
        public int Id { get; set; }
        public string Pass { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public void Save()
        {
            using (var cmd = CreateCommand("INSERT INTO tblLoginPassword (Password, Question, Answer) VALUES (@p1, @p2, @p3)"))
            {
                BindParameters(cmd, Pass, Question, Answer);
                GetConnection();
                cmd.ExecuteNonQuery();
                GetConnectionClose();
            }
        }

        public void Update()
        {
            using (var cmd = CreateCommand("UPDATE tblLoginPassword SET Password = @p1, Question = @p2, Answer = @p3"))
            {
                BindParameters(cmd, Pass, Question, Answer);
                GetConnection();
                cmd.ExecuteNonQuery(); 
                GetConnectionClose();
            }
        }

        public void Delete()
        {
            using (var cmd = CreateCommand("DELETE FROM tblLoginPassword"))
            {
                GetConnection();
                cmd.ExecuteNonQuery();
                GetConnectionClose();
            }
        }

        public static Password CheckIfExist(string pass)
        {
            Password password = null;
            using (var cmd = CreateCommand("SELECT * FROM tblLoginPassword WHERE Password = '" + pass + "'"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) password = ConvertReaderToPassword(reader);
                }
                GetConnectionClose();
            }
            return password;
        }

        public static Password CheckIfAnswerRight(string answer)
        {
            Password password = null;
            using (var cmd = CreateCommand("SELECT * FROM tblLoginPassword WHERE Answer = '" + answer + "'"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) password = ConvertReaderToPassword(reader);
                }
                GetConnectionClose();
            }
            return password;
        }

        public static Password GetPassword()
        {
            Password password = null;
            using (var cmd = CreateCommand("SELECT * FROM tblLoginPassword"))
            {
                GetConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) password = ConvertReaderToPassword(reader);
                }
                GetConnectionClose();
            }
            return password;
        }

        private static Password  ConvertReaderToPassword(DbDataReader reader)
        {
            return new Password
            {
                Id = reader.GetInt32(0),
                Pass = reader.GetString(1),
                Question = reader.GetString(2),
                Answer = reader.GetString(3)
            };
        }
    }
}
