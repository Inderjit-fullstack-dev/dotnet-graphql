using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DotnetWithGraphQL.Models
{
    public class Menu
    {
        public Menu()
        {
            Submenus = new Collection<Submenu>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public ICollection<Submenu> Submenus { get; set; }
    }
}
