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
		private ArrayList listaServicios;
		
		private int cantidadServiciosDisponibles ;
		
		// Constructores
		
		public SalonEventos(string nombre)
		{
			this.nombre = nombre;
			listaEventosContratados = new ArrayList();
			listaEmpleados = new ArrayList();
			listaEncargados = new ArrayList();
			listaServicios = new ArrayList();
			
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
		public ArrayList ListaEmpleados
		{
			get {return listaEmpleados;}
		}
		public ArrayList ListaEncargados
		{
			get{return listaEncargados;}
		}
		
		// Metodos.
		
		// ---> Servicios.
		
		public void AgregarServicio(Servicios servicio)
		{
			listaServicios.Add(servicio);
			Console.WriteLine("Servicio cargado correctamente");
		}
		
		public void EliminarServicio(string codigo)
		{
			bool estado = false;
			foreach(Servicios serviciosCargados in listaServicios)
			{
				if(serviciosCargados.Codigo == codigo)
				{
					estado = true;
					listaServicios.Remove(serviciosCargados);
					break;
				}	
			}
			if(estado)
				{	
					Console.WriteLine("Servicio eliminado correctamente");
				}
			else
				{
					Console.WriteLine("No se ha encontrado el servicio");
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
			bool estado = false;
			foreach(Empleado empleadosCargados in listaEmpleados)
			{
				if(empleadosCargados.Legajo == legajo)
				{
					estado = true;
					listaEmpleados.Remove(empleadosCargados);
					break;
				}
			}
			if(estado)
			{
				Console.WriteLine("Empleado eliminado correctamente");
			}
			else
			{
				Console.WriteLine("No se ha encontrado al empleado");
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
			bool estado = false;
			foreach(Encargado encargadosGuardados in listaEncargados)
			{
				if(encargadosGuardados.Legajo == legajo)
				{
					estado = true;
					listaEncargados.Remove(encargadosGuardados);
					break;
				}
				
			}
			if(estado)
			{
				Console.WriteLine("Encargado eliminado correctamente");
			}
			else
			{
				Console.WriteLine("No se ha encontrado al encargado");
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
