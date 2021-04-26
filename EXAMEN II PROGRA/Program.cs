using System;
using System.Collections.Generic;

namespace EXAMEN_II_PROGRA
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Menu menu = new Menu();
				bool salir = false;
				
				while(!salir)
				{	
					salir = menu.mostrarmenuprincipal();		
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}
