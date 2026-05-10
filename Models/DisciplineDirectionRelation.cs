using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("DisciplinesDirectionsRelation")]
    public partial class DisciplineDirectionRelation
    {
        [Column("direction")] 
        public byte DirectionId { get; set; }

        [Column("discipline")] 
        public short DisciplineId { get; set; }

        public virtual Direction? Direction { get; set; }
        public virtual Discipline? Discipline { get; set; }
    }
}