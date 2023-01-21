using DotnetWithGraphQL.Data;
using DotnetWithGraphQL.Models;
using DotnetWithGraphQL.Services.Contracts;

namespace DotnetWithGraphQL.Services.Implementations
{
    public class SubmenuService : ISubmenuService
    {
        private readonly ApplicationDBContext _context;

        public SubmenuService(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Submenu> GetSubmenus(int menuId)
        {
            return _context.Submenus.Where(x => x.MenuId == menuId).ToList();
        }

        public Submenu AddSubMenu(Submenu submenu)
        {
            _context.Submenus.Add(submenu);
            _context.SaveChanges();
            return submenu;
        }
    }
}
