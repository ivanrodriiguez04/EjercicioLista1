using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista1.Servicios
{
    /// <summary>
    /// Interfaz del menu
    /// 141123 -> irm
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y selecciona la opcion que desea el usuario
        /// 141123 -> irm
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
