using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group

        List<CourseGroup> GetAllGroups();
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatuses();

        #endregion
    }
}
