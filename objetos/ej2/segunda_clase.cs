/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 7/9/2023
 * Time: 00:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ej2
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Auto
	{
		// Declaraciones: 1-> Datos Miembro, 2-> Constructores, 3-> Propiedades GET y SET, 4-> Funciones Miembro.
		
		// 1-> Declaracion de Datos miembro -> Variables de instancia ---> Atributos	
		
		private string marca;
		private int modelo;
		private double velocidad;
		private string color;
		private int puertas;
		
		// 2-> Declaracion de Constructores 
		
		public Auto(string marca, int modelo, string color, int puertas)
		{
			this.marca = marca; // ---> Si las variables se llaman igual que el Dato Miembro, se usa el "this. "
			this.modelo = modelo;
			this.color = color;
			this.puertas = puertas;
			velocidad = 0;
		}
		
		//3-> Propiedades
		
		 public string Marca
		 {
		 	get
		 	{
		 		return marca;
		 	}
		 	
		 	set
		 	{
		 		this.marca = value;
		 	}
		 }
		
		// 4 -> Declaracion de Funciones Miembro -> Metodos de instancia  ---> Comportamiento	
		
		public void imprimir_datos() // ---> Public porque el usuario hara uso de esta funcionalidad
		{
			Console.WriteLine("La marca es {0} y el modelo {1}. Color: {2}. Cantidad de puertas: {3}",marca, modelo, color, puertas);
		}
		
		// irrelevant
		
		public double acelerar()
		{
			velocidad = velocidad + 10;
			return velocidad;
		}
		
		public double acelerar(int x)
		{
			velocidad = velocidad + x;
			return velocidad;
		}
		
		public double acelerar(double x)
		{
			velocidad = velocidad * x;
			return velocidad;
		}
	}
}
