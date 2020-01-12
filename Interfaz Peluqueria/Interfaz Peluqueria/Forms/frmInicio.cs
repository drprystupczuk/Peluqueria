using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz_Peluqueria
{
    public partial class frmInicio : Form
    {
        Conexion conexion;
        public frmInicio()
        {
            conexion = new Conexion();
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
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.CenterToScreen();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

            conexion.CargarTabla(tablaMultiUso, "cumpleaños");
        }


        private void cmdCumples_Click(object sender, EventArgs e)
        {
            conexion.CargarTabla(tablaMultiUso, "cumpleaños");

			cmdCumples.BackColor = Color.DarkRed;

			cmdAvisos.BackColor = Color.Transparent;
			cmdCumplesManana.BackColor = Color.Transparent;
			cmdAvisosManana.BackColor = Color.Transparent;
		}

        private void cmdAvisos_Click(object sender, EventArgs e)
        {
            conexion.CargarTabla(tablaMultiUso, "avisos");

			cmdAvisos.BackColor = Color.DarkRed;

			cmdCumples.BackColor = Color.Transparent;
			cmdCumplesManana.BackColor = Color.Transparent;
			cmdAvisosManana.BackColor = Color.Transparent;
		}

		private void cmdCumplesManana_Click ( object sender, EventArgs e )
		{
			conexion.CargarTabla(tablaMultiUso, "cumpleañosManana");

			cmdCumplesManana.BackColor = Color.DarkRed;

			cmdCumples.BackColor = Color.Transparent; 
			cmdAvisos.BackColor = Color.Transparent;
			cmdAvisosManana.BackColor = Color.Transparent;
		}

		private void cmdAvisosManana_Click ( object sender, EventArgs e )
		{
			conexion.CargarTabla(tablaMultiUso, "avisosManana");

			cmdAvisosManana.BackColor = Color.DarkRed;

			cmdCumples.BackColor = Color.Transparent;
			cmdAvisos.BackColor = Color.Transparent;
			cmdCumplesManana.BackColor = Color.Transparent;
		}
	}
}
