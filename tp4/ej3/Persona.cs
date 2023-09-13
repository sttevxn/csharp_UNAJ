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
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		// 1)
		
		private string nombre;
		private int edad;
		private string dni;
		private int fechaNacimiento;
		
		// 2)
		
		public Persona(string nombre, int edad, string dni)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
		
		public Persona(string nombre, int fechaNacimiento, string dni)
		{
			this.nombre = nombre;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
		}
		
		// 4)
		
		public void printData()
		{
			Console.WriteLine("{0} ({1}). {2}",nombre,edad,dni);
		}
		
		public void printData()
		{
			int añoActual = 2023, edadActual;
			edadActual = añoActual - fechaNacimiento;
			Console.WriteLine("{0} ({1}). {2}",nombre,edadActual,dni);
			
		}
	}
}
