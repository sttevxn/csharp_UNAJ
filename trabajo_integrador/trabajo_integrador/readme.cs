/*
 * Creado por SharpDevelop.
 * Usuario: Almnos
 * Fecha: 18/10/2023
 * Hora: 14:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
 
 
 /*
  ENUNCIADO
  
  En un salón de fiestas se tienen registrados los eventos contratados y el conjunto de empleados que
trabaja de forma fija en los eventos. De cada evento se almacena: nombre y dni del cliente, fecha y
hora del evento, tipo de evento (cumpleaños de 15, casamientos, bautismos, etc.. ), encargado, lista
de servicios contratados, costo total (se calcula en base a los servicios solicitados). De cada servicio
ofrecido se almacena nombre del servicio, tipo de servicio (catering, bebida, mozos, DJ, inflables,
cama elástica, etc), descripción (detalle de lo que incluye el servicio), cantidad solicitada, costo final
del servicio (teniendo en cuenta la cantidad solicitada). De cada empleado se registra su nombre y
apellido, dni, nro de legajo, sueldo y tarea que desempeña. El encargado de un evento es un
empleado que organiza y controla el desarrollo del evento y cobra un plus sobre el sueldo.
Se deberá desarrollar una aplicación, utilizando las clases que considere necesarias, utilizando
herencia cuando corresponda. La aplicación debe proveer, mediante un menú, las siguientes
funcionalidades:
a- Agregar un servicio
b- Eliminar un servicio.
c- Dar de alta un empleado/encargado
d- Dar de baja un empleado/encargado
e- Reservar el salón para un evento. El cliente puede incluir en su pedido un solo servicio o
varios. El salón toma una sola reserva para la misma fecha. En caso de que ya tenga una
reserva previa se levanta una excepción indicando lo ocurrido. Al confirmar la reserva se le
asigna un encargado al evento.
f- Cancelar un evento. En caso que el cliente solicite la cancelación con más de un mes de
anticipación a la fecha del servicio, no se le reintegra la seña. En otro caso, el cliente debe
abonar el servicio completo.
g- Submenú de impresión: listado de eventos, de clientes, de empleados, listado de eventos de
un mes determinado
  
  
  */

// Una sola lista de empleados que contenga a los encargados.
	//---> Agregar nuevo atributo booleano< a los encargados.
	
// Dentro de cada evento hay una lista de servicios.
// Metodo de AGREGAR/ELIMINAR servicio (menu administrativo) tiene que funcionar para cada evento.
// Las excepciones deben estar pricimalmente en el Program.cs
// Si el cliente cancela con + de un mes de anticipacion -> no se devuelve la seña.
// Si el cliente cancela con - de un mes de anticipacion, debe pagar el evento completo.