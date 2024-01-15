using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Web.Pages.Admin.Courses;

public class EditEpisode : PageModel
{
    private ICourseService _courseService;

    public EditEpisode(ICourseService courseService)
    {
        _courseService = courseService;
    }
    
    [BindProperty]
    public CourseEpisode CourseEpisode { get; set; }
    
    public void OnGet(int id)
    {
        CourseEpisode = _courseService.GetEpisodeById(id);
    }

    public IActionResult OnPost(IFormFile fileEpisode)
    {
        if (!ModelState.IsValid)
            return Page();

        if (fileEpisode != null)
        {
            {
                if (_courseService.CheckExistFile(fileEpisode.FileName))
                {
                    ViewData["IsExistFile"] = true;
                    return Page();
                }
            }
        }

        _courseService.EditEpisode(CourseEpisode, fileEpisode);

        return Redirect("/Admin/Courses/IndexEpisode/?id=" + CourseEpisode.CourseId);
    }
}