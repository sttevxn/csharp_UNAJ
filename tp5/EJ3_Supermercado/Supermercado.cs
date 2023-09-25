/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 24/09/2023
 * Hora: 05:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace EJ3_Supermercado
{
	/// <summary>
	/// Description of Supermercado.
	/// </summary>
	public class Supermercado
	{
		// Datos Miembro
		
		private string nombre;
		private ArrayList listaProductos;
		
		// Constructor
		
		public Supermercado(string nombre)
		{
			this.nombre = nombre;
			listaProductos = new ArrayList();
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		
		// Metodos Miembro
		
		public void AgregarProductos(Producto productoAAgregar)
		{
			listaProductos.Add(productoAAgregar);
		}
		
		public void AtenderCliente(string codigo, int cantidadUnidadesCompradas)
		{
			int montoFinal;
			
			foreach(Producto productosGuardados in listaProductos)
			{
				if(codigo == productosGuardados.Codigo)
				{
					if(productosGuardados.Stock == 0)
					{
						Console.WriteLine("Producto codigo: {0} sin stock. Proveedor: {1}",productosGuardados.Codigo, productosGuardados.NombreProveedor);
						break;
					}
					else if (cantidadUnidadesCompradas > productosGuardados.Stock)
					{
						Console.WriteLine("La cantidad a vender es mayor al stock. Stock del producto: {0}",productosGuardados.Stock);
						break;
					}
					else
					{
						productosGuardados.Stock = productosGuardados.Stock - cantidadUnidadesCompradas;
						montoFinal = cantidadUnidadesCompradas*productosGuardados.Precio;
						
						Console.WriteLine("TICKET DE COMPRA SUPERMERCADO {0}",Nombre);
						Console.WriteLine("PRODUCTO: {0}. MARCA: {1}",productosGuardados.Nombre, productosGuardados.Marca);
						Console.WriteLine("CANTIDAD: {0}", cantidadUnidadesCompradas);
						Console.WriteLine("MONTO TOTAL: ${0}", montoFinal);
					}
				}	
			}
		}
	}
}

