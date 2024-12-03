using Microsoft.EntityFrameworkCore;
using practica.Models;

public class DepartmentContext : DbContext
{
    public DbSet<Department> Departments { get; set; }

    public DepartmentContext(DbContextOptions<DepartmentContext> options)
        : base(options)
    {
    }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department", "dbo");
            entity.HasKey(d => d.Id);
            entity.Property(d => d.Name).IsRequired().HasMaxLength(100);

            entity.HasMany(d => d.Users)
                .WithOne(u => u.Department)
                .HasForeignKey(l => l.DepartmentId);
        });
    }
}
