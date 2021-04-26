using System;


namespace EXAMEN_II_PROGRA
{
	public class Pelicula
	{
		public string indiceListaPelicula;
		public string indicePlayList;
		public string nombre;
		public string tipo;
		public string genero;
		public string sinopsis;
		
		
		public void peliculanueva()
		{
			Console.Clear();
			Console.WriteLine("Crear nueva pelicula");
			Console.WriteLine("Ingresar lo siguiente:");
			Console.WriteLine("Nombre:");
			Console.Write(" ");
			this.nombre = Console.ReadLine();
			
			Console.WriteLine("Tipo:");
			Console.Write(" ");
			this.tipo = Console.ReadLine();

			Console.WriteLine("Genero:");
			Console.Write(" ");
			this.genero = Console.ReadLine();
			
			Console.WriteLine("Sinopsis:");
			Console.Write(" ");
			this.sinopsis = Console.ReadLine();
		}
	}
}
