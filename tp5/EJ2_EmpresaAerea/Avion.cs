/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 23/09/2023
 * Hora: 03:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace EJ2_EmpresaAerea
{
	/// <summary>
	/// Description of Avion.
	/// </summary>
	public class Avion
	{
		// Datos Miembro
		
		private string empresaAerea;
		private string numeroVuelo;
		private string origenVuelo;
		private string destinoVuelo;
		private int horaSalida;
		private string duracionVuelo;
		private int cantidadEscalas;
		private int cantidadAsientos;
		
		// Constructor
		
		public Avion(string empresaAerea, string numeroVuelo, string origenVuelo, string destinoVuelo, int horaSalida, string duracionVuelo, int cantidadEscalas, int cantidadAsientos)
		{
			this.empresaAerea = empresaAerea;
			this.numeroVuelo = numeroVuelo;
			this.origenVuelo = origenVuelo;
			this.destinoVuelo = destinoVuelo;
			this.horaSalida = horaSalida;
			this.duracionVuelo = duracionVuelo;
			this.cantidadEscalas = cantidadEscalas;
			this.cantidadAsientos = cantidadAsientos;
		}
		
		// Propiedades
		
		public string EmpresaAerea
		{
			set {empresaAerea = value;}
			get {return empresaAerea;}
		}
		public string NumeroVuelo
		{
			set {numeroVuelo = value;}
			get {return numeroVuelo;}
		}
		public string OrigenVuelo
		{
			set {origenVuelo = value;}
			get {return origenVuelo;}
		}
		public string DestinoVuelo
		{	
			set {destinoVuelo = value;}
			get {return destinoVuelo;}
		}
		public int HoraSalida
		{
			set {horaSalida = value;}
			get {return horaSalida;}
		}
		public string DuracionVuelo
		{
			set {duracionVuelo = value;}
			get {return duracionVuelo;}
		}
		public int CantidadEscalas
		{
			set {cantidadEscalas = value;}
			get {return cantidadEscalas;}
		}
		public int CantidadAsientos
		{
			set {cantidadAsientos = value;}
			get {return cantidadAsientos;}
		}
	}
}
