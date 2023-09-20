/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 17/09/2023
 * Hora: 03:46 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace composicion_objetos
{
	/// <summary>
	/// Description of Dueño.
	/// </summary>
	public class Dueño
	{
		private string nombre;
		private string apellido;
		private Mascota suMascota;
		
		public Dueño(string nombre, string apellido)
		{
			this.nombre = nombre;
			this.apellido = apellido;
		}
		
		public Dueño(string nombre, string apellido, Mascota mas)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			suMascota = mas;
		}
		
		public string Nombre
		{
			set
			{
				nombre = value;
			}
			get
			{
				return nombre;
			}
		}
		public string Apellido
		{
			set
			{
				apellido = value;
			}
			get 
			{
				return apellido;
			}
		}
		public Mascota SuMascota
		{
			set
			{
				suMascota = value;
			}
			get
			{
				return suMascota;
			}
		}
		
		public void printData()
		{
			Console.WriteLine("Nombre: {0}, Apellido: {1}, Mascota: {2}",nombre,apellido,suMascota);
		}
		
	}
}








