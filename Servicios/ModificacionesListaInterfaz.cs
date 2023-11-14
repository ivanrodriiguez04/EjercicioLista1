using EjercicioLista1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista1.Servicios
{
    /// <summary>
    /// Interfaz de las modificaciones de la lista
    /// 141123 -> irm
    /// </summary>
    internal interface ModificacionesListaInterfaz
    {
        /// <summary>
        /// Metodo que da del alta a un nuevo cliente
        /// 141123 -> irm
        /// </summary>
        /// <param name=""></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);
    }
}
