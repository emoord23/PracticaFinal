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
    public partial class Andres : Form
    {

        MySqlConnection conexion = new MySqlConnection();
        String cadenaServidor;
        public Andres()
        {
            InitializeComponent();
            try
            {
                cadenaServidor = "Server=mysql13.000webhost.com;User id=a3335421_root;Database=a3335421_biblio;Password=clase123;";
                conexion.ConnectionString = cadenaServidor;
                conexion.Open();
                MessageBox.Show("Conectado");
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show("Error: " + Convert.ToString(ex));
            }
        }
    }
}
