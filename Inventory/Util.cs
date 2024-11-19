using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    class Util
    {
        public static string SaveAndGetExcelName(string report)
        {
            string fileName = report + DateTime.Now.ToString("yyyy_MM_dd_hhmmss") + ".xlsx";
            return Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/Backup/", fileName);
        }

        public static string SaveAndGetUploadedImageName(string file)
        {
            long size = file.Length;
            if (size > (5 * 1024 * 1024)) return "Maximum file size is 5mb.";

            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "assets/images");
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            return fileName;
        }

        public static string CopyImage(string source, string filename)
        {
            CreateImageDirectory();
            filename = Path.GetFileName(filename);
            string destination = Path.Combine("images", filename);
            if (File.Exists(destination))
            {
                FileReplace(source, destination);
            }
            else
            {
                File.Copy(source, destination);
            }
            return destination;
        }

        public static void FileReplace(string source, string destination)
        {
            if (File.Exists(destination + ".bak")) File.Delete(destination + ".bak");
            File.Copy(destination, destination + ".bak");
            File.Delete(destination);
            File.Copy(source, destination);
        }

        public static string GetFullPath(string path)
        {
            return Path.Combine(Application.StartupPath, path);
        }

        private static void CreateImageDirectory()
        {
            if (!Directory.Exists("images"))
            {
                Directory.CreateDirectory("images");
            }
        }
    }
}
