using MySql.Data.MySqlClient;
using pjtInsertarEliminarConsultarYBuscar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSeleccion_GSS
{
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();

        }

        private void dateTimePicker2_ValueChanged_2(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexionBD = Conexion.conex();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT *FROM alquiler WHERE  FECHA='" + dateTimePicker2.Text + "' ");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {


                    dateTimePicker2.Text = leer["FECHA"].ToString();


                }
                else
                {

                    dateTimePicker2.Text = "";


                    MessageBox.Show("El registro no existe");
                }
                conexionBD.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace);
                throw;
            }


        }
    }
}

