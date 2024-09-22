using System.ComponentModel.DataAnnotations;

namespace TaskHive_HelperService
{
    public class DepartmentDataModel
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public required string Name { get; set;}
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }

    }
}