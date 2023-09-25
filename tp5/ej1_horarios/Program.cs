/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 22/9/2023
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ej1_horarios
{
	class Program
	{
		public static void Main(string[] args)
		{

			Alumno alumno1 = new Alumno("StevenVillalba", 94733360, 74731);
			Alumno alumno2 = new Alumno("StevenVillalba", 94733360, 74731);
			alumno1.AgregarMateria("Algoritmos y Programacion ", "Viernes", "14hs");
			alumno2.AgregarMateria("Algoritmos y Programacion ", "Viernes", "14hs");
			
			alumno1.ListaMaterias();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}