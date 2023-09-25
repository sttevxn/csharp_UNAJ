/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 23/09/2023
 * Hora: 03:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace EJ2_EmpresaAerea
{
	/// <summary>
	/// Description of Aeropuerto.
	/// </summary>
	public class Aeropuerto
	{
		// Datos Miembro
		
		private string nombre;
		private string localidad;
		private int pasajesVendidos;
		private ArrayList listaAviones;
		private ArrayList listaVentas;
		
		// Constructor
		
		public Aeropuerto (string nombre, string localidad)
		{
			this.nombre = nombre;
			this.localidad = localidad;
			listaAviones = new ArrayList();
			listaVentas = new ArrayList();
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Localidad
		{
			set {localidad = value;}
			get {return localidad;}
		}
		public int PasajesVendidos
		{
			set {pasajesVendidos = value;}
			get {return pasajesVendidos;}
		}
		
		// Metodos Miembro
		
		public void AgregarAvion(Avion avion )
		{
			listaAviones.Add(avion);
		}
		
		public void Venta(string numeroVuelo, int cantidadAsientosSolicitados)
		{
			foreach(Avion aviones in listaAviones)
			{
				if(numeroVuelo == aviones.NumeroVuelo)
				{
					if(aviones.CantidadAsientos==0)
					{
						Console.WriteLine("No hay asientos disponibles para el vuelo {0} con destino a {1}",aviones.NumeroVuelo, aviones.DestinoVuelo);
						break;
					}
					else if (cantidadAsientosSolicitados > aviones.CantidadAsientos)
					{
						Console.WriteLine("No puede solicitar mas asientos de los disponibles");
						break;
					}
					else if (cantidadAsientosSolicitados == 0)
					{
						Console.WriteLine("No puede solicitar 0 (cero) asientos");
						break;
					}
					else
					{
						aviones.CantidadAsientos = aviones.CantidadAsientos - cantidadAsientosSolicitados;
						Console.WriteLine("Compra realizada con éxito");
						listaVentas.Add(aviones);
						PasajesVendidos = PasajesVendidos+1;
						break;
					}
				}
			}
		}
		
		public void VuelosNocturnos()
		{
			int cantidadVuelosNocturnos = 0;
			int promedioVuelosNocturnos ;
			int cantidadVuelosVendidos = listaVentas.Count;
			foreach(Avion ventasRealizadas in listaVentas)
			{
				if ((ventasRealizadas.HoraSalida<6)||(ventasRealizadas.HoraSalida>20))
				{
					cantidadVuelosNocturnos = cantidadVuelosNocturnos +1;
				}
			}
			promedioVuelosNocturnos = (cantidadVuelosNocturnos/cantidadVuelosVendidos);
			Console.WriteLine("Cantidad promedio de vuelos nocturnos vendidos: {0}",promedioVuelosNocturnos);
			
		}
		
		
	}
}
