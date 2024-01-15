using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Web.Pages.Admin.Courses;

public class IndexEpisodeModel : PageModel
{
    private ICourseService _courseService;

    public IndexEpisodeModel(ICourseService courseService)
    {
        _courseService = courseService;
    }
    public List<CourseEpisode> CourseEpisodes { get; set; }
    public void OnGet(int id)
    {
        ViewData["CourseId"] = id;
        CourseEpisodes = _courseService.GetListEpisodeCourse(id);
    }
}