namespace Pelu_Shifts
{
    partial class Turnero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnero));
            this.dg = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtservicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.DimGray;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.GridColor = System.Drawing.Color.LightGray;
            this.dg.Location = new System.Drawing.Point(360, 91);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(748, 324);
            this.dg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(186, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 71);
            this.label4.TabIndex = 8;
            this.label4.Text = "PELU-SHIFTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 6;
            // 
            // txtservicios
            // 
            this.txtservicios.BackColor = System.Drawing.Color.DimGray;
            this.txtservicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtservicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservicios.FormattingEnabled = true;
            this.txtservicios.Items.AddRange(new object[] {
            "Corte de pelo",
            "Peinados",
            "Alisado",
            "Lavado + Tintura",
            "Lavado + Brushing"});
            this.txtservicios.Location = new System.Drawing.Point(510, 504);
            this.txtservicios.Name = "txtservicios";
            this.txtservicios.Size = new System.Drawing.Size(121, 24);
            this.txtservicios.TabIndex = 2;
            this.txtservicios.TabStop = false;
            this.txtservicios.Text = "Servicios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dias";
            // 
            // txthorarios
            // 
            this.txthorarios.BackColor = System.Drawing.Color.DimGray;
            this.txthorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txthorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorarios.FormattingEnabled = true;
            this.txthorarios.Items.AddRange(new object[] {
            " 9:00hs ",
            "12:00hs",
            "17:00hs ",
            "20:00hs ",
            ""});
            this.txthorarios.Location = new System.Drawing.Point(789, 504);
            this.txthorarios.Name = "txthorarios";
            this.txthorarios.Size = new System.Drawing.Size(146, 24);
            this.txthorarios.TabIndex = 0;
            this.txthorarios.TabStop = false;
            this.txthorarios.Text = "Horarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(521, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(957, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reservar Turno";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(360, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 77);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peluqueros disponibles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "#Peluquero 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "#Peluquero 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Martes = peluquero 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Miercoles y Jueves= peluquero 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Viernes = peluquero 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Sabado= Dueño";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1073, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 66);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.Location = new System.Drawing.Point(360, 508);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(140, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(388, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 32);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cliente";
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.DimGray;
            this.txtDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.FormattingEnabled = true;
            this.txtDias.Items.AddRange(new object[] {
            "martes",
            "miercoles",
            "jueves",
            "viernes",
            "sabado"});
            this.txtDias.Location = new System.Drawing.Point(645, 504);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(121, 24);
            this.txtDias.TabIndex = 23;
            this.txtDias.TabStop = false;
            this.txtDias.Text = "Días";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(799, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "Horarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(55, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 303);
            this.panel2.TabIndex = 25;
            // 
            // Turnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 553);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthorarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtservicios);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turnero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelu-Shifts";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtservicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txthorarios;
        private System.Windows.Forms.ComboBox txtDias;
    }
}

