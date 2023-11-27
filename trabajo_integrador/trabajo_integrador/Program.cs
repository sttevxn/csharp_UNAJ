
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
					try
					{
						opcion = int.Parse(Console.ReadLine());
					}
					catch(FormatException)
					{
						Console.WriteLine("Debe ingresar un numero");
						continue;
					}
					
					while(opcion!=0) 
					{
						if(opcion == 1)
						{
							Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar s o n");
								continue;
							}
							while(decision== 's')
							{
								Console.WriteLine("Nombre: ");
								string nombre = Console.ReadLine();
								Console.WriteLine("DNI: ");
								string dni = Console.ReadLine();
								Console.WriteLine("Legajo: ");
								string legajo = Console.ReadLine();
								Console.WriteLine("Sueldo: ");
								int sueldo;
								try
								{
									sueldo = int.Parse(Console.ReadLine());
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar un valor numerico");
									continue;
								}
								
								
								// se pregunta al usuario si el empleado a cargar sera un Encargado.
								
								
								Console.WriteLine("El nuevo empleado es un ENCARGADO? s/n:");
								char dec;
								try
								{
									dec = char.Parse(Console.ReadLine());
									if(dec != 's' && dec != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
								
								if(dec == 's')
								{
									bool esEncargado = true;
									Console.WriteLine("Ingrese el plus de sueldo: ");
									int plusSueldo;
									try
									{
										plusSueldo = int.Parse(Console.ReadLine());
									}
									catch(FormatException)
							 	 	{
										Console.WriteLine("Debe ingresar un valor numerico");
										continue;
									}
									
									Encargado nuevoEncargado = new Encargado(nombre,dni,legajo,sueldo,esEncargado,plusSueldo);
									nuevoEncargado.AgregarPlus(nuevoEncargado);
									ss.AgregarEmpleado(nuevoEncargado);
									
								}
								else
								{
									Console.WriteLine("Puesto: ");
									string puesto = Console.ReadLine();
									Empleado nuevoEmpleado = new Empleado(nombre,dni,puesto,legajo,sueldo);
									ss.AgregarEmpleado(nuevoEmpleado);
								}
								Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar s o n");
									continue;
								}
								
							}
							MenuAdministracion();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
							
						}
						else if (opcion == 2)
						{
							Console.WriteLine("¿Desea dar de baja un empleado? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar un valor numerico";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							
							while (decision == 's')
							{
								Console.WriteLine("Ingrese el legajo del empleado a dar de baja:");
								string legajo = Console.ReadLine();
								ss.EliminarEmpleado(legajo);
								Console.WriteLine("¿Desea dar de baja a otro empleado? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else
						{
							Console.WriteLine("No valido");
							try
							{
								MenuAdministracion();
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
					}
				}
				
				if(opcion==2)
				{
					MenuEventos();
					char decision;
					try
					{
						opcion = int.Parse(Console.ReadLine());
					}
					catch(FormatException)
					{
						Console.WriteLine("Debe ingresar un numero");
						continue;
					}
					while(opcion!=0)
					{
						if(opcion==1)
						{
							Console.WriteLine("¿Se contratará un evento? s/n");
							try
							{
								decision=char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							
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
								int año, mes, dia;
								try 
								{
									año= int.Parse(partes[0]);
									mes = int.Parse(partes[1]);
									dia = int.Parse(partes[2]);
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar valores numericos");
									continue;
								}
								
								Console.WriteLine("Horario del evento HH:MM");
								string horario = Console.ReadLine();
								string[] partesHorario = horario.Split(new char []{':'});
								int hora,minutos;
								try
								{
									hora = int.Parse(partesHorario[0]);
									minutos = int.Parse(partesHorario[1]);
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar valores numericos");
									continue;
								}
								
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
								try
								{
									decisionServicios = char.Parse(Console.ReadLine());
									if (decisionServicios != 's' && decisionServicios !='n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
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
									try
							 	 	{
							 			decisionServicios = char.Parse(Console.ReadLine());
										if (decisionServicios != 's' && decisionServicios !='n')
										{
											string motivo = "Debe ingresar s o n";
											throw new DecisionExcepcion(motivo);
										}
									}
									catch(DecisionExcepcion e)
									{
										Console.WriteLine(e.motivo);
										continue;
									}
								}
						
								
								ss.ContratarEvento(eventoContratado);
								eventoContratado.CalcularPrecioFinalEvento();
								
								
								Console.WriteLine("¿Se contratará otro evento? s/n");
								try
								{
									decision=char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							MenuEventos();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion==2)
						{
							Console.WriteLine("¿Desea cancelar un evento? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								DateTime fechaActual = DateTime.Now;
								Console.WriteLine("Lista de eventos contratados:");
								foreach(Eventos eventosContratados in ss.ListaEventosContratados )
								{
									Console.WriteLine("Dni: {0}		Fecha: {1}		Encargado: {2}",eventosContratados.DniCliente,eventosContratados.FechayHora,eventosContratados.Encargado.Legajo);
								}
								
								Console.WriteLine("Ingrese el codigo (DNI ) del evento a cancelar: ");
								string dniClienteCancelar = Console.ReadLine();
								ss.CancelarEvento(dniClienteCancelar,fechaActual);
								
								Console.WriteLine("¿Desea cancelar otro evento? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							MenuEventos();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion == 3)
						{
							Console.WriteLine("¿Agregar servicios a un evento? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("EVENTOS CONTRATADOS");
								foreach(Eventos eventosContratados in ss.ListaEventosContratados )
								{
									Console.WriteLine("Dni Cliente: {0}",eventosContratados.DniCliente);
									Console.WriteLine("Servicios contratados:");
									foreach(Servicios serv in eventosContratados.ServiciosContratados)
									{
										Console.WriteLine("Codigo de servicio: {0}",serv.Codigo);
										Console.WriteLine("Tipo de servicio: {0}",serv.Tipo);
										Console.WriteLine("Costo total del servicio: ${0}",serv.CostoTotal);
									}
								}
								Console.WriteLine("Ingrese el DNI-CLIENTE: ");
								string dniCliente = Console.ReadLine();
								Eventos eventoSeleccionado = null;
								
								foreach(Eventos eventosDisponibles in ss.ListaEventosContratados)
								{
									if(eventosDisponibles.DniCliente == dniCliente)
									{
										eventoSeleccionado = eventosDisponibles;
									}
								}
								Console.WriteLine("Complete los siguientes campos para agregar un nuevo servicio: ");
								Console.WriteLine("Codigo:");
								string codigo = Console.ReadLine();
								Console.WriteLine("Tipo:");
								string tipo = Console.ReadLine();
								Console.WriteLine("Descripcion:");
								string descripcion = Console.ReadLine();
								Console.WriteLine("Cantidad");
								int cantidad;
								try
								{
									cantidad= int.Parse(Console.ReadLine());
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar un valor numerico");
									continue;
								}
								Console.WriteLine("Costo Unitario");
								int costoUnitario; 
								try
								{
									costoUnitario = int.Parse(Console.ReadLine());
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar un valor numerico");
									continue;
								}
								Servicios serviciosContratados = new Servicios(codigo,tipo,descripcion,cantidad,costoUnitario);
								serviciosContratados.CalcularCostoTotal();
								eventoSeleccionado.AgregarServicio(serviciosContratados);
								eventoSeleccionado.CalcularPrecioFinalEvento();
								Console.WriteLine("¿Agregar servicios a un evento? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							MenuEventos();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion == 4)
						{
							Console.WriteLine("¿Eliminar servicios de un evento? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("EVENTOS CONTRATADOS");
								foreach(Eventos eventosContratados in ss.ListaEventosContratados )
								{
									Console.WriteLine("Dni Cliente: {0}",eventosContratados.DniCliente);
									Console.WriteLine("Servicios contratados:");
									foreach(Servicios serv in eventosContratados.ServiciosContratados)
									{
										Console.WriteLine("Codigo de servicio: {0}",serv.Codigo);
										Console.WriteLine("Tipo de servicio: {0}",serv.Tipo);
										Console.WriteLine("Costo total del servicio: ${0}",serv.CostoTotal);
									}
								}
								Console.WriteLine("Ingrese el DNI-cliente");
								string dniCliente = Console.ReadLine();
								Eventos eventoSeleccionado = null;
								foreach(Eventos eventosDisponibles in ss.ListaEventosContratados)
								{
									if(eventosDisponibles.DniCliente == dniCliente)
									{
										eventoSeleccionado = eventosDisponibles;
									}
								}
								Console.WriteLine("Ingrese el codigo del servicio a eliminar: ");
								string codigoServicioaEliminar = Console.ReadLine();
								eventoSeleccionado.EliminarServicio(codigoServicioaEliminar);
								eventoSeleccionado.CalcularPrecioFinalEvento();
								Console.WriteLine("¿Eliminar servicios de un evento? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							MenuEventos();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
					}
				}
				else if(opcion == 3)
				{
					Submenu();
					char decision;
					try
					{
						opcion = int.Parse(Console.ReadLine());
					}
					catch(FormatException)
					{
						Console.WriteLine("Debe ingresar un numero");
						continue;
					}
					while(opcion != 0)
					{
						if(opcion == 1)
						{
							Console.WriteLine("¿Desea ver los eventos contratados? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("-------------------------------------------------------------------------");
								Console.WriteLine("Listado de eventos");
								foreach(Eventos eventosContratados in ss.ListaEventosContratados)
								{
									Console.WriteLine("Nombre cliente: {0}",eventosContratados.NombreCliente);
									Console.WriteLine("DNI cliente: {0}",eventosContratados.DniCliente);
									Console.WriteLine("Tipo de evento: {0}",eventosContratados.Tipo);
									Console.WriteLine("Nombre y legajo del Encargado del evento: {0}, {1}",eventosContratados.Encargado.Nombre,eventosContratados.Encargado.Legajo);
									Console.WriteLine("Fecha del evento: {0}",eventosContratados.FechayHora);
									Console.WriteLine("Precio total del evento: {0}",eventosContratados.PrecioFinalEvento);
									Console.WriteLine("-------------------------------------------------------------------------");
									Console.WriteLine("Servicios contratados:");
									Console.WriteLine("-------------------------------------------------------------------------");
									foreach(Servicios serviciosContratados in eventosContratados.ServiciosContratados)
									{
										Console.WriteLine("Codigo: {0}",serviciosContratados.Codigo);
										Console.WriteLine("Tipo: {0}",serviciosContratados.Tipo);
										Console.WriteLine("Descripcion: {0}",serviciosContratados.Descripcion);
										Console.WriteLine("Cantidad: {0}",serviciosContratados.Cantidad);
										Console.WriteLine("Costo unitario: {0}",serviciosContratados.CostoUnitario);
										Console.WriteLine("Costo final: {0}",serviciosContratados.CostoTotal);
									}
									Console.WriteLine("-------------------------------------------------------------------------");
								}
								Console.WriteLine("¿Ver listado de eventos contratados? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							Submenu();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion==2)
						{
							Console.WriteLine("¿Ver listado de clientes?");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("LISTA DE CLIENTES:");
								foreach(Eventos eventosContratados in ss.ListaEventosContratados)
								{
									Console.WriteLine("Nombre: {0}. DNI: {1}",eventosContratados.NombreCliente,eventosContratados.DniCliente);
								}
								Console.WriteLine("¿Ver listado de clientes?");	
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							Submenu();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion == 3)
						{
							Console.WriteLine("¿Ver listado de empleados?");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("LISTA DE EMPLEADOS ACTIVOS");
								foreach(Empleado empleadosActivos in ss.ListaEmpleados)
								{
									Console.WriteLine("Nombre: {0}",empleadosActivos.Nombre);
									Console.WriteLine("DNI: {0}",empleadosActivos.Dni);
									Console.WriteLine("Sueldo: {0}",empleadosActivos.Sueldo);
								}
								Console.WriteLine("¿Ver listado de empleados?");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							Submenu();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
						else if(opcion == 4)
						{
							Console.WriteLine("¿Ver eventos de un mes determinado? s/n");
							try
							{
								decision = char.Parse(Console.ReadLine());
								if(decision != 's' && decision != 'n')
								{
									string motivo = "Debe ingresar s o n";
									throw new DecisionExcepcion(motivo);
								}
							}
							catch(DecisionExcepcion e)
							{
								Console.WriteLine(e.motivo);
								continue;
							}
							while(decision == 's')
							{
								Console.WriteLine("Ingrese un mes (del 1 al 12)");
								int mesDeterminado=0;
								try
								{
									mesDeterminado = int.Parse(Console.ReadLine());
								}
								catch(FormatException)
								{
									Console.WriteLine("Debe ingresar un valor numerico");
								}
								if(mesDeterminado>0 && mesDeterminado<13)
								{
									foreach(Eventos eventosContratados in ss.ListaEventosContratados)
									{
										if(eventosContratados.FechayHora.Month == mesDeterminado)
										{
											Console.WriteLine("Nombre cliente: {0}",eventosContratados.NombreCliente);
											Console.WriteLine("DNI cliente: {0}",eventosContratados.DniCliente);
											Console.WriteLine("Tipo de evento: {0}",eventosContratados.Tipo);
											Console.WriteLine("Nombre y legajo del Encargado del evento: {0}, {1}",eventosContratados.Encargado.Nombre,eventosContratados.Encargado.Legajo);
											Console.WriteLine("Fecha del evento: {0}",eventosContratados.FechayHora);
											Console.WriteLine("Precio total del evento: {0}",eventosContratados.PrecioFinalEvento);
										}
									}
								}
								else
								{
									Console.WriteLine("Mes no valido");
								}
								Console.WriteLine("¿Ver eventos de un mes determinado? s/n");
								try
								{
									decision = char.Parse(Console.ReadLine());
									if(decision != 's' && decision != 'n')
									{
										string motivo = "Debe ingresar s o n";
										throw new DecisionExcepcion(motivo);
									}
								}
								catch(DecisionExcepcion e)
								{
									Console.WriteLine(e.motivo);
									continue;
								}
							}
							Submenu();
							try
							{
								opcion = int.Parse(Console.ReadLine());
							}
							catch(FormatException)
							{
								Console.WriteLine("Debe ingresar un numero");
								continue;
							}
						}
					}
				}
				
				
			MenuPrincipal();
			opcion = int.Parse(Console.ReadLine());	
			}
			
		
			
			
			//foreach(Empleado e in ss.ListaEmpleados )
			
			
			
			
			
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
			Console.WriteLine("3- Submenu");
			Console.WriteLine("0- Salir");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
			
		}
		
		public static void MenuAdministracion()
		{
			Console.WriteLine("1- Dar de alta empleado");
			Console.WriteLine("2- Dar de baja empleado");
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
		public static void Submenu()
		{
			Console.WriteLine("1- Listado de eventos");
			Console.WriteLine("2- Listado de clientes");
			Console.WriteLine("3- Listado de empleados");
			Console.WriteLine("4- Eventos de un mes determinado");
		}
	}
}