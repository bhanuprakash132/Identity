using System;
using System.Collections.Generic;

#nullable disable

namespace LearnIdentity.Models
{
    public partial class MenuItemPermissionMapping
    {
        public int PermissionId { get; set; }
        public int? MenuId { get; set; }
        public string RoleId { get; set; }

        public virtual MenuItem Menu { get; set; }
        public virtual AspNetRole Role { get; set; }
    }
}
