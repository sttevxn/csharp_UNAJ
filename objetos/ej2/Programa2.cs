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
	class Program
	{
		public static void Main(string[] args)
		{
			
			Auto auto1, auto2; // 1 --> Declaracion de una variable.
			
			// Auto 1
			
			auto1 = new Auto("Mercedes Benz", 2001, "gris", 2); // 2 --> Instancia de un Objeto.
			
			auto1.imprimir_datos(); // 3 --> Uso de la funcionalidad implementada.
			
			Console.WriteLine(auto1.acelerar()); // --> Uso de la sobrecarga, (Velocidad = 10)
			Console.WriteLine(auto1.acelerar(15)); // --> (Velocidad = 25)
			Console.WriteLine(auto1.acelerar(1.2)); // --> (Velocidad = 30) 
			
			
			
			
			
			
			// Auto 2
			
			auto2 = new Auto("Ford", 2022, "azul", 4);
			auto2.imprimir_datos();
			
			auto2.Marca = "BMW"; // (Apartado propiedades. Al detectar un "=", se ejecuta el SET)
			//->
			auto2.imprimir_datos();
			
			Console.WriteLine(auto2.Marca); //(Apartado propiedades. Al no detectar un "=", se ejecuta el GET)
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}