using DotnetWithGraphQL.Models;

namespace DotnetWithGraphQL.Services.Contracts
{
    public interface ISubmenuService
    {
        List<Submenu> GetSubmenus(int menuId);
        Submenu AddSubMenu(Submenu submenu);
    }
}
