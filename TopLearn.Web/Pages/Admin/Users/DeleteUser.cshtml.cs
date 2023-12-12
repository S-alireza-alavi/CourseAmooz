using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs.User;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users;

public class DeleteUser : PageModel
{
    private IUserService _userService;

    public DeleteUser(IUserService userService)
    {
        _userService = userService;
    }

    public InformationUserViewModel InformationUserViewModel { get; set; }
    
    public void OnGet(int id)
    {
        ViewData["UserId"] = id;
        InformationUserViewModel = _userService.GetUserInformation(id);
    }

    public IActionResult OnPost(int UserId)
    {
        _userService.DeleteUser(UserId);
        return RedirectToPage("Index");
    }
}