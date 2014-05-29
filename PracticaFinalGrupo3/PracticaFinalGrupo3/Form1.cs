using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PracticaFinalGrupo3
{
    public partial class Form1 : Form
    {
        String cadenaConexion = "Server=" + "localhost" + ";Port=" + "3306" + ";Database=" + "biblioteca" + ";Uid=" + "root" + ";Pwd=" + "" + ";";

        public Form1()
        {
            InitializeComponent();
        }

        public MySqlDataAdapter conectaALaBaseDeDatos(String query)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptadorDatos = new MySqlDataAdapter(query, conexion);
                return adaptadorDatos;
            }
            catch {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Andres().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Javi().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Manu().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Emilio().ShowDialog();
        }
    }
}
