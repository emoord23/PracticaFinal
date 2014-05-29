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
        int tipoConsulta = 0;
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
                    buttonConectar.Text = "Conectado";
                    buttonConectar.ForeColor = Color.Black;
                    buttonConectar.BackColor = Color.LightGreen;
                }
            }
            catch
            {
                buttonConectar.Text = "Desconectado";
                buttonConectar.BackColor = Color.Red;
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                

            }
        }

        private void rbDPersonales_CheckedChanged(object sender, EventArgs e)
        {
            // 0 para los Datos personales, 1 para los Prestamos, 2 para las Multas y 3 para los Datos libros
            if (rbDPersonales.Checked) tipoConsulta = 0;
            else if (rbPrestamos.Checked) tipoConsulta = 1;
            else if (rbMultas.Checked) tipoConsulta = 2;
            else if (rbDatosLibros.Checked) tipoConsulta = 3;
        }
    }
}
