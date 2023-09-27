/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 28/9/2023
 * Time: 01:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace excepcionesPersonalizadas
{
	class Program
	{
		public static void Main(string[] args)
		{
			int divisor, dividendo;
			string razon = "El divisor no puede ser cuatro (4)"; // ---> Sera el mensaje que se mostrara cuando la excepcion acurra.
			
			Console.WriteLine("Ingrese el dividendo");
			dividendo = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese el divisor");
			divisor = int.Parse(Console.ReadLine());
			
			try
			{
				int resultado = dividir(dividendo, divisor);
				if(divisor == 4)
				{
					throw new MiExcepcion(razon); // ---> Salta como error con la excepcion definida en la clase.
												  // ---> Se pasa como parametro el constructor definido en la clase.
				}
				Console.WriteLine("Resultado: {0}", resultado);
			}
			catch (MiExcepcion e)
			{
				Console.WriteLine(e.motivo);
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