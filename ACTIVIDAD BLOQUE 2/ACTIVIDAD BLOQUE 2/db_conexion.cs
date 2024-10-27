using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACTIVIDAD_BLOQUE_2
{
    internal class db_conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public db_conexion()
        {
            miConexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PeliculasDB.mdf;Integrated Security = True";
            miConexion.Open();
        }
          public DataSet obtenerDatos()
          {
            ds.Clear();
            miComando.Connection = miConexion;
            miComando.CommandText = "SELECT Peliculas.titulo, Peliculas.Autor, Peliculas.Sinopsis, Peliculas.Duracion, Peliculas.Clasificacion";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "Peliculas");
            return ds;
          }

    }
}

