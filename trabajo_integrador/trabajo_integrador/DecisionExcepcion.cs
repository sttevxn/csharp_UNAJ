/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 24/11/2023
 * Hora: 03:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	/// <summary>
	/// Description of DecisionExcepcion.
	/// </summary>
	public class DecisionExcepcion : Exception  
	{
		public string motivo;
		
		public DecisionExcepcion(string motivo)
		{
			this.motivo = motivo;
		}
	}
}
