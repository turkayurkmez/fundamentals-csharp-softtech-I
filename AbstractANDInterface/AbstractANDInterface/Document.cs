using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{

    public interface IPrintable
    {
        //Interface, bir sınıfa bazı üyeleri (özellik veya fonksiyon) ekleyen sözleşmelerdir.
        void Print();
    }
    public abstract class Document
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }

        public abstract void Open();
        public abstract void Save();
       // public abstract void Print();
      

        public void Copy(string from, string to)
        {
            Console.WriteLine("Dosya taşındı....");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel dosyası açılıyor....");
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alındı!");

        }

        public override void Save()
        {
            Console.WriteLine("Excel dosyası kaydedildi....");
        }
    }
    //concrete
    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word dosyası açılıyor....");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alındı!");
        }

        public override void Save()
        {
            Console.WriteLine("Word dosyası kaydedildi....");
        }
    }
    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF dosyası açılıyor....");
        }

      

        public override void Save()
        {
            Console.WriteLine("PDF dosyası kaydedildi....");
        }
    }

    public class DocumentSaverComponent
    {
        public void Save(Document document)
        {
            document.Save();
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
