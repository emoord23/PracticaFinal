using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data;
using System.Data;
<<<<<<< HEAD
=======

>>>>>>> origin/master

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
        public static void meteConsulta(DataGridView dgvControl, MySqlConnection conexion, string consulta)
        {
            DataSet dsConsulta;
            MySqlDataAdapter daConsulta;

            daConsulta = new MySqlDataAdapter(consulta, conexion);

            dsConsulta = new DataSet();
            daConsulta.Fill(dsConsulta, "consulta");
            dgvControl.DataSource = dsConsulta;
            dgvControl.DataMember = "consulta";
        }
<<<<<<< HEAD

=======
>>>>>>> origin/master
    }
}
