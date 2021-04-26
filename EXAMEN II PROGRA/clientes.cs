using System;
using System.Collections.Generic;


namespace EXAMEN_II_PROGRA
{
	public class Cliente
	{	public string indice;
		public string nombre;
		public string direccion;
		public string edad;
		public PlayList playList;
		
		public void clientenuevo()
		{
			Console.Clear();
			Console.WriteLine("Crear Cliente Nuevo ");
			Console.WriteLine("Ingresar los datos siguientes:");
			Console.WriteLine("Nombre:");
			Console.Write(" ");
			this.nombre = Console.ReadLine();
			
			Console.WriteLine("Dirección:");
			Console.Write(" ");
			this.direccion = Console.ReadLine();

			Console.WriteLine("Edad:");
			Console.Write(" ");
			this.edad = Console.ReadLine();
		}
	}
}

