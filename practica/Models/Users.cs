using System.ComponentModel.DataAnnotations;

namespace practica.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Name' es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo 'Email' es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo 'Password' es obligatorio.")]
        [StringLength(100, ErrorMessage = "La contraseña no puede exceder los 100 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un departamento.")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; } // Relación opcional
    }
}
