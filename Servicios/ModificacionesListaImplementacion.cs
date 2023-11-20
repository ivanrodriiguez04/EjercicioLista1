using EjercicioLista1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista1.Servicios
{
    internal class ModificacionesListaImplementacion : ModificacionesListaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();

            listaAntigua.Add(nuevoCliente);
        }

        /// <summary>
        /// Metodo en el cual se pide toda la informacion necesario del cliente
        /// 141123 -> irm
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente()
        {

            //Creamos un  objeto cliente
            ClienteDto nuevoCliente = new ClienteDto();
            //le pedimos al usuario la informacion necesaria
            Console.WriteLine("Introduzca el id del cliente: ");
            nuevoCliente.IdCliente=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca su nombre:");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca sus apellidos:");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su dni");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su cumpleaños:");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su email:");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su numero telefonico");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha del alta del cliente:");
            nuevoCliente.FchAltaCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de la baja del cliente:");
            nuevoCliente.FchBajaCliente = Console.ReadLine();
            return nuevoCliente;
        }

 
    }
}
