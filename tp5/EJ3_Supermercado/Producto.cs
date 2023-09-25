/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 24/09/2023
 * Hora: 03:04 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace EJ3_Supermercado
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		// Datos Miembro
		
		private string codigo;
		private string nombre;
		private string marca;
		private string nombreProveedor;
		private int stock;
		private int precio;
		
		// Constructor
		
		public Producto(string codigo, string nombre, string marca, string nombreProveedor, int stock, int precio)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.marca = marca;
			this.nombreProveedor = nombreProveedor;
			this.stock = stock;
			this.precio = precio;
		}
		
		// Constructores
		
		public string Codigo
		{
			set {codigo = value;}
			get {return codigo;}
		}
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Marca 
		{
			set {marca = value;}
			get {return marca;}
		}
		public string NombreProveedor
		{
			set {nombreProveedor = value;}
			get {return nombreProveedor;}
		}
		public int Stock
		{
			set {stock = value;}
			get {return stock;}
		}
		public int Precio
		{
			set {precio = value;}
			get {return precio;}
		}
			
	}
}
