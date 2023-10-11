/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 02/10/2023
 * Hora: 11:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			
			SalonEventos ss = new SalonEventos("ss");
			
			MenuPrincipal();
			opcion = int.Parse(Console.ReadLine());
			switch(opcion)
			{
				case 1:
					MenuAdministracion();
					char decision;
					opcion = int.Parse(Console.ReadLine());
					while(opcion!=0)
					{
						if(opcion == 1)
						{
							Console.WriteLine("¿Desea agregar un servicio? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision== 's')
							{
								Console.WriteLine("Codigo: ");
								string codigo = Console.ReadLine();
								Console.WriteLine("Tipo: ");
								string tipo = Console.ReadLine();
								Console.WriteLine("Descripcion: ");
								string descripcion = Console.ReadLine();
								Console.WriteLine("Costo Unitario: ");
								int costo = int.Parse(Console.ReadLine());
								Servicios nuevoServicio = new Servicios(codigo,tipo,descripcion,costo);
								ss.AgregarServicio(nuevoServicio);
								
								Console.WriteLine("¿Desea agregar otro servicio? s/n");
								decision=char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
						}
						else if (opcion == 2)
						{
							Console.WriteLine("Desea eliminar un servicio? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision == 's')
							{
								Console.WriteLine("Ingrese el codigo del servicio a eliminar:");
								string codigo = Console.ReadLine();
								ss.EliminarServicio(codigo);
								
								Console.WriteLine("Desea eliminar otro servicio?");
								decision = char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
							
						}
						else if (opcion == 3)
						{
							Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision== 's')
							{
								Console.WriteLine("Nombre: ");
								string nombre = Console.ReadLine();
								Console.WriteLine("DNI: ");
								string dni = Console.ReadLine();
								Console.WriteLine("Legajo: ");
								string legajo = Console.ReadLine();
								Console.WriteLine("Sueldo: ");
								int sueldo = int.Parse(Console.ReadLine());
								
								// se pregumta al usuario si el empleado a cargar sera un Encargado.
								
								
								Console.WriteLine("El nuevo empleado es un ENCARGADO? s/n:");
								char dec = char.Parse(Console.ReadLine());
								if(dec == 's')
								{
									Console.WriteLine("Ingrese el plus de sueldo: ");
									int plusSueldo = int.Parse(Console.ReadLine());
									Encargado nuevoEncargado = new Encargado(nombre,dni,legajo,sueldo,plusSueldo);
									nuevoEncargado.AgregarPlus(nuevoEncargado);
									ss.AgregarEncargado(nuevoEncargado);
									
								}
								else
								{
									Console.WriteLine("Puesto: ");
									string puesto = Console.ReadLine();
									Empleado nuevoEmpleado = new Empleado(nombre,dni,puesto,legajo,sueldo);
									ss.AgregarEmpleado(nuevoEmpleado);
								}
								Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
								decision = char.Parse(Console.ReadLine());	
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
							
						}
						else if (opcion == 4)
						{
							Console.WriteLine("¿Desea dar de baja un empleado? s/n");
							decision = char.Parse(Console.ReadLine());
							while (decision == 's')
							{
								Console.WriteLine("Ingrese el legajo del empleado a dar de baja:");
								string legajo = Console.ReadLine();
								ss.EliminarEmpleado(legajo);
								Console.WriteLine("¿Desea dar de baja a otro empleado? s/n");
								decision = char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
								
						}
						else if (opcion == 5)
						{
							Console.WriteLine("¿Desea dar de baja a un encargado? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision == 's')
							{
								Console.WriteLine("Ingrese el legajo del encargado a dar de baja:");
								string legajo = (Console.ReadLine());
								ss.EliminarEncargado(legajo);
								Console.WriteLine("'¿Desea dar de baja a otro encargado? s/n");
								decision = char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
						}
					}
					break;
					
				case 2:
					{
						Console.WriteLine("Ingrese los datos necesarios para contratar un evento");
						Console.WriteLine("Nombre del cliente");
						string nombreCliente = Console.ReadLine();
						Console.WriteLine("DNI del cliente");
						string dniCliente = Console.ReadLine();
						Console.WriteLine("Fecha del evento: DD/MM/AA");
						string fecha = Console.ReadLine();
						Console.WriteLine("Tipo de evento");
						string tipo = Console.ReadLine();
						Console.WriteLine("Precio del evento");
						int precioEvento = int.Parse(Console.ReadLine());
						
						
					}
			}
		
			
			
			foreach(Empleado e in ss.ListaEmpleados )
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		// Funciones.
		
		public static void MenuPrincipal()
		{
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("SALON DE EVENTOS SS");
			Console.WriteLine("MENU PRINCIPAL");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("1- Menu administrativo");
			Console.WriteLine("2- Contratar evento");
			Console.WriteLine("3- Cancelar evento");
			Console.WriteLine("4- Submenu");
			Console.WriteLine("0- Salir");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
			
		}
		
		public static void MenuAdministracion()
		{
			Console.WriteLine("1- Agregar servicio.");
			Console.WriteLine("2- Eliminar servicio.");
			Console.WriteLine("3- Dar de alta empleado");
			Console.WriteLine("4- Dar de baja empleado");
			Console.WriteLine("5- Dar de baja encargado");
			Console.WriteLine("0- Volver");
		}
		
	}
}