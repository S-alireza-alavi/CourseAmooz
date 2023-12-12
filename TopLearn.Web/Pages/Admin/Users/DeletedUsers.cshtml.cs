using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs.User;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users;

public class DeletedUsersModel : PageModel
{
    private IUserService _userService;

    public DeletedUsersModel(IUserService userService)
    {
        _userService = userService;
    }

    public UsersForAdminViewModel UsersForAdminViewModel { get; set; }

    public void OnGet(int pageId = 1, string filterUserName = "", string filterEmail = "")
    {
        //TODO: change the commands later, it's just like the Users list page commands
        UsersForAdminViewModel = _userService.GetDeletedUsers(pageId, filterEmail, filterUserName);
    }
}