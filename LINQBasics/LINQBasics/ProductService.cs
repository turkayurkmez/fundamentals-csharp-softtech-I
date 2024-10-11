using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasics
{
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            var products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Description = "Yüksek performanslı bir ürün.", Price = 965.58M },
    new Product { Id = 2, Name = "Mikrofon", Description = "Tüm oyun severler için mükemmel.", Price = 2495.02M },
    new Product { Id = 3, Name = "Klavye", Description = "Kullanıcı dostu arayüz.", Price = 1956.82M },
    new Product { Id = 4, Name = "Monitör", Description = "Taşınabilir ve pratik.", Price = 4990.85M },
    new Product { Id = 5, Name = "Hoparlör", Description = "Güvenilir bağlantı özellikleri.", Price = 149.03M },
    new Product { Id = 6, Name = "Televizyon", Description = "Yüksek çözünürlüklü ekran.", Price = 3200.45M },
    new Product { Id = 7, Name = "Tablet", Description = "Günlük kullanım için ideal.", Price = 1150.50M },
    new Product { Id = 8, Name = "USB Bellek", Description = "Çok fonksiyonlu ve uygun fiyatlı.", Price = 200.99M },
    new Product { Id = 9, Name = "Smartwatch", Description = "Gelişmiş teknolojik özelliklere sahip.", Price = 2850.76M },
    new Product { Id = 10, Name = "Mouse", Description = "Ergonomik ve kullanışlı.", Price = 340.89M },
    new Product { Id = 11, Name = "Kamera", Description = "Şık tasarımı ile dikkat çekiyor.", Price = 4120.39M },
    new Product { Id = 12, Name = "Sırt Çantası", Description = "Dayanıklı ve hafif.", Price = 450.50M },
    new Product { Id = 13, Name = "Akıllı Telefon", Description = "En yeni özelliklerle donatılmış.", Price = 3499.99M },
    new Product { Id = 14, Name = "Hoparlör", Description = "Yüksek kaliteli ses sunar.", Price = 999.99M },
    new Product { Id = 15, Name = "Powerbank", Description = "Uzun ömürlü batarya kapasitesi.", Price = 299.95M },
    new Product { Id = 16, Name = "Kulaklık", Description = "Yüksek performanslı bir ürün.", Price = 549.49M },
    new Product { Id = 17, Name = "Akıllı Bileklik", Description = "Kullanıcı dostu arayüz.", Price = 799.99M },
    new Product { Id = 18, Name = "Hafıza Kartı", Description = "Şık tasarımı ile dikkat çekiyor.", Price = 129.90M },
    new Product { Id = 19, Name = "Gözlük", Description = "Çok fonksiyonlu ve uygun fiyatlı.", Price = 189.00M },
    new Product { Id = 20, Name = "Oyun Konsolu", Description = "Tüm oyun severler için mükemmel.", Price = 4490.50M }
};

        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
