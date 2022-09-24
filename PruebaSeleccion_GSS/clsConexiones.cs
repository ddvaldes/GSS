using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace pjtInsertarEliminarConsultarYBuscar
{
    class clsConexiones
    {

        public static MySqlConnection cnx = new MySqlConnection("server=localhost; database=prueba_gss; Uid=root; pwd=;");



        public static void Registrar(string Q)
        {

            MySqlCommand cmd = new MySqlCommand(Q, cnx);

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                cnx.Close();
            }

        }

        public static DataTable Consultageneral(string Q)
        {

            MySqlDataAdapter DA = new MySqlDataAdapter(Q, cnx);
            DataTable TB = new DataTable();
            try
            {
                cnx.Open();
                DA.Fill(TB);
                cnx.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                cnx.Close();

            }
            return TB;

        }



    }
}
