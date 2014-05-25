using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticaFinalGrupo3
{
    public partial class Andres : Form
    {

        public Andres()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                BdComun.obtenerConexion();
                MessageBox.Show("Conexion realizada");
            }
            catch
            {
                MessageBox.Show("Conexion rechazada");
            }

        }
    }
}
