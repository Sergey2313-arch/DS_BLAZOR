using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("Groups")]
    public partial class Group
    {
        [Key]
        [Column("group_id")]
        public int GroupId { get; set; }

        [Column("group_name")]
        public string? GroupName { get; set; }

        [Column("direction")] // <-- ВОТ ОНО! Имя колонки в БД без _id
        public byte? DirectionId { get; set; }

        [ForeignKey("DirectionId")]
        public virtual Direction? Direction { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}