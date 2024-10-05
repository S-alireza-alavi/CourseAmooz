using System.ComponentModel.DataAnnotations;

namespace TopLearn.DataLayer.Entities.Courses;

public class UserCourse
{
    [Key]
    public int UC_Id { get; set; }
    public int UserId { get; set; }
    public int CourseId { get; set; }
    
    public Course Course { get; set; }
    public User.User User { get; set; }
}