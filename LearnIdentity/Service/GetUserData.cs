using LearnIdentity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnIdentity.Service
{
    public class GetUserData
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly LearnNetCoreContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;

        public GetUserData(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> SignInManager, LearnNetCoreContext context)
        {
            _userManager = userManager;
            _context = context;
            _signInManager = SignInManager;
        }

        //public async Task<IActionResult> GetLogedInUserData(string email)
        //{
        //    var user = await User.FindFirstValue(ClaimTypes.Email)
        //}
    }
}
