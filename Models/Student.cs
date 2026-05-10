using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("Students")]
    public partial class Student
    {
        [Key]
        [Column("stud_id")]
        public int StudId { get; set; }

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

        [Column("group")] // <-- ВОТ ТУТ ТОЖЕ ИМЯ КОЛОНКИ БЕЗ _id
        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group? Group { get; set; }

        [NotMapped]
        public string AgeString
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                if (BirthDate.Date > DateTime.Today.AddYears(-age)) age--;
                int lastDigit = age % 10;
                int lastTwoDigits = age % 100;
                if (lastTwoDigits >= 11 && lastTwoDigits <= 14) return $"{age} лет";
                if (lastDigit == 1) return $"{age} год";
                if (lastDigit >= 2 && lastDigit <= 4) return $"{age} года";
                return $"{age} лет";
            }
        }
    }
}