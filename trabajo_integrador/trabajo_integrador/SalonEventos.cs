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
		

		
		// Constructores
		
		public SalonEventos(string nombre)
		{
			this.nombre = nombre;
			listaEventosContratados = new ArrayList();
			listaEmpleados = new ArrayList();
			
			
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		
		
		public ArrayList ListaEmpleados
		{
			get {return listaEmpleados;}
		}
		
		
		// Metodos.
		
		
		
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
			listaEmpleados.Add(encargado);
			Console.WriteLine("Nuevo encargado guardado correctamente");
		}
		
		public void EliminarEncargado(string legajo)
		{
			bool estado = false;
			foreach(Encargado empleadosGuardados in listaEmpleados)
			{
				if(empleadosGuardados.Legajo == legajo)
				{
					estado = true;
					listaEmpleados.Remove(empleadosGuardados);
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
