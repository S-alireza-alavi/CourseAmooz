using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs.User;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users;

public class EditUserModel : PageModel
{
    private IUserService _userService;
    private IPermissionService _permissionService;

    public EditUserModel(IUserService userService, IPermissionService permissionService)
    {
        _userService = userService;
        _permissionService = permissionService;
    }

    [BindProperty]
    public EditUserViewModel EditUserViewModel { get; set; }
    
    public void OnGet(int id)
    {
        EditUserViewModel = _userService.GetUserForShowInEditMode(id);
        ViewData["Roles"] = _permissionService.GetRoles();
    }

    public IActionResult OnPost(List<int> SelectedRoles)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _userService.EditUserByAdmin(EditUserViewModel);
        
        //Edit roles
        _permissionService.EditUserRoles(EditUserViewModel.UserId, SelectedRoles);
        
        return RedirectToPage("Index");
    }
}