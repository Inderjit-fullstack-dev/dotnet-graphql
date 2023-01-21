using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<ProductQuery>("productQuery", resolve: context => new { });
            Field<MenuQuery>("menuQuery", resolve: context => new { });
        }
    }
}
