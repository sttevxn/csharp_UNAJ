/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 22/9/2023
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ej1_horarios
{
	/// <summary>
	/// Description of Horarios.
	/// </summary>
	public class Horarios
	{
		// Datos Miembro
		
		private string nombreMateria;
		private string diaMateria;
		private string horaInicioMateria;
		
		// Constructores
		
		public Horarios(string nombreMateria, string diaMateria, string horaInicioMateria)
		{
			this.nombreMateria = nombreMateria;
			this.diaMateria = diaMateria;
			this.horaInicioMateria = horaInicioMateria;
		}
		
		// Propiedades
		
		public string NombreMateria
		{
			set {nombreMateria = value;}
			get {return nombreMateria;}
		}
		
		public string DiaMateria
		{
			set {diaMateria = value;}
			get {return diaMateria;}
		}
		
		public string HoraInicioMateria
		{
			set {horaInicioMateria = value;}
			get {return horaInicioMateria;}
		}
		
		
		
	}
}
