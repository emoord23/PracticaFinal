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
        MySqlConnection conn;
        bool conectado = false;

        public Andres()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conn = BdComun.obtenerConexion();
                if (conn != null)
                {
                    conectado = true;
                    buttonConectar.Text = "Conexión establecida";
                    buttonConectar.BackColor = Color.LightGreen;
                }
            }
            catch
            {
                buttonConectar.Text = "Conexión rechazada";
                buttonConectar.BackColor = Color.Red;
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                MySqlCommand cmd;
                MySqlDataReader reader;
                try
                {
                    cmd = new MySqlCommand("SELECT socio.nombre, socio.direccion, socio.telefono FROM socio", conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }
             }
        }
    }
}
