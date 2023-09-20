/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 21/9/2023
 * Time: 00:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace h1
{
	/// <summary>
	/// Description of MovilPolicial.
	/// </summary>
	public class MovilPolicial : Auto //---> MovilPolicial hereda los miembros de la SuperClase Auto.
	{
		private string numeroMovil; // ---> Ademas de los atributos heredados de Auto, se agregan mas atributos.
		
		public MovilPolicial(string numeroMovil, string marca, string modelo) : base(marca,modelo) // ---> El metodo Base() pasa los parametros del constructor de la clase Auto.
		{
			this.numeroMovil = numeroMovil;
		}
		
		public void EncenderSirena()
		{
			Console.WriteLine("Sirena Encendida");
		}
		
		public void ApagarSirena()
		{
			Console.WriteLine("Sirena Apagada");
		}
	}
}
