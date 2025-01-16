using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //declare la utilizacion de esta libreria.

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
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=tpfinaldb; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo, Nombre, Descripcion, Precio From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); //tabla virtual.

                while (lector.Read())  //si pudo leer devuelve true y selecciona el puntero en la primera fila.
                {
                    Articulo aux =  new Articulo();
                    aux.codigo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.precio = (decimal)lector["Precio"];

                    lista.Add(aux);

                }

                conexion.Close();
                return lista; //devuelve la lista de la base de datos.


            }
            catch (Exception ex)
            {

                throw ex;
            }




        }


    }
}
