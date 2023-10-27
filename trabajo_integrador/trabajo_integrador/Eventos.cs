/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 04:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;


namespace trabajo_integrador
{
	/// <summary>
	/// Description of Eventos.
	/// </summary>
	public class Eventos
	{
		
		// Datos Miembro
		
		private string nombreCliente;
		private string dniCliente;
		private DateTime fechayHora;
		private string tipo;
		private int precioFinalEvento;
		private Encargado encargado;
		private ArrayList serviciosContratados;
		
		// Constructor
		
		public Eventos(string nombreCliente, string dniCliente, DateTime fechayHora, string tipo, Encargado encargado)
		{
			this.nombreCliente = nombreCliente;
			this.dniCliente = dniCliente;
			this.fechayHora = fechayHora;
			this.tipo = tipo;
			this.encargado = encargado;
			serviciosContratados = new ArrayList();
		}
		
		// Propiedades.
		
		public string NombreCliente
		{
			set {nombreCliente = value;}
			get {return nombreCliente;}
		}
		public string DniCliente
		{
			set {dniCliente = value;}
			get {return dniCliente;}
		}
		public DateTime FechayHora
		{
			set {fechayHora = value;}
			get {return fechayHora;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		public int PrecioFinalEvento
		{
			set {precioFinalEvento = value;}
			get {return precioFinalEvento;}
			
		}
		public Encargado Encargado
		{
			set {encargado = value;}
			get {return encargado;}
		}
		public ArrayList ServiciosContratados
		{
			get {return serviciosContratados;}
		}
		
		// Metodos
		
		// ---> Servicios.
		
		public void AgregarServicio(Servicios servicio)
		{
			serviciosContratados.Add(servicio);
			Console.WriteLine("Servicio contratado correctamente");
		}
		
		public void EliminarServicio(string codigo)
		{
			bool estado = false;
			foreach(Servicios serviciosCargados in serviciosContratados)
			{
				if(serviciosCargados.Codigo == codigo)
				{
					estado = true;
					serviciosContratados.Remove(serviciosCargados);
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
		public void CalcularPrecioFinalEvento()
		{
			foreach(Servicios serviciosC in ServiciosContratados)
			{
				PrecioFinalEvento = PrecioFinalEvento + serviciosC.CostoTotal;
			}
			Console.WriteLine("El costo del evento contratado es: ${0}",PrecioFinalEvento);
		}
		
	}
}
