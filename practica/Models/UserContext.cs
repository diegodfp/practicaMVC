using Microsoft.EntityFrameworkCore;

namespace practica.Models
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Name).IsRequired().HasMaxLength(200);
                entity.Property(u => u.Email).IsRequired();
                entity.Property(u => u.Password).IsRequired();

                // Configuración de la relación
                entity.HasOne(u => u.Department)
                      .WithMany(d => d.Users)
                      .HasForeignKey(u => u.DepartmentId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}
