/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 11/09/2023
 * Hora: 08:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h=new Hora(23,30,15);
			h.imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}