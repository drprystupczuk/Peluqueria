namespace Interfaz_Peluqueria
{
    partial class frmGenerico
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
            this.components = new System.ComponentModel.Container();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCargarTrat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenuVertical.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlBarraTitulo.Controls.Add(this.lblNombre);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 26);
            this.pnlBarraTitulo.TabIndex = 0;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(3, 5);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(155, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Peluqueria \'NOMBRE\'";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Interfaz_Peluqueria.Properties.Resources.minimizar__2_;
            this.pictureBox1.Location = new System.Drawing.Point(753, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Interfaz_Peluqueria.Properties.Resources.marca_de_prohibido;
            this.btnCerrar.Location = new System.Drawing.Point(777, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.IndianRed;
            this.pnlMenuVertical.Controls.Add(this.panel5);
            this.pnlMenuVertical.Controls.Add(this.btnCargarTrat);
            this.pnlMenuVertical.Controls.Add(this.pictureBox2);
            this.pnlMenuVertical.Controls.Add(this.pictureBox3);
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.btnInicio);
            this.pnlMenuVertical.Controls.Add(this.btnCargar);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 26);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(151, 424);
            this.pnlMenuVertical.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(1, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 23);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(-76, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 23);
            this.panel6.TabIndex = 2;
            // 
            // btnCargarTrat
            // 
            this.btnCargarTrat.BackColor = System.Drawing.Color.IndianRed;
            this.btnCargarTrat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarTrat.FlatAppearance.BorderSize = 0;
            this.btnCargarTrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCargarTrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarTrat.Image = global::Interfaz_Peluqueria.Properties.Resources.notas__2_;
            this.btnCargarTrat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarTrat.Location = new System.Drawing.Point(3, 137);
            this.btnCargarTrat.Name = "btnCargarTrat";
            this.btnCargarTrat.Size = new System.Drawing.Size(153, 23);
            this.btnCargarTrat.TabIndex = 7;
            this.btnCargarTrat.Text = "Tratamientos";
            this.btnCargarTrat.UseVisualStyleBackColor = false;
            this.btnCargarTrat.Click += new System.EventHandler(this.btnCargarTrat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Interfaz_Peluqueria.Properties.Resources.icons8_corte_de_pelo_de_coletas_filled_100;
            this.pictureBox2.Location = new System.Drawing.Point(74, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Interfaz_Peluqueria.Properties.Resources.logo_axel;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(1, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 23);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(-76, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 23);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 23);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(-76, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 23);
            this.panel2.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.IndianRed;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Image = global::Interfaz_Peluqueria.Properties.Resources.notas__2_;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(4, 79);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(153, 23);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Image = global::Interfaz_Peluqueria.Properties.Resources.notas__2_;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(4, 108);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Clientas";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.LightCoral;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(151, 26);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(649, 424);
            this.pnlContenedor.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // frmGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenuVertical.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCargarTrat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

