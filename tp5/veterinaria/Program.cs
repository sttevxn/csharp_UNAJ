/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 18/09/2023
 * Hora: 03:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using composicion_objetos;

namespace veterinaria
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Veterinaria veterinaria1 = new Veterinaria("Patitas");
			
			Console.WriteLine("¿Desea agregar una nueva mascota? s/n");
			char opcion;
			opcion = char.Parse(Console.ReadLine());
			
			while (opcion == 's')
			{
				string nombreMascota, nombreDueño, especie;
				int edadMascota;
				
				Console.WriteLine("Ingrese los datos correspondientes");
				
				Console.WriteLine("Nombre de la mascota:");
				nombreMascota = Console.ReadLine();
				
				Console.WriteLine("Especie:");
				especie = Console.ReadLine();
				
				Console.WriteLine("Edad de la mascota:");
				edadMascota = int.Parse(Console.ReadLine());
				
				Console.WriteLine("Nombre del dueño:");
				nombreDueño = Console.ReadLine();
				
				Mascota nuevaMascota = new Mascota(nombreMascota,especie,nombreDueño,edadMascota);
				veterinaria1.AgregarMascota(nuevaMascota);
				
				Console.WriteLine("¿Desea agregar una otra mascota? s/n");
				opcion = char.Parse(Console.ReadLine());
				
				
			}
			
			veterinaria1.VerDatos(1);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}