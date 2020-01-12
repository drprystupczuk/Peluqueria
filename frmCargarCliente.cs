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
        public frmCargarCliente()
        {
            InitializeComponent();
        }

        private void Cargar_Load(object sender, EventArgs e)
        {

        }

        private void lblObservaciones_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();


            try
            {
                if (Validacion())
                {
                    //id es automatico
                    c.pNombre = txtName.Text;
                    c.pApellido = txtApellido.Text;
                    c.pDireccion = txtDireccion.Text;
                    c.pFecNacimiento = dtpFechaCumple.Value;
                    c.pCorreo = txtCorreo.Text;
                    c.pTelefono = txtTelefono.Text;

                    MessageBox.Show(con.InsertarClienta(c.pNombre, c.pApellido, c.pDireccion, c.pFecNacimiento, c.pCorreo, c.pTelefono));
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error al cargar los datos");
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
        #endregion
    }
}
