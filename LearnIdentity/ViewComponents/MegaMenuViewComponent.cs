using LearnIdentity.Models;
using LearnIdentity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnIdentity.ViewComponents
{
    public class MegaMenuViewComponent : ViewComponent
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly LearnNetCoreContext _context;

        public MegaMenuViewComponent(UserManager<IdentityUser> userManager, LearnNetCoreContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var Role = _context.UserRoles.FirstOrDefault(u => u.UserId == userId);
            if (Role != null)
            {
                var RoleId = Role.RoleId;
                var roleData = _context.Roles.FirstOrDefault(x => x.Id == RoleId);
                ViewBag.RoleName = roleData.Name;
                var result = (from Menus in _context.MenuItems
                              join Permissions in _context.MenuItemPermissionMappings.Where(r => r.RoleId == RoleId)
                              on Menus.Id equals Permissions.MenuId
                              select new MenuPermissionMappingViewModel
                              {
                                  Id = Menus.Id,
                                  Name = Menus.Name,
                                  ParentId = Menus.ParentId,
                                  HasAccess = true
                              }).ToList();
                return View(result);
            }

            //List<MenuPermissionMappingViewModel> listpmv = new List<MenuPermissionMappingViewModel>();
            return View();
        }
    }
}
