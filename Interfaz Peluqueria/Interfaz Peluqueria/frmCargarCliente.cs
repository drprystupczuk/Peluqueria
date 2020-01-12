using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Peluqueria
{
    public partial class frmCargarCliente : Form
    {
        Conexion con = new Conexion();
        Cliente c = new Cliente();
        public frmCargarCliente()
        {
            InitializeComponent();
        }

        private void Cargar_Load(object sender, EventArgs e)
        {
            con.cargarTabla(tablaMultiUso, "clientes");
            ManejoForm(true);
            
        }

        private void lblObservaciones_Click(object sender, EventArgs e)
        {

        }

        private void ManejoForm(bool a)
        {
            cmdModificar.Enabled = !a;
            cmdEliminar.Enabled = !a;
            btnRegistrar.Enabled = a;

            cmdModificar.Visible = !a;
            cmdEliminar.Visible = !a;
            btnRegistrar.Visible = a;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion())
                {
                    
                    c.pNombre = txtName.Text;
                    c.pApellido = txtApellido.Text;
                    c.pDireccion = txtDireccion.Text;
                    c.pFecNacimiento = dtpFechaCumple.Value;
                    c.pCorreo = txtCorreo.Text;
                    c.pTelefono = txtTelefono.Text;
                    c.pDocumento = Convert.ToInt32(txtDocumento.Text);

                    MessageBox.Show(con.InsertarClienta(c.pDocumento,c.pNombre, c.pApellido, c.pDireccion, c.pFecNacimiento, c.pCorreo, c.pTelefono));
                    //Limpiar();
                    con.cargarTabla(tablaMultiUso, "clientes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos");
            }

        }


        private void Limpiar()
        {
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text= "";
            txtName.Text = "";
            txtTelefono.Text = "";
            dtpFechaCumple.Value = DateTime.Now;
            txtDocumento.Text = "";
            txtBuscarDNI.Text = "";
            txtBuscarDNI.Enabled = true;
            ManejoForm(true);

        }
        private bool Validacion()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Ingrese el nombre para continuar", "Faltan datos", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido para continuar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una dirección para continuar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese un correo para poder contactarse", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese un teléfono para contactarse", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            else if (dtpFechaCumple.Value == DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaCumple.Focus();
                return false;
            }
            else if (txtDocumento.Text =="")
            {
                MessageBox.Show("El DNI es un campo obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }
            else if (con.personaRegistrada(Convert.ToInt32(txtDocumento.Text)) !=0)
            {
                MessageBox.Show("El DNI ya está registrado en la base de datos.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return false;
            }
            else
            {
                return true;
            }
            
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
            try
            {
                c.pNombre = txtName.Text;
                c.pApellido = txtApellido.Text;
                c.pDireccion = txtDireccion.Text;
                c.pFecNacimiento = dtpFechaCumple.Value;
                c.pCorreo = txtCorreo.Text;
                c.pTelefono = txtTelefono.Text;
                c.pDocumento = Convert.ToInt32(txtDocumento.Text);

                MessageBox.Show(con.ModificarCliente(Convert.ToInt32(txtBuscarDNI.Text),c.pDocumento, c.pNombre, c.pApellido, c.pDireccion, c.pFecNacimiento, c.pCorreo, c.pTelefono));
               
                con.cargarTabla(tablaMultiUso, "clientes");
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "No se pudo modificar");
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(con.EliminarCliente(Convert.ToInt32(txtBuscarDNI.Text)));
                con.cargarTabla(tablaMultiUso, "clientes");
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "No se pudo eliminar");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            ManejoForm(true);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                con.cargarTextBox(Convert.ToInt32(txtBuscarDNI.Text), txtName, txtApellido, txtDireccion, txtCorreo, txtTelefono, dtpFechaCumple, txtDocumento);
                ManejoForm(false);
                txtBuscarDNI.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "No se encontró una clienta que corresponda con el D.N.I");
            }
        }

        
    }
}
