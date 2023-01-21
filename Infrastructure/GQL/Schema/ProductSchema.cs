using DotnetWithGraphQL.Infrastructure.GQL.Mutation;
using DotnetWithGraphQL.Infrastructure.GQL.Query;

namespace DotnetWithGraphQL.Infrastructure.GQL.Schema
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation)
        {
            Query = productQuery;
            Mutation = productMutation;
        }
    }
}
