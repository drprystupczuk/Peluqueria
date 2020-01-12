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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaMultiUso)).BeginInit();
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
            this.lblNombre.Text = "Clienta:";
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
            this.lblObservaciones.Location = new System.Drawing.Point(31, 170);
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
            this.txtColor.Size = new System.Drawing.Size(350, 19);
            this.txtColor.TabIndex = 1;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(137, 99);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(350, 34);
            this.txtTratamiento.TabIndex = 2;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(137, 142);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(350, 18);
            this.txtProductos.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(137, 170);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(350, 34);
            this.txtObservaciones.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(137, 262);
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
            this.cmbClientas.Size = new System.Drawing.Size(229, 21);
            this.cmbClientas.TabIndex = 0;
            this.cmbClientas.SelectedIndexChanged += new System.EventHandler(this.cmbClientas_SelectedIndexChanged);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaMultiUso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMultiUso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaMultiUso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tablaMultiUso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMultiUso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMultiUso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaMultiUso.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMultiUso.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaMultiUso.Location = new System.Drawing.Point(34, 300);
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
            this.tablaMultiUso.Size = new System.Drawing.Size(546, 134);
            this.tablaMultiUso.TabIndex = 23;
            // 
            // cbDebeVolver
            // 
            this.cbDebeVolver.AutoSize = true;
            this.cbDebeVolver.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbDebeVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDebeVolver.Location = new System.Drawing.Point(137, 219);
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
            this.dtpDebeVolver.Location = new System.Drawing.Point(262, 216);
            this.dtpDebeVolver.MinDate = new System.DateTime(2018, 10, 1, 23, 20, 3, 0);
            this.dtpDebeVolver.Name = "dtpDebeVolver";
            this.dtpDebeVolver.Size = new System.Drawing.Size(93, 20);
            this.dtpDebeVolver.TabIndex = 26;
            this.dtpDebeVolver.Value = new System.DateTime(2018, 10, 1, 23, 20, 3, 0);
            // 
            // frmCargarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(677, 464);
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
    }
}