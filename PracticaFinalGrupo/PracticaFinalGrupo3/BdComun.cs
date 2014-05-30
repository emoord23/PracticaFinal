using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
