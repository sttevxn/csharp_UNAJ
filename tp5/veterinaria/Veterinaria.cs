/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 18/09/2023
 * Hora: 03:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using composicion_objetos;

namespace veterinaria
{
	/// <summary>
	/// Description of Vterinaria.
	/// </summary>
	public class Veterinaria
	{
		// Datos Miembro
		
		private string nombre;
		private int cantidadMascotas;
		private Mascota [] listaMascotas;
		
		//Constructores
		
		public Veterinaria(string nombre)
		{
			this.nombre = nombre;
			listaMascotas = new Mascota[100];
			cantidadMascotas = 0;
		}
		
		// Propiedades
		
		public string Nombre
		{
			set
			{
				nombre = value;
			}
			get
			{
				return nombre;
			}
		}
		
		public int CantidadMascotas
		{
			set
			{
				cantidadMascotas = value;
			}
			get
			{
				return cantidadMascotas;
			}
		}
		
		public Mascota [] ListaMascotas
		{
			get
			{
				return listaMascotas;
			}
		}
		
		// Metodos de Instancia
		
		public void AgregarMascota(Mascota nuevaMascota)
		{
			int posicion = cantidadMascotas;
			listaMascotas[posicion] = nuevaMascota;
			cantidadMascotas += 1;
		}
		
		public  Mascota VerDatos(int posicion)
		{
			return listaMascotas[posicion];
		}
		
		public void EliminarMascota(Mascota mascotaABorrar)
		{
			int posicion = Array.IndexOf(listaMascotas, mascotaABorrar); // ---> Identifica la posicion de la mascota que se desea borrar
			for (int x = posicion; x < cantidadMascotas; x++)
			{
				listaMascotas[x] = listaMascotas[x+1]; // ---> Reemplaza la mascota que se desea a borrar por la siguiente en la lista
			}
			listaMascotas[cantidadMascotas] = null; // ---> La mascota no se "borra", se le asigna un valor nulo
			cantidadMascotas = cantidadMascotas -1;
		}
		
		public void NuevoDiagnostico(string nombreMascota, string nombreDueño, string nuevoDiagnostico)
		{
			for(int x = cantidadMascotas; x < cantidadMascotas; x++)
			{
				Mascota m = (Mascota) listaMascotas[x];
				if((m.Nombre == nombreMascota) && (m.NombreDueño == nombreDueño)) // ---> Compara los parametros con las propiedades de la clase Mascota
				{
					m.Diagnostico = nuevoDiagnostico;
					break;
				}
			}
		}
		
	}
}
