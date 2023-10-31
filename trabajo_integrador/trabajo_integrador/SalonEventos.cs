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
		public ArrayList ListaEventosContratados
		{
			get {return listaEventosContratados;}
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
		
		// --->  Eventos.
		
		public void ContratarEvento(Eventos evento)
		{
			listaEventosContratados.Add(evento);
			Console.WriteLine("Evento contratado exitosamente");
		}
		public void EvaluarFechaEvento(Eventos evento)
		{
			foreach(Eventos eventosReservados in ListaEventosContratados)
			{
				if(eventosReservados.FechayHora.Date == evento.FechayHora.Date)
				{
					Console.WriteLine("La fecha esta ocupada por otro evento.");
				}
				break;
			}
		}
		public void CancelarEvento(string dniCliente, DateTime fechaActual)
		{
			bool estado = false;
			bool mayorMes = false;
			bool menorMes = false;
			foreach(Eventos eventosContratados in ListaEventosContratados)
			{
				if(eventosContratados.DniCliente == dniCliente)
				{
					estado = true;
					if(eventosContratados.FechayHora.Subtract(fechaActual).Days > 30)
					{
						mayorMes = true;
					}
					else if (eventosContratados.FechayHora.Subtract(fechaActual).Days < 30)
					{
						menorMes=true;
					}
					ListaEventosContratados.Remove(eventosContratados);
					break;
				}
			}
			if(estado)
			{
				Console.WriteLine("Evento cancelado satisfactoriamente.");
				if(mayorMes)
				{
					Console.WriteLine("Al cliente no se le reintegra la seña");
				}
				else if(menorMes)
				{
					Console.WriteLine("El cliente debe abonar el servicio completo");
				}
			}
			else
			{
				Console.WriteLine("No se ha encotrado al evento");
			}
		}
		
		// Agregar / Eliminar servicios de eventos ya contratados.
		
		
		public void EliminarServicio(string dniCliente, string codigoServicio)
		{
			
			foreach(Eventos eventosContratados in ListaEventosContratados)
			{
				if(eventosContratados.DniCliente == dniCliente)
				{
					eventosContratados.ServiciosContratados.Remove(codigoServicio);
					break;
				}
			}
		}
		
	}
}
