using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPeluquería
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.pNombre = txtName.Text;
                c.pApellido = txtApellido.Text;
                c.pFecNacimiento = dtpFechaCumple.Value;
                c.pColor = txtColor.Text;
                c.pTratamiento = txtTratamiento.Text;
                c.pProductos = txtProductos.Text;
                c.pObservaciones = txtObservaciones.Text;


                MessageBox.Show("Cliente cargado de manera exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error al cargar los datos");
            }
            


        }
    }
}
