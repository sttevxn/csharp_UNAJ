/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 21/9/2023
 * Time: 00:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace h1
{
	/// <summary>
	/// Description of Auto.
	/// </summary>
	public class Auto
	{
		// ---> Datos Miembro
		
		protected string marca; // ---> Para que la subclase pueda heredar los miembros, los modificadores pasan a ser PROTECTED.
		protected string modelo;
		
		// ---> Constructores
		
		public Auto(string marca, string modelo)
		{
			this.marca = marca;
			this.modelo = modelo;
		}
		
		// ---> Propiedades
		
		public string Marca
		{
			set
			{
				marca = value;
			}
			get
			{
				return marca;
			}
		}
		public string Modelo
		{
			set
			{
				modelo = value;
			}
			get
			{
				return modelo;
			}
		}
		
		// ---> Metodos.
		
		
		public void EncenderMotor()
		{
			Console.WriteLine("Auto Encendido");
		}
		
		public void ApagarMotor()
		{
			Console.WriteLine("Auto Apagado");
		}
		
	}
}
