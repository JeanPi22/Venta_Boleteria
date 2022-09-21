using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_Boleteria.CapaDatos
{
    class Datos_Compra
    {
        private Datos_ConexionBD conexion = new Datos_ConexionBD();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;
        DataTable table = new DataTable();
        public void CrearCompra(int Documento, int cantidad, string Tribuna)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Crear_Compra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Tribuna", Tribuna);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable tribuna()
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Select * from Localidad";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            conexion.CloseConnection();
            return table;
        }
    }
}
