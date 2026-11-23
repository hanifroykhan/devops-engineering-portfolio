using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TaskItem>(entity =>
        {
            entity.HasKey(t => t.Id);

            entity.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();

            entity.Property(t => t.Description)
                .IsRequired(false);

            entity.Property(t => t.IsCompleted)
                .HasDefaultValue(false);

            entity.Property(t => t.CreatedAt)
                .HasColumnType("datetime2");
        });
    }
}