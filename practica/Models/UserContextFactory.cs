using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace practica.Models
{
    public class UserContextFactory : IDesignTimeDbContextFactory<UserContext>
    {
        public UserContext CreateDbContext(string[] args)
        {
            // Crear una nueva instancia de DbContextOptions con la cadena de conexión
            var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=MiBaseDeDatos;Trusted_Connection=True;TrustServerCertificate=True;");

            // Devolver una nueva instancia de DepartmentContext con las opciones configuradas
            return new UserContext(optionsBuilder.Options);
        }
    }
}
