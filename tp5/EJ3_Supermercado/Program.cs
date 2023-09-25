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
	class Program
	{
		public static void Main(string[] args)
		{
			string codigo, nombre, marca, nombreProveedor;
			int stock, precio;
			char opcion;
			
			Supermercado SolDeOro = new Supermercado("Sol De Oro");
			
			Console.WriteLine("¿Desea cargar productos? s/n");
			opcion = char.Parse(Console.ReadLine());
			while(opcion == 's')
			{
				Console.WriteLine("Codigo del producto: ");
				codigo = Console.ReadLine();
				Console.WriteLine("Nombre del producto: ");
				nombre = Console.ReadLine();
				Console.WriteLine("Marca del producto: ");
				marca = Console.ReadLine();
				Console.WriteLine("Nombre del proveedor: ");
				nombreProveedor = Console.ReadLine();
				Console.WriteLine("Stock total del producto: ");
				stock = int.Parse(Console.ReadLine());
				Console.WriteLine("Precio del producto: ");
				precio = int.Parse(Console.ReadLine());
				
				Producto nuevoProducto = new Producto(codigo, nombre, marca, nombreProveedor, stock, precio);
				SolDeOro.AgregarProductos(nuevoProducto);
				
				Console.WriteLine("¿Desea otro productos? s/n");
				opcion = char.Parse(Console.ReadLine());
			}
			
			SolDeOro.AtenderCliente("111",2);
			SolDeOro.AtenderCliente("111",2);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}