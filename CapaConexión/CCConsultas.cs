using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaConexión
{
    public class CCConsultas
    {
        private CCConexion conexion = new CCConexion();
        private SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tablausuarios = new DataTable();

        public DataTable MostrarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablausuarios.Load(leer);
            conexion.CerrarConexion();
            return tablausuarios;
        }

        public SqlDataReader IniciarSesion(String usuario,String contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "IniciarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario",usuario);
            comando.Parameters.AddWithValue("@Contraseña",contraseña);
            leer = comando.ExecuteReader();
            return leer;
        }

    }
}
