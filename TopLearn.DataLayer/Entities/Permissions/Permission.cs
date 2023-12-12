using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopLearn.DataLayer.Entities.Permissions;

public class Permission
{
    [Key]
    public int PermissionId { get; set; }
    [Display(Name = "عنوان دسترسی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
    public string PermissionTitle { get; set; }
    public int? ParentId { get; set; }

    [ForeignKey("ParentId")]
    public List<Permission> Permissions { get; set; }

    public List<RolePermission> RolePermissions { get; set; }
}