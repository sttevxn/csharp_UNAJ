/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 11/09/2023
 * Hora: 08:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ej1
{
	/// <summary>
	/// Description of hora.
	/// </summary>
	public class Hora
	{
		// 1)
		
		private int horas;
		private int minutos;
		private int segundos;
		
		// 2)
		
		public Hora(int horas, int minutos, int segundos)
		{
			this.horas = horas;
			this.minutos = minutos;
			this.segundos = segundos;
		}
		
		// 4)
		
		public void imprimir()
		{
			Console.WriteLine("{0} Horas, {1} Minutos, {2} Segundos",horas,minutos,segundos);
		}
	}
}
