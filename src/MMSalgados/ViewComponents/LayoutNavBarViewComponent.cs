﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MMSalgados.WebUI.Identity;
using MMSalgados.WebUI.ViewModels.Components;
using System.Threading.Tasks;

namespace MMSalgados.WebUI.ViewComponents
{
    [ViewComponent(Name = "LayoutNavBarViewComponent")]
    public class LayoutNavBarViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public LayoutNavBarViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var appUser = await _userManager.FindByNameAsync(
                HttpContext.User.Identity.Name);

            var vm = new LayoutNavBarViewModel
            {
                UserName = appUser?.UserName,
                Email = appUser?.Email,
                Image = appUser?.Image
            };

            return View("../Shared/_LayoutNavBar.cshtml", vm);
        }
    }
}
