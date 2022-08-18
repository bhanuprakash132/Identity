using System;
using System.Collections.Generic;

#nullable disable

namespace LearnIdentity.Models
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            MenuItemPermissionMappings = new HashSet<MenuItemPermissionMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<MenuItemPermissionMapping> MenuItemPermissionMappings { get; set; }
    }
}
