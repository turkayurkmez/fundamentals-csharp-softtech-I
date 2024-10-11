
namespace LINQBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ: Language INtegrated Query
            var products = new ProductService().GetProducts();

            //1000 TL'nin altındaki ürünler:
            var underThousand = GetProductsForUnder1000(products);

            showProducts(underThousand);

        }

        private static void showProducts(List<Product> underThousand)
        {
            foreach (var product in underThousand) {
                Console.WriteLine($"{product.Name} {product.Price}");
            }
        }

        static List<Product> GetProductsForUnder1000(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price < 1000)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
    }
}
