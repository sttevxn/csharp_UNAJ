/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 27/9/2023
 * Time: 23:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tp7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a = 0;
			int divisor;
			
			Console.WriteLine("Ingrese un divisor");
				
			divisor = int.Parse(Console.ReadLine());
			
			int[] listaNumeros = new int[]{12};
			
			try // ---> Controla la situacion que pueda causar un error.
			{
				int resultado = (listaNumeros[a]/divisor);
				Console.WriteLine("Resultado: {0}",resultado);
			}
			catch (Exception) // ---> Si ocurre la excepcion, el programa lanza un mensaje de error. SOLO SI OCURRE.
				
			/*
			 Si el usuario ingresa un cero (0), el catch entran en accion.
			*/
				
			{
				Console.WriteLine("Ha ocurrido un error");
			}
			
			Console.WriteLine("fin de la operacion");
			
			
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}