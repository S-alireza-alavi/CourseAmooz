using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Web.Pages.Admin.CourseGroups
{
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<CourseGroup> CourseGroups { get; set; }

        public void OnGet()
        {
            CourseGroups = _courseService.GetAllGroups();
        }
    }
}
