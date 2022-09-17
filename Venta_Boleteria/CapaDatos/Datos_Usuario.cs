using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_Boleteria.CapaDatos
{
    public class Datos_Usuario
    {
        private Datos_ConexionBD conexion = new Datos_ConexionBD();
        SqlCommand comando = new SqlCommand();

        public void CrearUsuario(int documento, string nombre, string correo, string contrasena)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "Agregar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", documento);
            comando.Parameters.AddWithValue("@Nombre_Apellido", nombre);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public bool LeerUsuario(int documento, string contrasena)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "select * from [dbo].[Usuario] WHERE Documento = @Documento and Contrasena = @Contrasena";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", documento);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            comando.CommandType = CommandType.Text;
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }      
    }
}
