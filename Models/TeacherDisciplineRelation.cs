using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("TeachersDisciplinesRelation")]
    public class TeacherDisciplineRelation
    {
        [Column("teacher")]
        public short TeacherId { get; set; }

        [Column("discipline")]
        public short DisciplineId { get; set; }

        public Teacher? Teacher { get; set; }
        public Discipline? Discipline { get; set; }
    }
}
