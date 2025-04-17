using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dominio; //carpeta dentro del proyecto

namespace negocio
{
    public class EventoNegocio
    {
        public List<Evento> listarEventos() // listado de eventos de la base de datos
        {
            List<Evento> lista = new List<Evento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select id, fecha, chofer, interno, evento, detalle from eventos");
                datos.ejectuarLectura();

                while (datos.Lector.Read())
                {
                    // https://campusmaxiprograma.com/mod/page/view.php?id=1072
                    // ver como cambiar datos relacionales para que figure nombre del chofer

                    Evento auxEvento = new Evento();
                    auxEvento.Id = (int)datos.Lector["id"];
                    auxEvento.Fecha = (DateTime)datos.Lector["fecha"];
                    auxEvento.Tipo = (string)datos.Lector["evento"];
                    auxEvento.Detalle = (string)datos.Lector["detalle"];
                    auxEvento.DNI_Persona = (int)datos.Lector["chofer"];
                    auxEvento.Nro_Interno = (int)datos.Lector["interno"];

                    lista.Add(auxEvento);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            } 
        }

        public void agregar(Evento nvEv) // Agregar Evento a DB
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO eventos (evento, detalle, fecha, chofer, interno) VALUES ('" + nvEv.Tipo + "', ' " + nvEv.Detalle + " ', CURRENT_TIMESTAMP, " + nvEv.DNI_Persona + " , " + nvEv.Nro_Interno + ");" );
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificar(Evento mdEv) // Modificar evento existente en la DB
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE eventos SET evento = '" + mdEv.Tipo + "', detalle = '" + mdEv.Detalle + "', chofer = " + mdEv.DNI_Persona + ", interno = " + mdEv.Nro_Interno + " WHERE id = " + mdEv.Id + ";");

                //datos.setearConsulta("UPDATE eventos SET evento = '" + mdEv.Tipo + "' WHERE id = " + mdEv.Id + ";");
                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

    }
}
