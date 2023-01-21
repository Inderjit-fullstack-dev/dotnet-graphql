using DotnetWithGraphQL.Models;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Type
{
    public class SubMenuType : ObjectGraphType<Submenu>
    {
        public SubMenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
        }
    }
}
