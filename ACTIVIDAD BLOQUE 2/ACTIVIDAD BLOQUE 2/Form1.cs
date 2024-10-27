using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_BLOQUE_2
{
    public partial class Form1 : Form
    {
        db_conexion objConexion = new db_conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["Peliculas"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idPeliculas"] };
            mostrarDatos();
        }
         private void mostrarDatos()
         {
            txttitulo.Text = dt.Rows[posicion].ItemArray[1].ToString();
            txtautor.Text = dt.Rows[posicion].ItemArray[2].ToString();
            txtsinopsis.Text = dt.Rows[posicion].ItemArray[3].ToString();
            txtduracion.Text = dt.Rows[posicion].ItemArray[4].ToString();
            txtclasificacion.Text = dt.Rows[posicion].ItemArray[5].ToString();
         }
    }
}
