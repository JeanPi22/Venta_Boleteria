using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_Boleteria.CapaDatos;

namespace Venta_Boleteria.CapaNegocios
{
    class Neg_Compra    {
       
        private Datos_Compra objCDcompra = new Datos_Compra();

        public void CrearUsuario(int Documento, int cantidad, string Tribuna)
        {
            objCDcompra.CrearCompra(Documento, cantidad, Tribuna);
        }

        public DataTable DatosTribuna()
        {
            DataTable tabla = new DataTable();
            tabla = objCDcompra.tribuna();
            return tabla;
        }
    }
}
