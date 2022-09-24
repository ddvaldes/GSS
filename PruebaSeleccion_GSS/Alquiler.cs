using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PruebaSeleccion_GSS
{
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
        }


        private void MOSTRAR_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conex();

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT *FROM cliente,carro, alquiler WHERE  CEDULA='" + CEDULA.Text + "' ") ;
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {


                    CEDULA.Text = leer["CEDULA"].ToString();
                    NOMBRE.Text = leer["NOMBRE"].ToString();
                    FECHA.Text = leer["FECHA"].ToString();
                    TIEMPO.Text = leer["TIEMPO (en dias)"].ToString();
                    SALD.Text = leer["SALDO"].ToString();
                    PLACA.Text = leer["PLACA"].ToString();
                    MARCA.Text = leer["MARCA"].ToString();

                }
                else
                {

                    CEDULA.Text = "";
                    NOMBRE.Text = "";
                    FECHA.Text = "";
                    TIEMPO.Text = "";
                    SALDO.Text = "";
                    PLACA.Text = "";
                    MARCA.Text = "";

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

 

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Carro();
            formulario.Show();
        }
    }
    
}
