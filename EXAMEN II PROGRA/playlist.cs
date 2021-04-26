using System;
using System.Collections.Generic;

namespace EXAMEN_II_PROGRA
{
	public class PlayList
	{
	
		List<Pelicula> playList = new List<Pelicula>();
		public string nombre;
		
		public PlayList(string nombre)
		{
			this.nombre = nombre;
		}
		
		public void agregarpeliculanueva(Pelicula pelicula)
		{
			if(!(playList.Contains(pelicula)))
			{
				pelicula.indicePlayList = Convert.ToString(playList.Count + 1);
				playList.Add(pelicula);
				
				Console.WriteLine("La pelicula fue agregada");
				
			}
			
			Console.ReadKey();
		}
		
		public void verplaylist()
		{
			Console.Clear();
			Console.WriteLine("Playlist");
			
			if(playList.Count > 0)
			{
				foreach(var pelicula in playList)
				{
					Console.WriteLine($"  {pelicula.indicePlayList}. {pelicula.nombre}");
				}
			}
			else
			{
				Console.WriteLine("La Playlist esta vacia");
			}
		}
	}
}