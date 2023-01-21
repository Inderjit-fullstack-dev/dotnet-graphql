using DotnetWithGraphQL.Models;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
            Field(x => x.Submenus);
        }
    }
}
