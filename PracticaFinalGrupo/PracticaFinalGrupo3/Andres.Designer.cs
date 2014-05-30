namespace PracticaFinalGrupo3
{
    partial class Andres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.rbDPersonales = new System.Windows.Forms.RadioButton();
            this.rbPrestamos = new System.Windows.Forms.RadioButton();
            this.rbMultas = new System.Windows.Forms.RadioButton();
            this.rbDatosLibros = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 557);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.09424F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consulta de datos de los socios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 9;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.Red;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConectar.Location = new System.Drawing.Point(12, 94);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(278, 67);
            this.buttonConectar.TabIndex = 10;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(17, 585);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(273, 66);
            this.buttonConsulta.TabIndex = 11;
            this.buttonConsulta.Text = "Consulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // rbDPersonales
            // 
            this.rbDPersonales.AutoSize = true;
            this.rbDPersonales.Checked = true;
            this.rbDPersonales.Location = new System.Drawing.Point(17, 256);
            this.rbDPersonales.Name = "rbDPersonales";
            this.rbDPersonales.Size = new System.Drawing.Size(206, 30);
            this.rbDPersonales.TabIndex = 12;
            this.rbDPersonales.TabStop = true;
            this.rbDPersonales.Text = "Datos personales";
            this.rbDPersonales.UseVisualStyleBackColor = true;
            this.rbDPersonales.CheckedChanged += new System.EventHandler(this.rbDPersonales_CheckedChanged);
            // 
            // rbPrestamos
            // 
            this.rbPrestamos.AutoSize = true;
            this.rbPrestamos.Location = new System.Drawing.Point(17, 220);
            this.rbPrestamos.Name = "rbPrestamos";
            this.rbPrestamos.Size = new System.Drawing.Size(142, 30);
            this.rbPrestamos.TabIndex = 13;
            this.rbPrestamos.Text = "Prestamos";
            this.rbPrestamos.UseVisualStyleBackColor = true;
            // 
            // rbMultas
            // 
            this.rbMultas.AutoSize = true;
            this.rbMultas.Location = new System.Drawing.Point(17, 292);
            this.rbMultas.Name = "rbMultas";
            this.rbMultas.Size = new System.Drawing.Size(131, 30);
            this.rbMultas.TabIndex = 14;
            this.rbMultas.Text = "Nº Multas";
            this.rbMultas.UseVisualStyleBackColor = true;
            // 
            // rbDatosLibros
            // 
            this.rbDatosLibros.AutoSize = true;
            this.rbDatosLibros.Location = new System.Drawing.Point(17, 328);
            this.rbDatosLibros.Name = "rbDatosLibros";
            this.rbDatosLibros.Size = new System.Drawing.Size(152, 30);
            this.rbDatosLibros.TabIndex = 15;
            this.rbDatosLibros.TabStop = true;
            this.rbDatosLibros.Text = "Datos libros";
            this.rbDatosLibros.UseVisualStyleBackColor = true;
            // 
            // Andres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 663);
            this.Controls.Add(this.rbDatosLibros);
            this.Controls.Add(this.rbMultas);
            this.Controls.Add(this.rbPrestamos);
            this.Controls.Add(this.rbDPersonales);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Andres";
            this.Text = "Consulta de datos de los socios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.RadioButton rbDPersonales;
        private System.Windows.Forms.RadioButton rbPrestamos;
        private System.Windows.Forms.RadioButton rbMultas;
        private System.Windows.Forms.RadioButton rbDatosLibros;
    }
}