using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    [Table("Directions")]
    public partial class Direction
    {
        [Key]
        [Column("direction_id")]
        public byte DirectionId { get; set; } // <-- ТУТ ИСПРАВЛЕН ТИП НА byte

        [Column("direction_name")]
        public string? DirectionName { get; set; }

        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
        public virtual ICollection<DisciplineDirectionRelation> DisciplineDirectionRelations { get; set; } = new List<DisciplineDirectionRelation>();
    }
}