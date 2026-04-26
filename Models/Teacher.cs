using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    public class Teacher
    {
        [Key]
        [Column("teacher_id")]
        public short TeacherId { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("work_since")]
        public DateTime WorkSince { get; set; }

        [Column("rate", TypeName = "smallmoney")]
        public decimal Rate { get; set; }

        public List<TeacherDisciplineRelation> TeacherDisciplineRelations { get; set; } = new();

        [NotMapped]
        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();
    }
}
