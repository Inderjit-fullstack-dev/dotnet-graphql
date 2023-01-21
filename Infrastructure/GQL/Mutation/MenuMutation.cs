using DotnetWithGraphQL.Infrastructure.GQL.Type;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;
using GraphQL;
using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuService menuService)
        {
            Field<MenuType>("createMenu", 
                arguments: new QueryArguments
                (
                    new QueryArgument<MenuInputType>
                    { 
                        Name = "menu",
                    }
                ), 
                resolve: context => 
                {
                    return menuService.AddMenu(context.GetArgument<Menu>("menu"));
                });
        }
    }
}
