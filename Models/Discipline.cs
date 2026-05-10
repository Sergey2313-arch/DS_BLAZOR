using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("Disciplines")]
    public partial class Discipline
    {
        [Key]
        [Column("discipline_id")]
        public short DisciplineId { get; set; }

        [Column("discipline_name")]
        public string? DisciplineName { get; set; }

        public virtual ICollection<TeacherDisciplineRelation> TeacherDisciplineRelations { get; set; } = new List<TeacherDisciplineRelation>();
        public virtual ICollection<DisciplineDirectionRelation> DisciplineDirectionRelations { get; set; } = new List<DisciplineDirectionRelation>();
    }
}