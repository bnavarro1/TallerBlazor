using TallerBlazor.Models;

namespace TallerBlazor.Pages
{
	public partial class Sesion02
	{
		private PersonaVm ModelPersona { get; set; } = new();
		private string MiTitulo { get; set; } = "Mantenedor de Usuarios";

		private void ok()
		{

		}


		private void Aceptar()
		{
			Console.WriteLine("OK....");
		}

		private void Cancelar()
		{
			ModelPersona = new();
		}

	}

}
