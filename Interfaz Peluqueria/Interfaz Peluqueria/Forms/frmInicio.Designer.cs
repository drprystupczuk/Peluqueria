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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tablaMultiUso = new System.Windows.Forms.DataGridView();
            this.cmdCumples = new System.Windows.Forms.Button();
            this.cmdAvisos = new System.Windows.Forms.Button();
            this.cmdAvisosManana = new System.Windows.Forms.Button();
            this.cmdCumplesManana = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.peluqueriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMultiUso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaDataSetBindingSource)).BeginInit();
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
            // tablaMultiUso
            // 
            this.tablaMultiUso.AllowUserToAddRows = false;
            this.tablaMultiUso.AllowUserToDeleteRows = false;
            this.tablaMultiUso.AllowUserToOrderColumns = true;
            this.tablaMultiUso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMultiUso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaMultiUso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMultiUso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMultiUso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaMultiUso.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMultiUso.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaMultiUso.Location = new System.Drawing.Point(18, 184);
            this.tablaMultiUso.Name = "tablaMultiUso";
            this.tablaMultiUso.ReadOnly = true;
            this.tablaMultiUso.RowHeadersVisible = false;
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.tablaMultiUso.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaMultiUso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMultiUso.Size = new System.Drawing.Size(582, 228);
            this.tablaMultiUso.TabIndex = 2;
            // 
            // cmdCumples
            // 
            this.cmdCumples.BackColor = System.Drawing.Color.Transparent;
            this.cmdCumples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCumples.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumples.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumples.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumples.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdCumples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCumples.ForeColor = System.Drawing.Color.Black;
            this.cmdCumples.Location = new System.Drawing.Point(18, 155);
            this.cmdCumples.Name = "cmdCumples";
            this.cmdCumples.Size = new System.Drawing.Size(111, 23);
            this.cmdCumples.TabIndex = 3;
            this.cmdCumples.Text = "Cumpleaños HOY";
            this.cmdCumples.UseVisualStyleBackColor = false;
            this.cmdCumples.Click += new System.EventHandler(this.cmdCumples_Click);
            // 
            // cmdAvisos
            // 
            this.cmdAvisos.BackColor = System.Drawing.Color.Transparent;
            this.cmdAvisos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAvisos.ForeColor = System.Drawing.Color.Black;
            this.cmdAvisos.Location = new System.Drawing.Point(271, 155);
            this.cmdAvisos.Name = "cmdAvisos";
            this.cmdAvisos.Size = new System.Drawing.Size(111, 23);
            this.cmdAvisos.TabIndex = 5;
            this.cmdAvisos.Text = "Deben volver HOY";
            this.cmdAvisos.UseVisualStyleBackColor = false;
            this.cmdAvisos.Click += new System.EventHandler(this.cmdAvisos_Click);
            // 
            // cmdAvisosManana
            // 
            this.cmdAvisosManana.BackColor = System.Drawing.Color.Transparent;
            this.cmdAvisosManana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisosManana.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisosManana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisosManana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdAvisosManana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAvisosManana.ForeColor = System.Drawing.Color.Black;
            this.cmdAvisosManana.Location = new System.Drawing.Point(388, 155);
            this.cmdAvisosManana.Name = "cmdAvisosManana";
            this.cmdAvisosManana.Size = new System.Drawing.Size(129, 23);
            this.cmdAvisosManana.TabIndex = 6;
            this.cmdAvisosManana.Text = "Deben volver MAÑANA";
            this.cmdAvisosManana.UseVisualStyleBackColor = false;
            this.cmdAvisosManana.Click += new System.EventHandler(this.cmdAvisosManana_Click);
            // 
            // cmdCumplesManana
            // 
            this.cmdCumplesManana.BackColor = System.Drawing.Color.Transparent;
            this.cmdCumplesManana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdCumplesManana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumplesManana.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumplesManana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCumplesManana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdCumplesManana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCumplesManana.ForeColor = System.Drawing.Color.Black;
            this.cmdCumplesManana.Location = new System.Drawing.Point(137, 155);
            this.cmdCumplesManana.Name = "cmdCumplesManana";
            this.cmdCumplesManana.Size = new System.Drawing.Size(128, 23);
            this.cmdCumplesManana.TabIndex = 7;
            this.cmdCumplesManana.Text = "Cumpleaños MAÑANA";
            this.cmdCumplesManana.UseVisualStyleBackColor = false;
            this.cmdCumplesManana.Click += new System.EventHandler(this.cmdCumplesManana_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::Interfaz_Peluqueria.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(1029, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(325, 271);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.cmdCumplesManana);
            this.Controls.Add(this.cmdAvisosManana);
            this.Controls.Add(this.cmdAvisos);
            this.Controls.Add(this.cmdCumples);
            this.Controls.Add(this.tablaMultiUso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMultiUso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peluqueriaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.BindingSource peluqueriaDataSetBindingSource;
        private System.Windows.Forms.DataGridView tablaMultiUso;
        private System.Windows.Forms.Button cmdCumples;
        private System.Windows.Forms.Button cmdAvisos;
		private System.Windows.Forms.Button cmdAvisosManana;
		private System.Windows.Forms.Button cmdCumplesManana;
        private System.Windows.Forms.PictureBox picLogo;
    }
}