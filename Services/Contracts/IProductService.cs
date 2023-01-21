using DotnetWithGraphQL.Models;

namespace DotnetWithGraphQL.Services.Contracts
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product? GetProductById(long id);
        Product AddProduct(Product product);
        Product UpdateProduct(long id, Product product);
        void DeleteProduct(long id);
    }
}
