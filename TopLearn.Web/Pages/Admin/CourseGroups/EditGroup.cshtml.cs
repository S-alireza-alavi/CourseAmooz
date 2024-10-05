using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Web.Pages.Admin.CourseGroups
{
    public class EditGroupModel : PageModel
    {
        private ICourseService _courseService;

        public EditGroupModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public CourseGroup CourseGroup { get; set; }

        public void OnGet(int id)
        {
            CourseGroup = _courseService.GetGroupById(id); 
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _courseService.UpdateGroup(CourseGroup);

            return RedirectToPage("Index");
        }
    }
}
