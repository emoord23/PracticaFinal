using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalGrupo3
{
    public partial class Javi : Form
    {
        public Javi()
        {
            InitializeComponent();
        }
        bool limpiaPantalla = true;
        String operacion, borrado;
        double numero1, numero2, resultado;



        //Aqui definimos los numeros
        private void num1_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (limpiaPantalla == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                limpiaPantalla = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }

        }
         
        // fin de los numeros

        //inicio de los botones de las operaciones
      private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            limpiaPantalla = true;
        }

      private void resta_Click(object sender, EventArgs e)
      {
          operacion = "-";
          numero1 = double.Parse(Pantalla.Text);
          limpiaPantalla = true;
      }

      private void multiplicacion_Click(object sender, EventArgs e)
      {
          operacion = "*";
          numero1 = double.Parse(Pantalla.Text);
          limpiaPantalla = true;
      }

      private void division_Click(object sender, EventArgs e)
      {
          operacion = "/";
          numero1 = double.Parse(Pantalla.Text);
          limpiaPantalla = true;
      }

      private void cuadrado_Click(object sender, EventArgs e)
      {
          numero1 = double.Parse(Pantalla.Text);
          resultado = numero1 * numero1;
          Pantalla.Text = resultado.ToString();
          limpiaPantalla = true;
      }


      private void raiz_Click(object sender, EventArgs e)
      {
          numero1 = double.Parse(Pantalla.Text);
          resultado = Math.Sqrt(numero1);
          Pantalla.Text = resultado.ToString();
          limpiaPantalla = true;
      }

      private void igual_Click(object sender, EventArgs e)
      {
          numero2 = double.Parse(Pantalla.Text);
          if (operacion == "+")
          {
              resultado = numero1 + numero2;
              Pantalla.Text = resultado.ToString();
              limpiaPantalla = true;
          }
          if (operacion == "-")
          {
              resultado = numero1 - numero2;
              Pantalla.Text = resultado.ToString();
              limpiaPantalla = true;
          }
          if (operacion == "*")
          {
              resultado = numero1 * numero2;
              Pantalla.Text = resultado.ToString();
              limpiaPantalla = true;
          }
          if (operacion == "/")
          {
              resultado = numero1 / numero2;
              Pantalla.Text = resultado.ToString();
              limpiaPantalla = true;
          }
          // fin de los botones de operaciones

          // botones especiles
      }

      private void atras_Click(object sender, EventArgs e)
      {
          int x = 0;
          borrado = Pantalla.Text;
          x = borrado.Length - 1;
          borrado = borrado.Substring(0, x);
          Pantalla.Text = borrado;


          if (Pantalla.Text == "")
          {
              Pantalla.Text = "0";
              limpiaPantalla = true;
          }
          if (Pantalla.Text == "-")
          {
              Pantalla.Text = "0";
              limpiaPantalla = true;
          }
      }

      private void borrar_Click(object sender, EventArgs e)
      {
          Pantalla.Text = "0";
          numero1 = 0;
          numero2 = 0;
          limpiaPantalla = true;

      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
          this.Close();
      }

       


    }
}
