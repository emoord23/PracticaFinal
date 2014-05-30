//PRACTICA REALIZADA POR MANUEL RIPOLL
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
    public partial class Manu : Form
    {
        MySqlConnection conexion;
        public Manu()
        {
            InitializeComponent();
            conexion = BdComun.obtenerConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";

            consulta = "SELECT * FROM autor";

            cmd = new MySqlCommand(consulta, conexion);
            reader = cmd.ExecuteReader();
            dataGridView1.ColumnCount = reader.FieldCount;

            dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ORDENA LOS DATOS POR NOMBRE DEL AUTOR
            dataGridView1.Rows.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";

            consulta = "SELECT * FROM autor ORDER BY nombre";

            cmd = new MySqlCommand(consulta, conexion);
            reader = cmd.ExecuteReader();
            dataGridView1.ColumnCount = reader.FieldCount;

            dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ORDENA LOS DATOS POR EL APELLIDO DEL AUTOR
            dataGridView1.Rows.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";

            consulta = "SELECT * FROM autor ORDER BY apellido";

            cmd = new MySqlCommand(consulta, conexion);
            reader = cmd.ExecuteReader();
            dataGridView1.ColumnCount = reader.FieldCount;

            dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            reader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ORDENA LOS DATOS POR LA FECHA DE NACIMIENTO DE LOS AUTORES
            dataGridView1.Rows.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";

            consulta = "SELECT * FROM autor ORDER BY fecha_nacimiento";

            cmd = new MySqlCommand(consulta, conexion);
            reader = cmd.ExecuteReader();
            dataGridView1.ColumnCount = reader.FieldCount;

            dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BUSCA LOS NOMBRES DE LOS AUTORES
            dataGridView1.Rows.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";
            String nombre = textBox1.Text;

            if (nombre == "") { MessageBox.Show("El campo nombre esta vacio", "Error"); }

            if (nombre != "")
            {

                consulta = "SELECT * FROM autor WHERE nombre ='" + nombre + "'";

                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                dataGridView1.ColumnCount = reader.FieldCount;

                dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
                reader.Close();
            }
        

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //BUSCA LOS AUTORES POR APELLIDO
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            textBox3.Clear();


            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";
            String apellido = textBox2.Text;

            if (apellido=="") { MessageBox.Show("El campo apellido esta vacio", "Error"); }

            if (apellido != "")
            {

                consulta = "SELECT * FROM autor WHERE apellido ='" + apellido + "'";

                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                dataGridView1.ColumnCount = reader.FieldCount;

                dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
                reader.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //BUSCA LOS AUTORES POR FECHA DE NACIMIENTO
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";
            String fecha_nac = textBox3.Text;

            if (fecha_nac=="") { MessageBox.Show("El campo de fecha esta vacio", "Error"); }

            if (fecha_nac != "")
            {

                consulta = "SELECT * FROM autor WHERE fecha_nacimiento ='" + fecha_nac + "'";

                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                dataGridView1.ColumnCount = reader.FieldCount;

                dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
                reader.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //BUSCA LOS AUTORES NACIDOS ENTRE DOS AÑOS
            dataGridView1.Rows.Clear();

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";
            String fecha1 = textBox4.Text;
            String fecha2 = textBox5.Text;

            if ((fecha1 == "") || (fecha2 == "")) { MessageBox.Show("Hay un campo de fecha vacio", "Error"); }

            if ((fecha1 != "") && (fecha2 != ""))
            {

                consulta = "SELECT * FROM autor WHERE YEAR(fecha_nacimiento) BETWEEN'" + fecha1 + "' and '" + fecha2 + "'";

                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                dataGridView1.ColumnCount = reader.FieldCount;

                dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
                reader.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //BUSCA POR EL CODIGO DEL AUTOR
            dataGridView1.Rows.Clear();
            

            MySqlCommand cmd;
            MySqlDataReader reader;
            String consulta = "";
            String codigo = textBox6.Text;

            if (codigo == "") { MessageBox.Show("El campos de texto codigo de autor esta vacio","Error"); }

            if (codigo != "")
            {
                consulta = "SELECT * FROM autor WHERE codigo_autor='" + codigo + "'";

                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();
                dataGridView1.ColumnCount = reader.FieldCount;

                dataGridView1.Rows.Add("Codigo_Autor", "Nombre", "Apellido", "Fecha Nacimiento");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
                reader.Close();
            }
        }





    }
}
