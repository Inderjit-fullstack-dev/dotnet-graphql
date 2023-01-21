using DotnetWithGraphQL.Models;

namespace DotnetWithGraphQL.Services.Contracts
{
    public interface IMenuService
    {
        List<Menu> GetAllMenus();
        Menu AddMenu(Menu menu);
    }
}
