/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 03:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{	
		// Datos Miembro
		
		protected string nombre;
		protected string dni;
		protected string puesto;
		protected string legajo;
		protected int sueldo;
		
		// Constructor
		
		public Empleado(string nombre, string dni, string puesto, string legajo, int sueldo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.puesto = puesto;
			this.legajo = legajo;
			this.sueldo = sueldo;
		}
		
		public Empleado(string nombre, string dni, string legajo, int sueldo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.legajo = legajo;
			this.sueldo = sueldo;
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Dni
		{
			set {dni = value;}
			get {return dni;}
		}
		public string Puesto
		{
			set {puesto = value;}
			get {return puesto;}
		}
		public string Legajo
		{
			set {legajo = value;}
			get {return legajo;}
		}
		public int Sueldo
		{
			set {sueldo = value;}
			get {return sueldo;}
		}
		
		
		
		
		
		
	}
}
