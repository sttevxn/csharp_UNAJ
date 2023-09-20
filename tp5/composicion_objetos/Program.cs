/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 17/09/2023
 * Hora: 03:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace composicion_objetos
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dueño dueño1 = new Dueño("Steven", "Villalba");
			Mascota mascota1 = new Mascota("Pancho", "Perro", "Steven", 12);
			
			dueño1.SuMascota = mascota1;
			
			dueño1.SuMascota.PrintData();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}