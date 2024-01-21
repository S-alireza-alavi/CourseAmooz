using System;
using System.ComponentModel.DataAnnotations;

namespace TopLearn.DataLayer.Entities.Courses;

public class CourseComment
{
    [Key]
    public int CommentId { get; set; }
    
    public int CourseId { get; set; }
    
    public int UserId { get; set; }
    
    [MaxLength(700)]
    public string Comment { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public bool IsAdminRead { get; set; }

    #region Relations

    public Course Course { get; set; }
    public User.User User { get; set; }

    #endregion
}