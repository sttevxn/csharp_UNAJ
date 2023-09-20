/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 18/09/2023
 * Hora: 03:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;

namespace composicion_objetos
{
	/// <summary>
	/// Description of Mascota.
	/// </summary>
	public class Mascota
	{
		private string nombre;
		private string especie;
		private string nombreDueño;
		private int edad;
		private string diagnostico;
		
		public Mascota(string nombre, string especie, string nombreDueño, int edad)
		{
			this.nombre = nombre;
			this.especie = especie;
			this.nombreDueño = nombreDueño;
			this.edad = edad;
			
		}
		public Mascota(string nombre, string especie, string nombreDueño, int edad, string diagnostico)
		{
			this.nombre = nombre;
			this.especie = especie;
			this.nombreDueño = nombreDueño;
			this.edad = edad;
			this.diagnostico = diagnostico;
		}
		
		public string Nombre
		{
			set
			{
				nombre = value;
			}
			get
			{
				return  nombre;
			}
		}
		
		public string Especie
		{
			set
			{
				especie = value;
			}
			get
			{
				return especie;
			}
		}
		
		public string NombreDueño
		{
			set
			{
				nombreDueño = value;
			}
			get
			{
				return nombreDueño;
			}
		}
		
		public int Edad
		{
			set 
			{
				edad = value;
			}
			get
			{
				return edad;
			}
		}
		
		public string Diagnostico
		{
			set
			{
				diagnostico = value;
			}
			get 
			{
				return diagnostico;
			}
		}
		
		public void PrintData()
		{
			Console.WriteLine("Especie: {0}. Nombre y Edad: {1} ({2}). Dueño: {3}",especie,nombre,edad,nombreDueño);
		}
	}
}
