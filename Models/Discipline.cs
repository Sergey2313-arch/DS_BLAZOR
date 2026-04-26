using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    public class Discipline
    {
        [Key]
        [Column("discipline_id")]
        public short DisciplineId { get; set; }

        [Column("discipline_name")]
        public string? DisciplineName { get; set; }

        [Column("number_of_lessons")]
        public byte NumberOfLessons { get; set; }

        public List<TeacherDisciplineRelation> TeacherDisciplineRelations { get; set; } = new();
        public List<DisciplineDirectionRelation> DisciplineDirectionRelations { get; set; } = new();
    }
}
