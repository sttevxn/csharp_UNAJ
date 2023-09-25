/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 23/09/2023
 * Hora: 03:19 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace EJ2_EmpresaAerea
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Avion avion1 = new Avion("AA","111","BSAS","EEUU",22,"12hs",3,200);
			Avion avion2 = new Avion("FlyBondi","222","BSAS","PY",12,"2hs",0,200);
			Avion avion3 = new Avion("LAN","333","BSAS","CHI",7,"1hs",0,200);
			
			Aeropuerto Chapelco = new Aeropuerto("Chapelco", "Chapelco");
			Chapelco.AgregarAvion(avion1);
			Chapelco.AgregarAvion(avion2);
			Chapelco.AgregarAvion(avion3);
			
			Console.WriteLine("---------- Bienvenido a Aereolineas Chapelco ----------");
			Console.WriteLine("----- Vuelos disponibles -----");
			Console.WriteLine("1- Vuelo numero {0}, destino: {1}. Hora salida: {2}. Empresa: {3}",avion1.NumeroVuelo, avion1.DestinoVuelo, avion1.HoraSalida, avion1.EmpresaAerea);
			Console.WriteLine("2- Vuelo numero {0}, destino: {1}. Hora salida: {2}. Empresa: {3}",avion2.NumeroVuelo,avion2.DestinoVuelo, avion2.HoraSalida, avion2.EmpresaAerea);
			Console.WriteLine("3- Vuelo numero {0}, destino: {1}. Hora salida: {2}. Empresa: {3}",avion3.NumeroVuelo,avion3.DestinoVuelo, avion3.HoraSalida, avion3.EmpresaAerea);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}