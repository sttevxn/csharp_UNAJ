/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 28/9/2023
 * Time: 01:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace propagacionExcepciones
{
	class Program
	{
		public static void Main(string[] args)
		{
			int divisor, dividendo;
			
			Console.WriteLine("Ingrese el dividendo");
			dividendo = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese el divisor");
			divisor = int.Parse(Console.ReadLine());
			
			try
			{
				int resultado = dividir(dividendo, divisor);
				Console.WriteLine("Resultado: {0}", resultado);
			}
			
			/*
			 * Cuando se instancian mas de un catch
			 	 SOLO SE EJECUTARAR EL QUE CORRESPONDA. 
			*/
			catch (DivideByZeroException)
			{
				Console.WriteLine("El divisor no puede ser cero (0))");
			}
			catch(IndexOutOfRangeException)
			{
				Console.WriteLine("   ");
			}
			
			Console.WriteLine("Fin del programa");
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int dividir(int x, int y)
		{
			int resultado = (x/y);
			return resultado;
		}
	}
}