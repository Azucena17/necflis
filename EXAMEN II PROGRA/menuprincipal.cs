using System;


namespace EXAMEN_II_PROGRA
{
	public class Menu
	{
		ListaCliente listaCliente = new ListaCliente();
		ListaPelicula listaPelicula = new ListaPelicula();
		public string op;
		
		public bool mostrarmenuprincipal()
		{
			bool salir = false;
			
			Console.Clear();
			Console.WriteLine("Bienvenidos a *NECFLIS*");
			Console.WriteLine("1. Clientes");
			Console.WriteLine("2. Películas");
			Console.WriteLine("3. Salir");
			Console.Write(" ");
			op = Console.ReadLine();
			
			switch(op)
			{
				case "1":
					mostrarmenucliente();
					break;
				case "2":
					mostrarmenupelicula();
					break;
				case "3":
					salir = true;
					break;
			}
			Console.Clear();
			return salir;
		}
		
		public void mostrarmenucliente()
		{	
			while(true)
			{	Console.Clear();
				Console.WriteLine("Bienvenido");
				Console.WriteLine("1. Lista de clientes");
				Console.WriteLine("2. Crear nuevo cliente");
				Console.WriteLine("3. Seleccionar el cliente");
				Console.WriteLine("4. Atras");
				Console.Write(" ");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1":
						listaCliente.vercliente();
						Console.ReadKey();
						break;
					case "2":
						Cliente cliente = new Cliente();
						cliente.clientenuevo();
						listaCliente.agregarclientenuevo(cliente);
						break;
					case "3":
						if(listaCliente.contarcliente() > 0)
						{
							mostrarmenuplayList(listaCliente.seleccionarcliente());
						}
						break;
					case "4":
						Console.Clear();
						return;
				}
			}
		}
		
		public void mostrarmenupelicula()
		{
			while(true)
			{	Console.Clear();
				Console.WriteLine("Bienvenido");
				Console.WriteLine("Clientes");
				Console.WriteLine("1. Ver listado de peliculas");
				Console.WriteLine("2. Crear nueva pelicula");
				Console.WriteLine("3. Atras");
				Console.Write(" ");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1":
						listaPelicula.verpelicula();
						Console.ReadKey();
						break;
					case "2":
						Pelicula pelicula = new Pelicula();
						pelicula.peliculanueva();
						listaPelicula.agregarpeliculanueva(pelicula);
						break;
					case "3":
						return;
				}
			}
		}
		
		public void mostrarmenuplayList(Cliente cliente)
		{
			while(true)
			{	Console.Clear();
				Console.WriteLine("Bienvenido");
				Console.WriteLine($" Nombre: {cliente.nombre}");
				Console.WriteLine($" Direccion: {cliente.direccion}");
				Console.WriteLine($" Edad: {cliente.edad}");

				Console.WriteLine("1. PlayList");
				Console.WriteLine("2. Agregar Película Nueva");
				Console.WriteLine("3. Atras");
				Console.Write(" ");
				op = Console.ReadLine();
				
				switch(op)
				{
					case "1":
						cliente.playList.verplaylist();
						Console.ReadKey();
						break;
					case "2":
						if(listaPelicula.contarpelicula() > 0)
						{
							try
							{
								cliente.playList.agregarpeliculanueva(listaPelicula.seleccionarpelicula());
							}
							catch{}
						}
						else
						{
							Console.WriteLine("La Lista Esta Vacia");
						}
						break;
					case "3":
						return;
				}
			}
		}
	}
}