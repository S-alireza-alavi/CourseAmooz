﻿using System.Collections.Generic;
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
        List<SelectListItem> GetStatuses();

        #endregion

        #region Course

        List<ShowCourseForAdminViewModel> GetCoursesForAdmin();
        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Course GetCourseById(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);

        #endregion

        #region Episode

        List<CourseEpisode> GetListEpisodeCourse(int courseId);
        bool CheckExistFile(string fileName);
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);

        #endregion
    }
}
