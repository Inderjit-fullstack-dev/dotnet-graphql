using DotnetWithGraphQL.Infrastructure.GQL.Mutation;
using DotnetWithGraphQL.Infrastructure.GQL.Query;

namespace DotnetWithGraphQL.Infrastructure.GQL.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) 
            : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
