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
           
            //Muestra la tabla libro al darle al boton
            BdComun.meteConsulta(dataGridView1, conexion, "select * from libro");
            }

        private void button3_Click(object sender, EventArgs e)
        {
            
          
                string consulta = textBox2.Text;
                BdComun.meteConsulta(dataGridView1, conexion, consulta);
               
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string editorial = textBox1.Text;
           BdComun.meteConsulta(dataGridView1, conexion, "select editorial,titulo from libro where editorial='" + editorial +"'");

               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        }    
}
