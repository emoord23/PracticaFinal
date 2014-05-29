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
                MySqlCommand cmd;
                MySqlDataReader reader;
                String consulta = "";
                try
                {
                    switch (tipoConsulta)
                    {
                        case 0: { consulta = "SELECT socio.nombre, socio.apellido, socio.direccion, socio.telefono FROM socio ORDER BY socio.nombre ASC"; } break;
                        case 1: { consulta = "SELECT socio.nombre, socio.apellido, libro.titulo, socio_libro.fecha_prestamo, socio_libro.fecha_limite, socio_libro.fecha_devolucion FROM socio_libro, libro, socio WHERE socio.codigo_socio = socio_libro.codigo_socio AND socio_libro.id_libro = libro.id_libro ORDER BY socio.nombre ASC"; } break;
                        case 2: { consulta = "SELECT socio.nombre, socio.apellido, COUNT(socio_libro.id_libro) as 'Nº Multas' FROM socio_libro, libro, socio WHERE socio_libro.codigo_socio = socio.codigo_socio AND socio_libro.id_libro = libro.id_libro AND socio_libro.fecha_limite < socio_libro.fecha_devolucion GROUP BY socio.nombre, socio.apellido ORDER BY COUNT(socio_libro.id_libro) DESC"; } break;
                        case 3: { } break;
                    }
                    cmd = new MySqlCommand(consulta, conn);
                    reader = cmd.ExecuteReader();
                    dataGridView1.ColumnCount = reader.FieldCount;

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                    }
                    reader.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error:" + exception.Message);
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
