using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticaFinalGrupo3
{
    public class BdComun
    {

        public static String datosConexion = "Server=127.0.0.1;User id=root;Database=biblioteca;password=;";

        public static MySqlConnection obtenerConexion() {
                MySqlConnection conectar = new MySqlConnection(datosConexion);
                conectar.Open();
                return conectar;
        }

        public static DataGridView meteConsulta(DataGridView control, MySqlConnection conexion, String consulta)
        {
            MySqlCommand cmd;
            MySqlDataReader reader;
            try
            {
                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                control.ColumnCount = reader.FieldCount;
                Object[] objetos = new Object[reader.FieldCount];
                for (int i = 0; i < objetos.Length; i++)
                {
                    if (reader.Read())
                    {
                        objetos[i] = reader.GetValue(i);
                    }
                }
                control.Rows.Add(objetos);
                reader.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
            return control;
        }
    }
}
