using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace practica.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Name' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Name' no puede exceder los 100 caracteres.")]
        public string Name { get; set; }

        // Inicializar la colección
        public Collection<Users> Users { get; set; } = new Collection<Users>();
    }
}
