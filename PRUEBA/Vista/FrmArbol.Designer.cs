namespace PRUEBA.Vista
{
    partial class FrmArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArbol));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNivel = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarHijo = new System.Windows.Forms.Button();
            this.tbNodoHijo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvInnovatec = new System.Windows.Forms.TreeView();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.tbNodoRaiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tbNivel
            // 
            this.tbNivel.BackColor = System.Drawing.Color.White;
            this.tbNivel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNivel.Location = new System.Drawing.Point(388, 262);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(115, 22);
            this.tbNivel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nivel del nodo:";
            // 
            // btnNivel
            // 
            this.btnNivel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel.Location = new System.Drawing.Point(512, 252);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(75, 39);
            this.btnNivel.TabIndex = 23;
            this.btnNivel.Text = "Mostrar Nivel";
            this.btnNivel.UseVisualStyleBackColor = true;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(451, 306);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(106, 39);
            this.btnContar.TabIndex = 26;
            this.btnContar.Text = "Contar Nodos";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(512, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(388, 220);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(115, 22);
            this.tbBuscar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nodo a buscar:";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.Location = new System.Drawing.Point(324, 306);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(106, 39);
            this.btnRecorrer.TabIndex = 25;
            this.btnRecorrer.Text = "Recorrer Árbol";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jerarquía:";
            // 
            // btnAgregarHijo
            // 
            this.btnAgregarHijo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHijo.Location = new System.Drawing.Point(512, 176);
            this.btnAgregarHijo.Name = "btnAgregarHijo";
            this.btnAgregarHijo.Size = new System.Drawing.Size(75, 26);
            this.btnAgregarHijo.TabIndex = 18;
            this.btnAgregarHijo.Text = "Agregar";
            this.btnAgregarHijo.UseVisualStyleBackColor = true;
            this.btnAgregarHijo.Click += new System.EventHandler(this.btnAgregarHijo_Click);
            // 
            // tbNodoHijo
            // 
            this.tbNodoHijo.BackColor = System.Drawing.Color.White;
            this.tbNodoHijo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodoHijo.Location = new System.Drawing.Point(361, 180);
            this.tbNodoHijo.Name = "tbNodoHijo";
            this.tbNodoHijo.Size = new System.Drawing.Size(145, 22);
            this.tbNodoHijo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nodo Hijo:";
            // 
            // tvInnovatec
            // 
            this.tvInnovatec.BackColor = System.Drawing.Color.White;
            this.tvInnovatec.Location = new System.Drawing.Point(23, 34);
            this.tvInnovatec.Name = "tvInnovatec";
            this.tvInnovatec.Size = new System.Drawing.Size(255, 313);
            this.tvInnovatec.TabIndex = 27;
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRaiz.Location = new System.Drawing.Point(512, 141);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(75, 26);
            this.btnAgregarRaiz.TabIndex = 15;
            this.btnAgregarRaiz.Text = "Agregar";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // tbNodoRaiz
            // 
            this.tbNodoRaiz.BackColor = System.Drawing.Color.White;
            this.tbNodoRaiz.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNodoRaiz.Location = new System.Drawing.Point(361, 145);
            this.tbNodoRaiz.Name = "tbNodoRaiz";
            this.tbNodoRaiz.Size = new System.Drawing.Size(145, 22);
            this.tbNodoRaiz.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nodo Raíz:";
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbNivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNivel);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarHijo);
            this.Controls.Add(this.tbNodoHijo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvInnovatec);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.tbNodoRaiz);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parque Tecnológico Innovatec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarHijo;
        private System.Windows.Forms.TextBox tbNodoHijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvInnovatec;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.TextBox tbNodoRaiz;
        private System.Windows.Forms.Label label1;
    }
}