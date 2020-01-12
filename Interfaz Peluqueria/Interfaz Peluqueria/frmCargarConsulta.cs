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
    public partial class frmCargarConsulta : Form
    {
        Conexion con;
        Cliente c;

        public frmCargarConsulta()
        {
            con = new Conexion();
            c = new Cliente();
            InitializeComponent();
        }

        private void Cargar_Load(object sender, EventArgs e)
        {
            
            con.cargarTabla(tablaMultiUso, "transacciones");
            con.cargarClientes(cmbClientas, "Clientes");
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Transaccion t = new Transaccion();

            try
            {
                if (Validacion())
                {
                    c = con.cargarClase(Convert.ToInt32(cmbClientas.SelectedValue));
                    t.cCli = c;
                    t.pColor = txtColor.Text;
                    t.pTratamiento = txtTratamiento.Text;
                    t.pProductos = txtProductos.Text;
                    t.pObservaciones = txtObservaciones.Text;   
                    t.pFecTransaccion = DateTime.Today;

                    MessageBox.Show(con.InsertarConsulta(t.cCli.pDocumento, t.pFecTransaccion, t.pObservaciones, t.pTratamiento, t.pColor, t.pProductos));

                    if (cbDebeVolver.Checked) //Si debe volver
                    {
                        dtpDebeVolver.MinDate = DateTime.Today;
                        if (dtpDebeVolver.Value > DateTime.Today)//Y la fecha es despues de hoy
                        {
                            try
                            {
                                MessageBox.Show(con.InsertarAvisos(Convert.ToInt32(t.cCli.pDocumento), t.pFecTransaccion));
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message.ToString(), "Error al cargar los datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha debe ser posterior al día de del tratamiento realizado");
                        }
                        
                    }
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
            txtTratamiento.Text ="";
            cbDebeVolver.Checked = false;
            dtpDebeVolver.Value = DateTime.Now;
            con.cargarTabla(tablaMultiUso, "transacciones");
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
            {
                return true;
            }
        }

        private void cmbClientas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDebeVolver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDebeVolver_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbDebeVolver.Checked == true)
            {
                dtpDebeVolver.Enabled = true;
            }

            if (cbDebeVolver.Checked == false)
            {
                dtpDebeVolver.Enabled = false;
            }

        }
    }
}
