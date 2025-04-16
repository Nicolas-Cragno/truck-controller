using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection("server= NCRAGNO\\SQLEXPRESS; database=cantarini_db; integrated security=true");
            comando = new SqlCommand();
        } // iniciar conexión a base de datos

        public void setearConsulta(string consulta) // consultas-query a BD
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejectuarLectura()  // Leer contenido de BD según consulta
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ejecutarAccion() // escribir consulta - query desde app a BD
        {
            comando.Connection = conexion;
            
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader Lector // Leer lo leído en BD desde afuera (solo leer)
        {
            get { return lector; }
        }

        public void cerrarConexion() // finalizar conexión a base de datos
        {
            if (lector != null) { lector.Close(); }
            conexion.Close();
        }


    }
}
