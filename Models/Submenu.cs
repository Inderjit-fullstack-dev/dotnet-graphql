﻿using System.ComponentModel.DataAnnotations;

namespace DotnetWithGraphQL.Models
{
    public class Submenu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int MenuId { get; set; }
    }
}
