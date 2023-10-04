/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/10/2023
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace x1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Uso de la funcion iterativa");
			Console.WriteLine(sumar(7));
			
			Console.WriteLine("Uso de la funcion recursiva");
			Console.WriteLine(sumaRecursiva(7));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		// FUNCIONES.
		
		public static int sumar(int numero)
		{
			int suma = 0;
			for (int x = 0; x<=numero; x++)
			{
				suma = suma+x;
			}
			return suma;
		}
		
		public static int sumaRecursiva(int numero) // FUNCION CON LLAMADA RECURSIVA. Hace el proceso inversa de una funcion iterativa.
		{
			if (numero == 1) // ---> Caso base.
			{
				return 1;
			}
			else
			{
				return numero + sumaRecursiva(numero-1); // ---> Caso recursivo. Para reducir la complejidad del problema, la funcion se autoinvoca.
			}
		}
		
	}
}