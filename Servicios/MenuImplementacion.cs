using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista1.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// 1411123 -> irm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int respuesta;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Insertar nuevo cliente");
            Console.WriteLine("2. Mostrar lista");
            Console.WriteLine("¿Que opcion desea utilizar?");
            respuesta=Convert.ToInt32(Console.ReadLine());

            return respuesta;
        }
    }
}
