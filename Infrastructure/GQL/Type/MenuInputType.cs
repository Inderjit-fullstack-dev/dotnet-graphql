using GraphQL.Types;

namespace DotnetWithGraphQL.Infrastructure.GQL.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");

            //Field<ListGraphType<SubMenuType>>("submenus");
        }
    }
}
