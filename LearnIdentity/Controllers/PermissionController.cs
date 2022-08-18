using LearnIdentity.Models;
using LearnIdentity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnIdentity.Controllers
{
    public class PermissionController : Controller
    {
        private readonly LearnNetCoreContext _context;

        public PermissionController(LearnNetCoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPermissions(string RoleId)
        {
            List<MenuPermissionMappingViewModel> lstPermission = new List<MenuPermissionMappingViewModel>();

            var result = (from Menus in _context.MenuItems
                          join Permissions in _context.MenuItemPermissionMappings.Where(r => r.RoleId == RoleId)
                          on Menus.Id equals Permissions.MenuId into menuPerm
                          from perm in menuPerm.DefaultIfEmpty()
                          select new MenuPermissionMappingViewModel
                          {
                              Id = Menus.Id,
                              Name = Menus.Name,
                              ParentId = Menus.ParentId,
                              HasAccess = perm == null ? false : !(string.IsNullOrEmpty(Convert.ToString(perm.RoleId)))
                          }).ToList();

            var RolesList = (from roles in _context.Roles
                             select new SelectListItem
                             {
                                 Value = roles.Id,
                                 Text = roles.Name
                             }).ToList();
            ViewBag.RolesList = RolesList;
            return View(result);
        }

        [HttpPost]
        public JsonResult UpdatePermission([FromBody] UpdatePermissionViewModel[] model)
        {
            if (model != null)
            {
                int count = 0;
                foreach (var item in model)
                {
                    if (count == 0)
                    {
                        var existing = _context.MenuItemPermissionMappings.Where(R => R.RoleId == item.RoleId);

                        foreach (var roles in existing)
                        {
                            _context.MenuItemPermissionMappings.Remove(roles);
                        }
                        count++;
                    }
                    MenuItemPermissionMapping mnp = new MenuItemPermissionMapping();
                    mnp.MenuId = item.MenuId;
                    mnp.RoleId = item.RoleId;
                    _context.MenuItemPermissionMappings.Add(mnp);
                }
                _context.SaveChanges();
                return Json("Saved Successfully!");
            }
            return Json("NoData");
        }
    }
}
