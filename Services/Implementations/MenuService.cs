using DotnetWithGraphQL.Data;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DotnetWithGraphQL.Services.Implementations
{
    public class MenuService : IMenuService
    {
        private readonly ApplicationDBContext _context;

        public MenuService(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Menu> GetAllMenus()
        {
            return _context.Menus.Include(x => x.Submenus).ToList();
        }

        public Menu AddMenu(Menu menu)
        {
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return menu;
        }
    }
}
