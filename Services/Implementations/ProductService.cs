using DotnetWithGraphQL.Data;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;

namespace DotnetWithGraphQL.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDBContext _context;
        public ProductService(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product? GetProductById(long id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                throw new Exception("Product not found");

            return product;
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(long id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                throw new Exception("Product not found");

            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product UpdateProduct(long id, Product product)
        {
            var productInDB = _context.Products.Find(id);
            if (productInDB == null)
                throw new Exception("Product not found");

            productInDB.Name = product.Name;
            productInDB.Price = product.Price;
            _context.SaveChanges();

            return productInDB;
        }
    }
}
