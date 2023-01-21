using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;

namespace DotnetWithGraphQL.Services.Implementations
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Tea", Price = 50.00 },
                new Product { Id = 2, Name = "Coffie", Price = 100.00 },
            };
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product? GetProductById(long id)
        {
            var product = products.Find(x => x.Id == id);
            if (product == null)
                throw new Exception("Product not found");

            return product;
        }

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(long id)
        {
            var index = products.FindIndex(x => x.Id == id);
            if (index == -1)
                throw new Exception("Product not found");

            products.RemoveAt(index);
        }

        public Product UpdateProduct(long id, Product product)
        {
            var productInDB = products.Find(x => x.Id == id);
            if (productInDB == null)
                throw new Exception("Product not found");

            productInDB.Name = product.Name;
            productInDB.Price = product.Price;

            return productInDB;
        }
    }
}
