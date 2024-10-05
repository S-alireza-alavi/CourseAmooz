using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TopLearn.DataLayer.Entities.Courses;

namespace TopLearn.DataLayer.Entities.Order;

public class OrderDetail
{
    [Key]
    public int DetailId { get; set; }
    
    [Required]
    public int OrderId { get; set; }
    
    [Required]
    public int CourseId { get; set; }
    
    [Required]
    public int Count { get; set; }
    
    [Required]
    public int Price { get; set; }

    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; }

    [ForeignKey("CourseId")]
    public virtual Course Course { get; set; }
}