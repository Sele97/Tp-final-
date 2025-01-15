using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //declaer la uilizacion de esta libreria.

namespace winform_app
{
    class ArticuloNegocio
    {
        public List<Articulo> listar() // metodo devuelve lista.
        {
            List<Articulo> lista = new List<Articulo>(); // crea la lista.
            SqlConnection conexion = new SqlConnection(); //genero la conexion con la base de datos.
            SqlCommand comando = new SqlCommand(); // permite realizar acciones.
            SqlDataReader lector; 

            try
            {
                conexion.ConnectionString = "server=DESKTOP-J4TSABP\\SQLEXPRESS; database=tpfinaldb; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText
                return lista; //devuelve la lista de la base de datos.


            }
            catch (Exception ex)
            {

                throw ex;
            }




        }


    }
}
