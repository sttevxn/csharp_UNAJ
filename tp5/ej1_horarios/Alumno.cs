/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 22/9/2023
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace ej1_horarios
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{
		// Datos Mimebro
		
		private string nombre;
		private int dni;
		private int numeroLegajo;
		private ArrayList listaHorarios;
		
		// Constructor
		
		public Alumno(string nombre, int dni, int numeroLegajo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.numeroLegajo = numeroLegajo;
			listaHorarios = new ArrayList(); // ---> Se inicializa el ArraryList dentro del constructor, NUNCA como parametro
		}
		
		// Propiedades
		
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		
		public int Dni
		{
			set {dni = value;}
			get {return dni;}
		}
		
		public int NumeroLegajo
		{
			set {numeroLegajo = value;}
			get {return numeroLegajo;}
		}
		
		// Metodos Miembro
		
		public void AgregarMateria(string nombreMateria, string dia, string horario)
		{
			bool disponible = false;
			foreach(Horarios horariosGuardados in listaHorarios)
			{
				if(dia == horariosGuardados.DiaMateria)
				{
					if(horario == horariosGuardados.HoraInicioMateria)
					{
						disponible = true;
						break;
					}
				}
				if(! disponible)
				{
					Horarios horarioAGuardar = new Horarios(nombreMateria, dia, horario);
					listaHorarios.Add(horarioAGuardar);
				}
				else
				{
					Console.WriteLine("{0}{1}, horario ocupado.",dia,horario);
					Console.ReadKey();
				}
			}
		}
		
		public void ListaMaterias()
		{
			ArrayList mat = new ArrayList();
			
			foreach (Horarios horariosGuardados in listaHorarios)
			{
				if(!mat.Contains(horariosGuardados.NombreMateria)) // ---> Si la materia en listaHorarios no esta en el nuevo ArrayList, se lo agrega sin repeticiones.
				{
					mat.Add(horariosGuardados.NombreMateria);
				}
			}
			Console.WriteLine(" Materias: ");
			Console.WriteLine("-----------------------------");
			
			foreach(string nom in mat)
			{
				Console.WriteLine(nom);
			}
		}
		
		public void ListaHorariosMaterias()
		{
			Console.WriteLine(" Horarios y Materias");
			Console.WriteLine("-----------------------------");
			
			foreach(Horarios horariosGuardados in listaHorarios)
			{
				Console.WriteLine(" Materia: {0}. Dia: {1}. Horiario: {2}.", horariosGuardados.NombreMateria, horariosGuardados.DiaMateria, horariosGuardados.HoraInicioMateria);
			}
			
		}
	}
}
