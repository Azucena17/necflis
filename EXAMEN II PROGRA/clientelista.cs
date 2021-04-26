using System;
using System.Collections.Generic;

namespace EXAMEN_II_PROGRA
{
	public class ListaCliente
	{
	
		List<Cliente> listaCliente = new List<Cliente>();
		
		public void agregarclientenuevo(Cliente cliente)
		{
			PlayList playlist = new PlayList(cliente.nombre);
			
			cliente.indice = Convert.ToString(listaCliente.Count + 1);
			cliente.playList = playlist;
			listaCliente.Add(cliente);
			
			vercliente();
			Console.WriteLine("Nuevo cliente agregado");
			
			Console.ReadKey();
		}
		
		public void vercliente()
		{	
			Console.Clear();
			Console.WriteLine("Lista de Clientes");
		
			if(listaCliente.Count > 0)
			{	
				foreach(var cliente in listaCliente)
				{
					Console.WriteLine($"  {cliente.indice}. {cliente.nombre}");
				}
			}
			else
			{
				Console.WriteLine("Esta lista esta vacia");

			}
			
		}
		
		public int contarcliente()
		{
			return listaCliente.Count;
		}

		public Cliente seleccionarcliente()
		{
			Cliente cliente;
	
			string selCliente;
			int indice;
			
			while(true)
			{
				vercliente();
				Console.WriteLine("Selecciona un cliente");
				selCliente = Console.ReadLine();
							
				if(int.TryParse(selCliente, out indice))
				{			
					if(indice >  0 && indice <= listaCliente.Count)
					{
						cliente = listaCliente[Convert.ToInt32(indice) - 1];
						return cliente;
					}
				}
							
			}
		}
	}
}
