/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 28/9/2023
 * Time: 01:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace excepcionesPersonalizadas
{
	/// <summary>
	/// Description of MiExcepcion.
	/// </summary>
	public class MiExcepcion : Exception // ---> Hereda los atributos de la superclase de las excepciones.
	{
		// Datos Miembro.
		
		public string motivo;
		
		
		public MiExcepcion(string m)
		{ motivo = m;}
	}
}
