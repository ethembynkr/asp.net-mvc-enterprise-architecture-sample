namespace Simple.Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class simpleDbContext : DbContext
    {
        public simpleDbContext()
            : base("name=simpleDbContext")
        {
        }

        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<LessonsInfo> LessonsInfo { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lessons>()
                .Property(e => e.LessonName)
                .IsUnicode(false);

            modelBuilder.Entity<Lessons>()
                .Property(e => e.LessonDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Lessons>()
                .HasMany(e => e.LessonsInfo)
                .WithRequired(e => e.Lessons)
                .HasForeignKey(e => e.LessonId);

            modelBuilder.Entity<Students>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .HasMany(e => e.LessonsInfo)
                .WithRequired(e => e.Teachers)
                .HasForeignKey(e => e.TeacherId);
        }
    }
}
