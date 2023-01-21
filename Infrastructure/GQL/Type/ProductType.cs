using DotnetWithGraphQL.Models;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
