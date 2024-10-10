using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /// <summary>
    /// Excel dosyasındaki verileri kullanarak; PDF veya HTML raporu oluşturan nesnenin sınıfı....
    /// </summary>
    public class ReportGenerator
    {

        public string DocumentFormat { get; set; }
        public string ExcelFilePath { get; set; }

        public  ReportGenerator(string excelFilePath) : this(excelFilePath,"PDF")
        {
            //ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath, nameof(excelFilePath));
            //ExcelFilePath = excelFilePath;
            //varsayılan değerleri atamak:
            //DocumentFormat = "PDF";
            

        }

        public ReportGenerator(string excelFilePath, string documentFormat)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath, nameof(excelFilePath));
            ExcelFilePath = excelFilePath;
            DocumentFormat = documentFormat;
        }

    }
}
