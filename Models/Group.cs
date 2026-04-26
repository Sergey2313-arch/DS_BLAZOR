using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyTop.Models
{
    public class Group
    {
        [Key]
        [Column("group_id")]
        public int GroupId { get; set; }

        [Column("group_name")]
        public string? GroupName { get; set; }

        [Column("direction")]
        public byte? DirectionId { get; set; }

        [Column("monday")]
        public bool Monday { get; set; }

        [Column("tuesday")]
        public bool Tuesday { get; set; }

        [Column("wednesday")]
        public bool Wednesday { get; set; }

        [Column("thursday")]
        public bool Thursday { get; set; }

        [Column("friday")]
        public bool Friday { get; set; }

        [Column("saturday")]
        public bool Saturday { get; set; }

        [Column("sunday")]
        public bool Sunday { get; set; }

        public Direction? Direction { get; set; }
        public List<Student> Students { get; set; } = new();

        [NotMapped]
        public string StudyDays
        {
            get
            {
                var days = new List<string>();
                if (Monday) days.Add("Пн.");
                if (Tuesday) days.Add("Вт.");
                if (Wednesday) days.Add("Ср.");
                if (Thursday) days.Add("Чт.");
                if (Friday) days.Add("Пт.");
                if (Saturday) days.Add("Сб.");
                if (Sunday) days.Add("Вс.");
                return days.Count == 0 ? "Не выбрано" : string.Join(", ", days);
            }
        }
    }
}
