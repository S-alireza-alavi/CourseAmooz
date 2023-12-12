using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles;

public class CreateRoleModel : PageModel
{
    private IPermissionService _permissionService;

    public CreateRoleModel(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    [BindProperty] public Role Role { get; set; }

    public void OnGet()
    {
        ViewData["Permissions"] = _permissionService.GetAllPermissions();
    }

    public IActionResult OnPost(List<int> SelectedPermission)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Role.IsDeleted = false;
        int roleId = _permissionService.AddRole(Role);
        
        _permissionService.AddPermissionsToRole(roleId, SelectedPermission);

        return RedirectToPage("Index");
    }
}