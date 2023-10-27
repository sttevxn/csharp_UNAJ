/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 05:59 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	/// <summary>
	/// Description of Servicios.
	/// </summary>
	public class Servicios
	{	// Datos Miembro.
		
		private string codigo;
		private string tipo;
		private string descripcion;
		private int cantidad;
		private int costoUnitario;
		private int costoTotal;
		
		// Constructores.
		
		// Constructor con cantidad solicitada
		public Servicios(string codigo, string tipo, string descripcion, int cantidad, int costoUnitario)
		{
			this.codigo = codigo;
			this.tipo = tipo;
			this.descripcion = descripcion;
			this.cantidad = cantidad;
			this.costoUnitario = costoUnitario;
		}
	
		// Propiedades.
		
		public string Codigo
		{
			set {codigo = value;}
			get {return codigo;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		public string Descripcion
		{
			set {descripcion = value;}
			get {return descripcion;}
		}
		public int Cantidad
		{
			set {cantidad = value;}
			get {return cantidad;}
		}
		public int CostoUnitario
		{
			set {costoUnitario = value;}
			get {return costoUnitario;}
		}
		public int CostoTotal
		{
			set {costoTotal = value;}
			get {return costoTotal;}
		}
		
		// Metodos.
		
		public void CalcularCostoTotal()
		{
			CostoTotal = CostoTotal + (Cantidad*CostoUnitario);
		}
		
	}
}
