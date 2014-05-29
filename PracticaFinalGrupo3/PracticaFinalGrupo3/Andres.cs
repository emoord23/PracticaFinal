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
        String[] consulta = new String[] {"SELECT * FROM socio ORDER BY socio.nombre ASC, socio.apellido ASC",
                                          "SELECT socio.nombre, socio.apellido, libro.titulo, libro.editorial, socio_libro.fecha_prestamo, socio_libro.fecha_limite, socio_libro.fecha_devolucion FROM socio_libro, socio, libro WHERE socio_libro.id_libro = libro.id_libro AND socio.codigo_socio = socio_libro.codigo_socio ORDER BY socio.nombre ASC, socio.apellido ASC, libro.titulo ASC",
                                          "SELECT socio.nombre, socio.apellido, socio.num_multas FROM socio ORDER BY socio.nombre ASC, socio.apellido ASC",
                                          "SELECT libro.titulo, libro.editorial FROM libro ORDER BY libro.titulo ASC"};

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
                switch (tipoConsulta)
                {
                    case 0: { BdComun.meteConsulta(dataGridView1, conn, consulta[0]); } break;
                    case 1: { BdComun.meteConsulta(dataGridView1, conn, consulta[1]); } break;
                    case 2: { BdComun.meteConsulta(dataGridView1, conn, consulta[2]); } break;
                    case 3: { BdComun.meteConsulta(dataGridView1, conn, consulta[3]); } break;
                }
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
