using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.DTOs.Course;
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
        List<SelectListItem> GetStatues();
        void AddGroup(CourseGroup courseGroup);
        void UpdateGroup(CourseGroup courseGroup);
        CourseGroup GetGroupById(int id);


        #endregion

        #region Course

        List<ShowCourseForAdminViewModel> GetCoursesForAdmin();

        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Course GetCourseById(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);

        Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = "",
            string getType = "all",
            string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null,
            int take = 0);

        Course GetCourseForShow(int courseId);
        List<ShowCourseListItemViewModel> GetPopularCourses();

        #endregion

        #region Episode

        List<CourseEpisode> GetListEpisodeCorse(int courseId);
        bool CheckExistFile(string fileName);
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);

        #endregion

        #region Comments

        void AddComment(CourseComment comment);
        Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1);

        #endregion
    }
}
