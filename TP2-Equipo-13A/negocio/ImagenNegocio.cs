using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        public Articulo buscarUltimoArticulo()
        {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setConsulta("select top 1 * from ARTICULOS order by Id desc");
                datos.ejecutarLectura();

                Articulo aux = new Articulo();
                while (datos.Lector.Read())
                {

                    aux.Id = (int)datos.Lector["Id"];



                }
                return aux;
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

        public void agregar(int idArticulo, string ImagenUrl, bool edicion)
        {

            int id = 0;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (!edicion)
                {
                    Articulo aux = new Articulo();

                    aux = buscarUltimoArticulo();
                    id = aux.Id;   
                    

                    
                }
                else 
                { 
                    id = idArticulo;    
                }
                datos.setConsulta("insert into IMAGENES values (' " + id + "', ' " + ImagenUrl + "')");

                datos.ejecutarAccion();
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

    }

}
