using DotnetWithGraphQL.Infrastructure.GQL.Type;
using DotnetWithGraphQL.Services.Contracts;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {

            Field<ListGraphType<MenuType>>("menus", resolve: context => {
                return menuService.GetAllMenus();
            });
        }
    }
}
