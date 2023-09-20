using System;

namespace h1
{
	class Program
	{
		static void Main (string [] args)
		{
			Console.WriteLine("Hola Mundo");
			
			Auto auto1 = new Auto ("Ford", "2000");
			MovilPolicial mp1 = new MovilPolicial("9999","BMW","2001");
			
			auto1.EncenderMotor();
			mp1.EncenderMotor();
			mp1.EncenderSirena();
			
			
			Console.Write("Pulse para seguir. . .");
			Console.ReadKey(true);
		}
	}
}