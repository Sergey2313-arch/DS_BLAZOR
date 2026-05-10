using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("Teachers")]
    public partial class Teacher
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
        public DateTime? WorkSince { get; set; }

        [Column("rate", TypeName = "smallmoney")]
        public decimal? Rate { get; set; }

        public virtual ICollection<TeacherDisciplineRelation> TeacherDisciplineRelations { get; set; } = new List<TeacherDisciplineRelation>();

        [NotMapped]
        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();

        [NotMapped]
        public string AgeString
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                if (BirthDate.Date > DateTime.Today.AddYears(-age)) age--;
                return $"{age} лет";
            }
        }
    }
}