using System;
using System.Windows.Forms;

namespace Interfaz_Peluqueria
{
    public partial class frmCargarCliente : Form
    {
        Conexion conexion = new Conexion();
        Cliente cliente = new Cliente();
        public frmCargarCliente()
        {
            InitializeComponent();
        }
        private void Cargar_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.CenterToScreen();
            conexion.CargarTabla(tablaMultiUso, Cliente.NOMBRE_TABLA);
            ManejoForm(true);
        }
        private void ManejoForm(bool enabled)
        {
            cmdModificar.Enabled = !enabled;
            cmdEliminar.Enabled = !enabled;
            btnRegistrar.Enabled = enabled;

            cmdModificar.Visible = !enabled;
            cmdEliminar.Visible = !enabled;
            btnRegistrar.Visible = enabled;
            txtBuscarDNI.Enabled = enabled;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion())
                {
                    cliente.pNombre = txtName.Text;
                    cliente.pApellido = txtApellido.Text;
                    cliente.pDireccion = txtDireccion.Text;
                    cliente.pFecNacimiento = dtpFechaCumple.Value;
                    cliente.pCorreo = txtCorreo.Text;
                    cliente.pTelefono = txtTelefono.Text;
                    cliente.pDocumento = Convert.ToInt32(txtDocumento.Text);

                    MessageBox.Show(conexion.InsertarCliente(cliente.pDocumento, cliente.pNombre, cliente.pApellido, cliente.pDireccion, cliente.pFecNacimiento, cliente.pCorreo, cliente.pTelefono));

                    conexion.CargarTabla(tablaMultiUso, Cliente.NOMBRE_TABLA);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos");
            }

        }
        private void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtName.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            dtpFechaCumple.Value = DateTime.Today;
            txtDocumento.Text = string.Empty;
            txtBuscarDNI.Text = string.Empty;
            ManejoForm(true);
        }
        private bool Validacion()
        {
            dtpFechaCumple.MaxDate = DateTime.Today;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Ingrese el nombre para continuar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido para continuar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese una dirección para continuar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo para poder contactarse", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un teléfono para contactarse", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            if (dtpFechaCumple.Value >= DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaCumple.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("El DNI es un campo obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }

            if (conexion.PersonaRegistrada(Convert.ToInt32(txtDocumento.Text)))
            {
                MessageBox.Show("El DNI ya está registrado en la base de datos.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }

            return true;
        }
        #region Control KeyPress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar el cliente " + txtName.Text + " ?", "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cliente.pNombre = txtName.Text;
                    cliente.pApellido = txtApellido.Text;
                    cliente.pDireccion = txtDireccion.Text;
                    cliente.pFecNacimiento = dtpFechaCumple.Value;
                    cliente.pCorreo = txtCorreo.Text;
                    cliente.pTelefono = txtTelefono.Text;
                    cliente.pDocumento = Convert.ToInt32(txtDocumento.Text);

                    MessageBox.Show(conexion.ModificarCliente(Convert.ToInt32(txtBuscarDNI.Text), cliente.pDocumento, cliente.pNombre, cliente.pApellido, cliente.pDireccion, cliente.pFecNacimiento, cliente.pCorreo, cliente.pTelefono));

                    conexion.CargarTabla(tablaMultiUso, "clientes");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "No se pudo modificar");
                }
            }
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el cliente " + txtName.Text + " ?", "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show(conexion.EliminarCliente(Convert.ToInt32(txtBuscarDNI.Text)));
                    conexion.CargarTabla(tablaMultiUso, "clientes");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "No se pudo eliminar");
                }
            }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.CargarTextBox(Convert.ToInt32(txtBuscarDNI.Text), txtName, txtApellido, txtDireccion, txtCorreo, txtTelefono, dtpFechaCumple, txtDocumento);
                ManejoForm(!string.IsNullOrEmpty(txtApellido.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "No se encontró una clienta que corresponda con el D.N.I");
                Limpiar();
            }
        }
    }
}
