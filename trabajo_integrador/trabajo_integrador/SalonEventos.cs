/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 02/10/2023
 * Hora: 11:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace trabajo_integrador
{
	
	public class SalonEventos
	{
		// Datos Miembro
		
		private string nombre;
		private ArrayList listaEventosContratados;
		private ArrayList listaEmpleados;
		private ArrayList listaEncargados;
		private Servicios[] listaServicios;
		
		private int cantidadServiciosDisponibles ;
		
		// Constructores
		
		public SalonEventos(string nombre)
		{
			this.nombre = nombre;
			listaEventosContratados = new ArrayList();
			listaEmpleados = new ArrayList();
			listaEncargados = new ArrayList();
			listaServicios = new Servicios[10];
			
			cantidadServiciosDisponibles = 0;
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		
		public int CantidadServiciosDisponibles
		{
			set {cantidadServiciosDisponibles = value;}
			get {return cantidadServiciosDisponibles;}
		}
		
		// Metodos.
		
		// ---> Servicios.
		
		public void AgregarServicio(Servicios servicio)
		{
			int posicion = cantidadServiciosDisponibles;
			listaServicios[posicion] = servicio;
			CantidadServiciosDisponibles = CantidadServiciosDisponibles+1;
			Console.WriteLine("Servicio cargado correctamente");
		}
		
		public void EliminarServicio(string codigo)
		{
			foreach(Servicios serviciosCargados in listaServicios)
			{
				if(serviciosCargados.Codigo == codigo)
				{
					int posicion = Array.IndexOf(listaServicios, serviciosCargados);
					for (int x = posicion; x<cantidadServiciosDisponibles; x++)
					{
						listaServicios[x] = listaServicios[x+1];
					}
					listaServicios[cantidadServiciosDisponibles] = null;
					CantidadServiciosDisponibles = CantidadServiciosDisponibles-1;
					Console.WriteLine("Servicio eliminado correctamente");
					break;
				}
				else
				{
					Console.WriteLine("No se ha encontrado el servicio");
					break;
				}
			}
		}
		
		// ---> Empleados
		
		public void AgregarEmpleado(Empleado empleado)
		{
			listaEmpleados.Add(empleado);
			Console.WriteLine("Empleado cargado correctamente.");
		}
		
		public void EliminarEmpleado(string legajo)
		{
			foreach(Empleado empleadosCargados in listaEmpleados)
			{
				if (empleadosCargados.Legajo == legajo)
				{
					listaEmpleados.Remove(empleadosCargados);
					Console.WriteLine("Empleado eliminado correctamente");
					break;
				}
				else
				{
					Console.WriteLine("No se ha encontrado al empleado.");
				}
			}

		}
		
		// ---> Encargados.
		
		public void AgregarEncargado(Encargado encargado)
		{
			listaEncargados.Add(encargado);
			Console.WriteLine("Nuevo encargado guardado correctamente");
		}
		
		public void EliminarEncargado(string legajo)
		{
			foreach(Encargado encargadosGuardados in listaEncargados)
			{
				if(encargadosGuardados.Legajo == legajo)
				{
					listaEncargados.Remove(encargadosGuardados);
					Console.WriteLine("Encargado borrado correctamente.");
				}
				else
				{
					Console.WriteLine("No se ha encontrado al encargado.");
				}
			}
		}
		
		// ---> Contratar Evento.
		
		public void ContratarEvento(Eventos evento)
		{
			listaEventosContratados.Add(evento);
			Console.WriteLine("Evento contratado exitosamente");
		}
		
	}
}
