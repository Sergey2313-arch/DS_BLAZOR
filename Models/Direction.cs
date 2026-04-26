using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    public class Direction
    {
        [Key]
        [Column("direction_id")]
        public byte DirectionId { get; set; }

        [Column("direction_name")]
        public string? DirectionName { get; set; }

        public List<Group> Groups { get; set; } = new();
        public List<DisciplineDirectionRelation> DisciplineDirectionRelations { get; set; } = new();
    }
}
