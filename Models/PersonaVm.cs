using System.ComponentModel.DataAnnotations;

namespace TallerBlazor.Models
{
	public class PersonaVm
	{
		[Required(ErrorMessage = "No puede estar en Blanco.")]
		[RegularExpression(@"[0-9]{8}[-]{1}[0-9Kk]{1}",ErrorMessage ="Debe ingresar formato del Rut.")]
		public string? Rut{ get; set; }

		[Required(ErrorMessage = "No puede estar en Blanco.")]
		[MaxLength(60, ErrorMessage ="Debe ingresar máximo 60 caracteres.")]
		public string? Nombre { get; set; }

		[Required(ErrorMessage = "No puede estar en Blanco.")]
		public DateTime FechaNac{ get; set; }

		[Required(ErrorMessage = "No puede estar en Blanco.")]
		[MaxLength(10, ErrorMessage = "Debe ingresar máximo 10 caracteres.")]
		public string? User { get; set; }

		[Required(ErrorMessage = "No puede estar en Blanco.")]
		[MaxLength(10, ErrorMessage = "Debe ingresar máximo 10 caracteres.")]
		[RegularExpression(@"[A-Z]{1}[A-Za-z0-9]{9}", ErrorMessage = "Debe ingresar la primera letra mayúsculo.")]
		public string? Password { get; set; }


	}
}
