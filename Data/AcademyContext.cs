using BlazorAcademyTop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAcademyTop.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDisciplineRelation> TeachersDisciplinesRelation { get; set; }
        public DbSet<DisciplineDirectionRelation> DisciplinesDirectionsRelation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Связи для Студентов и Групп
            modelBuilder.Entity<Group>()
                .HasOne(g => g.Direction)
                .WithMany(d => d.Groups)
                .HasForeignKey(g => g.DirectionId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);

            // Ключи и связи для Преподавателей и Дисциплин
            modelBuilder.Entity<TeacherDisciplineRelation>()
                .HasKey(x => new { x.TeacherId, x.DisciplineId });

            modelBuilder.Entity<TeacherDisciplineRelation>()
                .HasOne(x => x.Teacher)
                .WithMany(t => t.TeacherDisciplineRelations)
                .HasForeignKey(x => x.TeacherId);

            modelBuilder.Entity<TeacherDisciplineRelation>()
                .HasOne(x => x.Discipline)
                .WithMany(d => d.TeacherDisciplineRelations)
                .HasForeignKey(x => x.DisciplineId);

            // Ключи и связи для Дисциплин и Направлений
            modelBuilder.Entity<DisciplineDirectionRelation>()
                .HasKey(x => new { x.DirectionId, x.DisciplineId });

            modelBuilder.Entity<DisciplineDirectionRelation>()
                .HasOne(x => x.Direction)
                .WithMany(d => d.DisciplineDirectionRelations)
                .HasForeignKey(x => x.DirectionId);

            modelBuilder.Entity<DisciplineDirectionRelation>()
                .HasOne(x => x.Discipline)
                .WithMany(d => d.DisciplineDirectionRelations)
                .HasForeignKey(x => x.DisciplineId);
        }
    }
}