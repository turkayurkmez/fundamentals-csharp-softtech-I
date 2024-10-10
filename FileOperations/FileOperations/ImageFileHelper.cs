using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public static class ImageFileHelper
    {
        public static List<string> FindImages(string path, bool isCreateLogFile = false)
        {
            ArgumentNullException.ThrowIfNullOrEmpty("path");
            string[] files = null;
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException($"{path} adresinde klasör bulunamadı!");
            }

            files = Directory.GetFiles(path, "*.png", SearchOption.AllDirectories);

            if (isCreateLogFile)
            {
                File.WriteAllLines($"{path}\\log.txt", files);
            }

            return files.ToList();




        }
    }
}
