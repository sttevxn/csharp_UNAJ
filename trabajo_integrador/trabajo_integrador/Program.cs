
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
			while(opcion != 0)
			{
				if (opcion==1)
				{
					MenuAdministracion();
					char decision;
					opcion = int.Parse(Console.ReadLine());
				
					while(opcion!=0)
					{
						if(opcion == 1)
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
								
								// se pregunta al usuario si el empleado a cargar sera un Encargado.
								
								
								Console.WriteLine("El nuevo empleado es un ENCARGADO? s/n:");
								char dec = char.Parse(Console.ReadLine());
								if(dec == 's')
								{
									bool esEncargado = true;
									Console.WriteLine("Ingrese el plus de sueldo: ");
									int plusSueldo = int.Parse(Console.ReadLine());
									Encargado nuevoEncargado = new Encargado(nombre,dni,legajo,sueldo,esEncargado,plusSueldo);
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
						else if (opcion == 2)
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
						else if (opcion == 3)
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
					
				}
				
				if(opcion==2)
				{
					MenuEventos();
					char decision;
					opcion = int.Parse(Console.ReadLine());
					while(opcion!=0)
					{
						if(opcion==1)
						{
							Console.WriteLine("¿Se contratará un evento? s/n");
							decision=char.Parse(Console.ReadLine());
							while(decision == 's')
							{
								Console.WriteLine("Ingrese los datos necesarios para contratar un evento");
								Console.WriteLine("Nombre del cliente");
								string nombreCliente = Console.ReadLine();
								Console.WriteLine("DNI del cliente");
								string dniCliente = Console.ReadLine();
								
								// Fecha y hora del evento.
								
								Console.WriteLine("Fecha del evento (AA-MM-DD)");
								string añoMesDia = Console.ReadLine();
								string []partes = añoMesDia.Split(new char[]{'-'});
								int año = int.Parse(partes[0]);
								int mes = int.Parse(partes[1]);
								int dia = int.Parse(partes[2]);
								
								Console.WriteLine("Horario del evento HH:MM");
								string horario = Console.ReadLine();
								string[] partesHorario = horario.Split(new char []{':'});
								int hora = int.Parse(partesHorario[0]);
								int minutos = int.Parse(partesHorario[1]);
								int segundos = 0;
							
								DateTime fechayHora = new DateTime(año,mes,dia,hora,minutos,segundos);
								
								//Tipo de evento.
								
								Console.WriteLine("Tipo de evento");
								string tipoEvento = Console.ReadLine();
								
								//Mostrar encargados
								
								Console.WriteLine("Lista de encargados");
								foreach(Empleado empleadosDisponibles in ss.ListaEmpleados)
								{
									if(empleadosDisponibles.EsEncargado)
									{
										Console.WriteLine("Nombre: {0}. Legajo: {1}", empleadosDisponibles.Nombre, empleadosDisponibles.Legajo);
									}
										
								}
								Console.WriteLine("Seleccione un encargado(Ingrese legajo)");
								string legajo = Console.ReadLine();
								Encargado encargadoSeleccionado=null;
								foreach(Empleado encargadosDisponibles in ss.ListaEmpleados)
								{
									if(legajo == encargadosDisponibles.Legajo)
									{
										encargadoSeleccionado = (Encargado)encargadosDisponibles;
										break;
									}
								}
								
								Eventos eventoContratado = new Eventos(nombreCliente,dniCliente,fechayHora,tipoEvento,encargadoSeleccionado);
								
								// Agregar servicios.
								
								Console.WriteLine("¿Se agregarán servicios? s/n");
								char decisionServicios;
								decisionServicios = char.Parse(Console.ReadLine());
								while(decisionServicios == 's')
								{
									Console.WriteLine("Codigo:");
									string codigo = Console.ReadLine();
									Console.WriteLine("Tipo:");
									string tipo = Console.ReadLine();
									Console.WriteLine("Descripcion:");
									string descripcion = Console.ReadLine();
									Console.WriteLine("Cantidad");
									int cantidad = int.Parse(Console.ReadLine());
									Console.WriteLine("Costo Unitario");
									int costoUnitario = int.Parse(Console.ReadLine());
									
									Servicios serviciosContratados = new Servicios(codigo,tipo,descripcion,cantidad,costoUnitario);
									serviciosContratados.CalcularCostoTotal();
									eventoContratado.AgregarServicio(serviciosContratados);
									
									Console.WriteLine("¿Se contratará otro servicio? s/n ");
									decisionServicios = char.Parse(Console.ReadLine());
								}
						
								
								ss.ContratarEvento(eventoContratado);
								eventoContratado.CalcularPrecioFinalEvento();
								
								
								Console.WriteLine("¿Se contratará otro evento? s/n");
								decision = char.Parse(Console.ReadLine());
							}
							MenuEventos();
							opcion = int.Parse(Console.ReadLine());
						}
					}
					
						
					
						
				}
				
				
			MenuPrincipal();
			opcion = int.Parse(Console.ReadLine());	
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
			Console.WriteLine("2- Menu Eventos");
			Console.WriteLine("4- Submenu");
			Console.WriteLine("0- Salir");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
			
		}
		
		public static void MenuAdministracion()
		{
			Console.WriteLine("1- Dar de alta empleado");
			Console.WriteLine("2- Dar de baja empleado");
			Console.WriteLine("3- Dar de baja encargado");
			Console.WriteLine("0- Volver");
		}
		public static void MenuEventos()
		{
			Console.WriteLine("1- Contratar un evento.");
			Console.WriteLine("2- Cancelar un evento.");
			Console.WriteLine("3- Agregar un servicio para un evento.");
			Console.WriteLine("4- Eliminar un servicio para un evento.");
			Console.WriteLine("0- Volver");
		}
		
	}
}