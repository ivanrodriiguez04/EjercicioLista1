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
            //Variables
            string nombreCliente, apellidosCliente, dniCliente, fchNacimientoCliente, emailCLiente, fchAltaCliente, fchBajaCliente;
            int tlfCliente;

            Console.WriteLine("Introduzca su nombre:");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca sus apellidos:");
            apellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su dni");
            dniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su cumpleaños:");
            fchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su email:");
            emailCLiente = Console.ReadLine();
            Console.WriteLine("Introduzca su numero telefonico");
            tlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la fecha del alta:");
            fchAltaCliente = Console.ReadLine();
            Console.WriteLine("Indique la fecha de la baja:");
            fchBajaCliente = Console.ReadLine();


            ClienteDto nuevoCliente=new ClienteDto(nombreCliente,apellidosCliente,dniCliente,fchNacimientoCliente,emailCLiente,tlfCliente,fchAltaCliente,fchBajaCliente);
            
            return nuevoCliente;
        }

 
    }
}
