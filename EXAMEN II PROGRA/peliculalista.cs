using System;
using System.Collections.Generic;

namespace EXAMEN_II_PROGRA
{
	public class ListaPelicula
	{
	
		List<Pelicula> listaPelicula = new List<Pelicula>();
		
		public void agregarpeliculanueva(Pelicula pelicula)
		{
			pelicula.indiceListaPelicula = Convert.ToString(listaPelicula.Count + 1);
			listaPelicula.Add(pelicula);
			
			verpelicula();
			Console.WriteLine("La pelicula fue agregada");	
			Console.ReadKey();
		}
		
		public void verpelicula()
		{
			Console.Clear();
			Console.WriteLine("Lista de Peliculas");

			
			foreach(var pelicula in listaPelicula)
			{
				Console.WriteLine($"  {pelicula.indiceListaPelicula}. {pelicula.nombre}");
			}
		}
		
		public int contarpelicula()
		{
			return listaPelicula.Count;
		}
		
		public Pelicula seleccionarpelicula()
		{	
			Pelicula pelicula;

			string selPelicula;
			int indice;
			while(true)
			{
				verpelicula();
				Console.WriteLine("Seleccionar una Pelicula");
				Console.WriteLine("Ingresa 0 para regresar");
				selPelicula = Console.ReadLine();
								
				if(int.TryParse(selPelicula, out indice))
				{			
					if(indice >  0 && indice <= listaPelicula.Count)
					{
						pelicula = listaPelicula[Convert.ToInt32(indice) - 1];
						return pelicula;
					}
					else if(indice == 0)
					{
						pelicula = listaPelicula[Convert.ToInt32(indice) + 1];
						return pelicula;
					}
				}					
			}
		}
	}
}