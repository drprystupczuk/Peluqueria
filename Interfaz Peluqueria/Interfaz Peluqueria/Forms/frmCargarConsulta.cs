using System;
using System.Windows.Forms;

namespace Interfaz_Peluqueria
{
    public partial class frmCargarConsulta : Form
    {
        Conexion conexion;
        Cliente cliente;

        public frmCargarConsulta()
        {
            conexion = new Conexion();
            cliente = new Cliente();
            InitializeComponent();
        }
        private void Cargar_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.CenterToScreen();
            conexion.CargarTabla(tablaMultiUso, Transaccion.NOMBRE_TABLA);
            conexion.CargarClientes(cmbClientas, Cliente.NOMBRE_TABLA);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Transaccion transaccion = new Transaccion();
            try
            {
                if (Validacion())
                {
                    cliente = conexion.CargarClase(Convert.ToInt32(cmbClientas.SelectedValue));
                    transaccion.cCliente = cliente;
                    transaccion.pColor = txtColor.Text;
                    transaccion.pTratamiento = txtTratamiento.Text;
                    transaccion.pProductos = txtProductos.Text;
                    transaccion.pObservaciones = txtObservaciones.Text;   
                    transaccion.pFecTransaccion = DateTime.Today;

                    if (cbDebeVolver.Checked)
                    {
                        dtpDebeVolver.MinDate = DateTime.Today;

                        if (dtpDebeVolver.Value > DateTime.Today)
                        {
                            try
                            {
                                MessageBox.Show(conexion.InsertarAvisos(Convert.ToInt32(transaccion.cCliente.pDocumento), dtpDebeVolver.Value));
                                try
                                {
                                    MessageBox.Show(conexion.InsertarConsulta(transaccion.cCliente.pDocumento, transaccion.pFecTransaccion, transaccion.pObservaciones, transaccion.pTratamiento, transaccion.pColor, transaccion.pProductos));
                                    Limpiar();
                                }
                                catch (Exception)
                                {
                                    throw;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString(), "Error al cargar los datos");
                            }
                        }
                        else
                            MessageBox.Show("La fecha debe ser posterior al día de del tratamiento realizado");
                    }
                    else
                    {
                        MessageBox.Show(conexion.InsertarConsulta(transaccion.cCliente.pDocumento, transaccion.pFecTransaccion, transaccion.pObservaciones, transaccion.pTratamiento, transaccion.pColor, transaccion.pProductos));
                        Limpiar();
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error al cargar los datos");
            }            
        }
        private void Limpiar()
        {
            txtBuscarDNI.Text = "";
            txtColor.Text = "";
            txtObservaciones.Text = "";
            txtProductos.Text = "";
            txtTratamiento.Text ="";
            cbDebeVolver.Checked = false;
            dtpDebeVolver.Value = DateTime.Now;
            conexion.CargarTabla(tablaMultiUso, Transaccion.NOMBRE_TABLA);
        }
        private bool Validacion()
        {
            if (txtColor.Text == "")
            {
                MessageBox.Show("Ingrese color", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColor.Focus();
                return false;
            }
            else if (txtTratamiento.Text == "")
            {
                MessageBox.Show("Describa el tratamiento", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTratamiento.Focus();
                return false;
            }
            else if (txtProductos.Text == "")
            {
                MessageBox.Show("Ingrese productos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductos.Focus();
                return false;
            }
            else            
                return true;            
        }
        private void cbDebeVolver_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbDebeVolver.Checked)
            {
                dtpDebeVolver.Enabled = true;
                dtpDebeVolver.MinDate = DateTime.Today;
            }
            else         
                dtpDebeVolver.Enabled = false;
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            conexion.CargarTablaConParametros(tablaMultiUso, Convert.ToInt32(txtBuscarDNI.Text));
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))            
                e.Handled = false;            
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                 e.Handled = false;            
            else
                e.Handled = true;
        }
    }
}
