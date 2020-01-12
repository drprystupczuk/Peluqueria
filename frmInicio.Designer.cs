namespace Interfaz_Peluqueria
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.peluqueriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaCumpleaños = new System.Windows.Forms.DataGridView();
            this.tablaAvisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCumpleaños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.LightCoral;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Maroon;
            this.lblHora.Location = new System.Drawing.Point(4, 53);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(365, 83);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "HH:MM:SS";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.LightCoral;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.lblFecha.ForeColor = System.Drawing.Color.Maroon;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(167, 35);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "00/00/0000";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // tablaCumpleaños
            // 
            this.tablaCumpleaños.AllowUserToAddRows = false;
            this.tablaCumpleaños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCumpleaños.Location = new System.Drawing.Point(18, 189);
            this.tablaCumpleaños.Name = "tablaCumpleaños";
            this.tablaCumpleaños.ReadOnly = true;
            this.tablaCumpleaños.Size = new System.Drawing.Size(240, 150);
            this.tablaCumpleaños.TabIndex = 2;
            // 
            // tablaAvisos
            // 
            this.tablaAvisos.AllowUserToAddRows = false;
            this.tablaAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAvisos.Location = new System.Drawing.Point(374, 189);
            this.tablaAvisos.Name = "tablaAvisos";
            this.tablaAvisos.ReadOnly = true;
            this.tablaAvisos.Size = new System.Drawing.Size(240, 150);
            this.tablaAvisos.TabIndex = 3;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaAvisos);
            this.Controls.Add(this.tablaCumpleaños);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCumpleaños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAvisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.BindingSource peluqueriaDataSetBindingSource;
        private System.Windows.Forms.DataGridView tablaCumpleaños;
        private System.Windows.Forms.DataGridView tablaAvisos;
    }
}