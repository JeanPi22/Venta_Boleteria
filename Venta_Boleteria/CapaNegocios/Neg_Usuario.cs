using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_Boleteria.CapaDatos;

namespace Venta_Boleteria.CapaNegocios
{
    class Neg_Usuario
    {
        private Datos_Usuario objCDusu = new Datos_Usuario();

        public void CrearUsuario(int documento, string nombre, string correo, string contrasena)
        {
            objCDusu.CrearUsuario(documento, nombre, correo, contrasena);
        }
    }
}
