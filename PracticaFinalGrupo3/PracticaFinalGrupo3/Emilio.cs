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
    public partial class Emilio : Form
    {
        MySqlConnection conexion;


        public Emilio()
        {

            InitializeComponent();
            conexion = BdComun.obtenerConexion();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader datos;
            string consulta="";
            try
                {
                    consulta ="select * from libro";
                    command = new MySqlCommand(consulta, conexion);
                    datos = command.ExecuteReader();
                    dataGridView1.ColumnCount = datos.FieldCount;

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows.Add("id_libro", "ISBN", "Titulo", "Editorial", "aas", "asa");
                    while (datos.Read())
                    {
                      
                        dataGridView1.Rows.Add(datos.GetValue(0), datos.GetValue(1), datos.GetValue(2), datos.GetValue(3),datos.GetValue(4),datos.GetValue(5));
                    }
                    datos.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error al mostrar datos: " + exception.Message);
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader datos;
            string consulta = "";
            string campo;
            try
            {
                consulta = "select editorial,count(*) as 'nº de libros' from libro where editorial=";
                command = new MySqlCommand(consulta, conexion);
                datos = command.ExecuteReader();
                dataGridView1.ColumnCount = datos.FieldCount;


                while (datos.Read())
                {
                    dataGridView1.Rows.Add(datos.GetValue(0), datos.GetValue(1));
                }
                datos.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al mostrar datos :" + exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        }    
}
