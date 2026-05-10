using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("TeachersDisciplinesRelation")]
    public partial class TeacherDisciplineRelation
    {
        [Column("teacher")] 
        public short TeacherId { get; set; }

        [Column("discipline")] 
        public short DisciplineId { get; set; }

        public virtual Discipline? Discipline { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}