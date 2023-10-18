/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 04:15 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	/// <summary>
	/// Description of Encargado.
	/// </summary>	
	public class Encargado : Empleado
	{
		// Datos Miembro.
		
		private int plusSueldo;
		
		// Constructores.
		
		public Encargado(string nombre, string dni, string puesto, string legajo, int sueldo, int plusSueldo) : base(nombre,dni,puesto,legajo,sueldo)
		{
			this.plusSueldo = plusSueldo;
		}
		public Encargado(string nombre, string dni, string legajo, int sueldo, int plusSueldo) : base(nombre,dni,legajo,sueldo)
		{
			this.plusSueldo = plusSueldo;
		}
		
		// Propiedades.
		
		public int PlusSueldo
		{
			set {plusSueldo = value;}
			get {return plusSueldo;}
		}
		
		// Metodos
		
		public void AgregarPlus(Encargado encargado)
		{
			Sueldo = Sueldo + PlusSueldo;
		}
		
	}
}
