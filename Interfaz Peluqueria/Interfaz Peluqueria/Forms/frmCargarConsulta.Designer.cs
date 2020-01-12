namespace Interfaz_Peluqueria
{
    partial class frmCargarConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbClientas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaMultiUso = new System.Windows.Forms.DataGridView();
            this.cbDebeVolver = new System.Windows.Forms.CheckBox();
            this.dtpDebeVolver = new System.Windows.Forms.DateTimePicker();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbConsultas = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMultiUso)).BeginInit();
            this.gpbConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Cliente:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(31, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(31, 99);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(78, 13);
            this.lblTratamiento.TabIndex = 3;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(31, 142);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(68, 13);
            this.lblProductos.TabIndex = 4;
            this.lblProductos.Text = "Productos:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(31, 206);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(95, 13);
            this.lblObservaciones.TabIndex = 5;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(137, 74);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(453, 19);
            this.txtColor.TabIndex = 1;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(137, 99);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(453, 34);
            this.txtTratamiento.TabIndex = 2;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(137, 142);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(453, 43);
            this.txtProductos.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(137, 206);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(453, 53);
            this.txtObservaciones.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(140, 325);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Cargar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbClientas
            // 
            this.cmbClientas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbClientas.Location = new System.Drawing.Point(137, 47);
            this.cmbClientas.MaxDropDownItems = 100;
            this.cmbClientas.Name = "cmbClientas";
            this.cmbClientas.Size = new System.Drawing.Size(221, 21);
            this.cmbClientas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cargar nueva consulta";
            // 
            // tablaMultiUso
            // 
            this.tablaMultiUso.AllowUserToAddRows = false;
            this.tablaMultiUso.AllowUserToDeleteRows = false;
            this.tablaMultiUso.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaMultiUso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tablaMultiUso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMultiUso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaMultiUso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMultiUso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMultiUso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMultiUso.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMultiUso.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaMultiUso.Location = new System.Drawing.Point(34, 372);
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
            this.tablaMultiUso.Size = new System.Drawing.Size(725, 250);
            this.tablaMultiUso.TabIndex = 23;
            // 
            // cbDebeVolver
            // 
            this.cbDebeVolver.AutoSize = true;
            this.cbDebeVolver.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbDebeVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDebeVolver.Location = new System.Drawing.Point(140, 282);
            this.cbDebeVolver.Name = "cbDebeVolver";
            this.cbDebeVolver.Size = new System.Drawing.Size(95, 17);
            this.cbDebeVolver.TabIndex = 25;
            this.cbDebeVolver.TabStop = false;
            this.cbDebeVolver.Text = "Debe volver";
            this.cbDebeVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDebeVolver.UseVisualStyleBackColor = true;
            this.cbDebeVolver.CheckedChanged += new System.EventHandler(this.cbDebeVolver_CheckedChanged_1);
            // 
            // dtpDebeVolver
            // 
            this.dtpDebeVolver.Enabled = false;
            this.dtpDebeVolver.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebeVolver.Location = new System.Drawing.Point(265, 279);
            this.dtpDebeVolver.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDebeVolver.MinDate = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dtpDebeVolver.Name = "dtpDebeVolver";
            this.dtpDebeVolver.Size = new System.Drawing.Size(93, 20);
            this.dtpDebeVolver.TabIndex = 26;
            this.dtpDebeVolver.Value = new System.DateTime(2018, 10, 1, 23, 20, 3, 0);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(73, 132);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 23);
            this.cmdCancelar.TabIndex = 28;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(73, 88);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(95, 23);
            this.cmdBuscar.TabIndex = 27;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(73, 39);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(95, 20);
            this.txtBuscarDNI.TabIndex = 27;
            this.txtBuscarDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDNI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "DNI:";
            // 
            // gpbConsultas
            // 
            this.gpbConsultas.Controls.Add(this.txtBuscarDNI);
            this.gpbConsultas.Controls.Add(this.cmdCancelar);
            this.gpbConsultas.Controls.Add(this.label1);
            this.gpbConsultas.Controls.Add(this.cmdBuscar);
            this.gpbConsultas.Location = new System.Drawing.Point(633, 74);
            this.gpbConsultas.Name = "gpbConsultas";
            this.gpbConsultas.Size = new System.Drawing.Size(222, 185);
            this.gpbConsultas.TabIndex = 30;
            this.gpbConsultas.TabStop = false;
            this.gpbConsultas.Text = "¿Qué uso por ultima vez?";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::Interfaz_Peluqueria.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(1029, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(325, 271);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 31;
            this.picLogo.TabStop = false;
            // 
            // frmCargarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.gpbConsultas);
            this.Controls.Add(this.dtpDebeVolver);
            this.Controls.Add(this.cbDebeVolver);
            this.Controls.Add(this.tablaMultiUso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarConsulta";
            this.Text = "Cargar";
            this.Load += new System.EventHandler(this.Cargar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMultiUso)).EndInit();
            this.gpbConsultas.ResumeLayout(false);
            this.gpbConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbClientas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaMultiUso;
        private System.Windows.Forms.CheckBox cbDebeVolver;
        private System.Windows.Forms.DateTimePicker dtpDebeVolver;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbConsultas;
        private System.Windows.Forms.PictureBox picLogo;
    }
}