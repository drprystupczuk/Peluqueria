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
    public partial class frmInicio : Form
    {
        Conexion c;
        public frmInicio()
        {
            c = new Conexion();
            InitializeComponent();
            cmdCumples.BackColor = Color.DarkRed;
            cmdAvisos.BackColor = Color.Transparent;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

            c.cargarTabla(tablaMultiUso, "cumpleaños");
        }


        private void cmdCumples_Click(object sender, EventArgs e)
        {
            c.cargarTabla(tablaMultiUso, "cumpleaños");
            cmdCumples.BackColor = Color.DarkRed;
            cmdAvisos.BackColor = Color.Transparent;
        }

        private void cmdAvisos_Click(object sender, EventArgs e)
        {
            c.cargarTabla(tablaMultiUso, "avisos");
            cmdAvisos.BackColor = Color.DarkRed;
            cmdCumples.BackColor = Color.Transparent;
        }
    }
}
