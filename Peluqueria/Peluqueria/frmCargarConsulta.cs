using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peluqueria
{
    public partial class frmCargarConsulta : Form
    {
        Conexion con;

        public frmCargarConsulta()
        {
            con = new Conexion();
            InitializeComponent();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Transaccion t = new Transaccion();

            try
            {
                if (Validacion())
                {
                    //t.cCli = c;
                    t.pColor = txtColor.Text;
                    t.pTratamiento = txtTratamiento.Text;
                    t.pProductos = txtProductos.Text;
                    t.pObservaciones = txtObservaciones.Text;
                    //t.pFecTransaccion = 

                    MessageBox.Show(con.InsertarConsulta(t.cCli.pDocumento, DateTime.Now, t.pObservaciones, t.pTratamiento, t.pColor, t.pProductos));
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
            txtColor.Text = "";
            txtObservaciones.Text = "";
            txtProductos.Text = "";
            txtTratamiento.Text = "";
            cmbClientas.SelectedIndex = -1;
        }
        private bool Validacion()
        {
            if (cmbClientas.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una clienta", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClientas.Focus();
                return false;
            }
            else if (txtColor.Text == "")
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
            {
                return true;
            }
        }


        private void frmCargarConsulta_Load_1(object sender, EventArgs e)
        {
            con.cargarTabla(tablaMultiUso, "transacciones");
        }
    }
}
