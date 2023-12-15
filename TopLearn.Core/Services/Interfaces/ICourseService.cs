using System.Collections.Generic;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group

        List<CourseGroup> GetAllGroups();

        #endregion
    }
}
