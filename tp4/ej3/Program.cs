/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 11/09/2023
 * Hora: 08:28 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ej3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Persona persona,persona1; 
			persona = new Persona("Steven Villalba", 21, "94733360");
			persona.printData();
			
			persona1 = new Persona("Leonel Messi",1987,"10101010" );
			persona1.printData();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}