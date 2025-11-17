namespace PRUEBA.Vista
{
    partial class FrmGrafo
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
            this.btnRutaCorta = new System.Windows.Forms.Button();
            this.lbRutaCorta = new System.Windows.Forms.ListBox();
            this.cmbFin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConexo = new System.Windows.Forms.Label();
            this.btnConexidad = new System.Windows.Forms.Button();
            this.lbAdyacencias = new System.Windows.Forms.ListBox();
            this.btnMostrarAd = new System.Windows.Forms.Button();
            this.btnAgregarConex = new System.Windows.Forms.Button();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRutaCorta
            // 
            this.btnRutaCorta.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaCorta.Location = new System.Drawing.Point(41, 431);
            this.btnRutaCorta.Name = "btnRutaCorta";
            this.btnRutaCorta.Size = new System.Drawing.Size(150, 38);
            this.btnRutaCorta.TabIndex = 40;
            this.btnRutaCorta.Text = "Calcular ruta más corta";
            this.btnRutaCorta.UseVisualStyleBackColor = true;
            this.btnRutaCorta.Click += new System.EventHandler(this.btnRutaCorta_Click);
            // 
            // lbRutaCorta
            // 
            this.lbRutaCorta.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutaCorta.FormattingEnabled = true;
            this.lbRutaCorta.ItemHeight = 14;
            this.lbRutaCorta.Location = new System.Drawing.Point(231, 366);
            this.lbRutaCorta.Name = "lbRutaCorta";
            this.lbRutaCorta.Size = new System.Drawing.Size(337, 88);
            this.lbRutaCorta.TabIndex = 41;
            // 
            // cmbFin
            // 
            this.cmbFin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFin.FormattingEnabled = true;
            this.cmbFin.Location = new System.Drawing.Point(63, 393);
            this.cmbFin.Name = "cmbFin";
            this.cmbFin.Size = new System.Drawing.Size(152, 22);
            this.cmbFin.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fin:";
            // 
            // cmbInicio
            // 
            this.cmbInicio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Location = new System.Drawing.Point(63, 353);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(152, 22);
            this.cmbInicio.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Inicio:";
            // 
            // lblConexo
            // 
            this.lblConexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConexo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexo.Location = new System.Drawing.Point(439, 237);
            this.lblConexo.Name = "lblConexo";
            this.lblConexo.Size = new System.Drawing.Size(129, 38);
            this.lblConexo.TabIndex = 35;
            this.lblConexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConexidad
            // 
            this.btnConexidad.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexidad.Location = new System.Drawing.Point(451, 180);
            this.btnConexidad.Name = "btnConexidad";
            this.btnConexidad.Size = new System.Drawing.Size(100, 40);
            this.btnConexidad.TabIndex = 34;
            this.btnConexidad.Text = "Verificar Conexidad";
            this.btnConexidad.UseVisualStyleBackColor = true;
            this.btnConexidad.Click += new System.EventHandler(this.btnConexidad_Click);
            // 
            // lbAdyacencias
            // 
            this.lbAdyacencias.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdyacencias.FormattingEnabled = true;
            this.lbAdyacencias.ItemHeight = 14;
            this.lbAdyacencias.Location = new System.Drawing.Point(15, 191);
            this.lbAdyacencias.Name = "lbAdyacencias";
            this.lbAdyacencias.Size = new System.Drawing.Size(390, 130);
            this.lbAdyacencias.TabIndex = 33;
            // 
            // btnMostrarAd
            // 
            this.btnMostrarAd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAd.Location = new System.Drawing.Point(51, 154);
            this.btnMostrarAd.Name = "btnMostrarAd";
            this.btnMostrarAd.Size = new System.Drawing.Size(135, 31);
            this.btnMostrarAd.TabIndex = 32;
            this.btnMostrarAd.Text = "Mostrar Adyacencias";
            this.btnMostrarAd.UseVisualStyleBackColor = true;
            this.btnMostrarAd.Click += new System.EventHandler(this.btnMostrarAd_Click);
            // 
            // btnAgregarConex
            // 
            this.btnAgregarConex.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConex.Location = new System.Drawing.Point(257, 100);
            this.btnAgregarConex.Name = "btnAgregarConex";
            this.btnAgregarConex.Size = new System.Drawing.Size(130, 32);
            this.btnAgregarConex.TabIndex = 31;
            this.btnAgregarConex.Text = "Agregar Conexión";
            this.btnAgregarConex.UseVisualStyleBackColor = true;
            this.btnAgregarConex.Click += new System.EventHandler(this.btnAgregarConex_Click);
            // 
            // nudDistancia
            // 
            this.nudDistancia.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDistancia.Location = new System.Drawing.Point(86, 107);
            this.nudDistancia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDistancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(151, 22);
            this.nudDistancia.TabIndex = 30;
            this.nudDistancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 29;
            this.label4.Text = "Distancia:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(344, 64);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 22);
            this.cmbDestino.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Edificio Destino:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(108, 64);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(129, 22);
            this.cmbOrigen.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Edificio Origen:";
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarE.Location = new System.Drawing.Point(330, 19);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarE.TabIndex = 24;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // tbEdificio
            // 
            this.tbEdificio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdificio.Location = new System.Drawing.Point(177, 21);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(147, 22);
            this.tbEdificio.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre del Edificio:";
            // 
            // pbGrafo
            // 
            this.pbGrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGrafo.Location = new System.Drawing.Point(602, 41);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(299, 386);
            this.pbGrafo.TabIndex = 42;
            this.pbGrafo.TabStop = false;
            this.pbGrafo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGrafo_Paint);
            this.pbGrafo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseDown);
            this.pbGrafo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseMove);
            this.pbGrafo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseUp);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Grafo:";
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 486);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbGrafo);
            this.Controls.Add(this.btnRutaCorta);
            this.Controls.Add(this.lbRutaCorta);
            this.Controls.Add(this.cmbFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblConexo);
            this.Controls.Add(this.btnConexidad);
            this.Controls.Add(this.lbAdyacencias);
            this.Controls.Add(this.btnMostrarAd);
            this.Controls.Add(this.btnAgregarConex);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.tbEdificio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parque Tecnológico Innovatec";
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRutaCorta;
        private System.Windows.Forms.ListBox lbRutaCorta;
        private System.Windows.Forms.ComboBox cmbFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConexo;
        private System.Windows.Forms.Button btnConexidad;
        private System.Windows.Forms.ListBox lbAdyacencias;
        private System.Windows.Forms.Button btnMostrarAd;
        private System.Windows.Forms.Button btnAgregarConex;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.Label label7;
    }
}