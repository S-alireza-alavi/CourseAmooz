using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopLearn.DataLayer.Entities.Courses;

public class CourseLevel
{
    [Key]
    public int LevelId { get; set; }
    
    [Required()]
    [MaxLength(150)]
    public string LevelTitle { get; set; }

    public List<Course> Courses { get; set; }
}