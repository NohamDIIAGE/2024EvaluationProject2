using _2024Evaluation.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace _2024Evaluation.DAL
{
    public class DbContextEntity : DbContext
    {
        public DbContextEntity(DbContextOptions<DbContextEntity> options) : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            EventTableInstantiate(modelBuilder);

            SeedDataBase(modelBuilder);
        }

        private void EventTableInstantiate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .IsRequired();

                entity.Property(e => e.Time)
                    .IsRequired();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }

        private static void SeedDataBase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(new Event()
            {
                Id = 1,
                Date = new DateTime(2024, 1, 18, 0, 0, 0, DateTimeKind.Utc),
                Time = TimeSpan.FromHours(5).Add(TimeSpan.FromMinutes(40).Add(TimeSpan.FromSeconds(23))),
                Title = "MyFirstEvent",
                Description = "I'm the Description of the first event",
                Location = "I'm the location of the first event",
            },
            new Event()
            {
                Id = 2,
                Date = new DateTime(2024, 2, 20, 0, 0, 0, DateTimeKind.Utc),
                Time = TimeSpan.FromHours(6).Add(TimeSpan.FromMinutes(30).Add(TimeSpan.FromSeconds(45))),
                Title = "MySecondEvent",
                Description = "I'm the Description of the second event",
                Location = "I'm the location of the second event",
            },
            new Event()
            {
                Id = 3,
                Date = new DateTime(2024, 3, 15, 0, 0, 0, DateTimeKind.Utc),
                Time = TimeSpan.FromHours(7).Add(TimeSpan.FromMinutes(20).Add(TimeSpan.FromSeconds(10))),
                Title = "MyThirdEvent",
                Description = "I'm the Description of the third event",
                Location = "I'm the location of the third event",
            });
        }
    }
}
