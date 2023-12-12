using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles;

public class EditRoleModel : PageModel
{
    private IPermissionService _permissionService;

    public EditRoleModel(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }
    
    [BindProperty] public Role Role { get; set; }
    
    public void OnGet(int id)
    {
        Role = _permissionService.GetRoleById(id);
        ViewData["Permissions"] = _permissionService.GetAllPermissions();
        ViewData["SelectedPermissions"] = _permissionService.RolePermissions(id);
    }

    public IActionResult OnPost(List<int> SelectedPermission)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _permissionService.UpdateRole(Role);
        
        _permissionService.UpdateRolePermissions(Role.RoleId, SelectedPermission);
        
        return RedirectToPage("Index");
    }
}