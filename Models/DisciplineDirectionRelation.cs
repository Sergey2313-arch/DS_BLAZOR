using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("DisciplinesDirectionsRelation")]
    public class DisciplineDirectionRelation
    {
        [Column("direction")]
        public byte DirectionId { get; set; }

        [Column("discipline")]
        public short DisciplineId { get; set; }

        public Direction? Direction { get; set; }
        public Discipline? Discipline { get; set; }
    }
}
