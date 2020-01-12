using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interfaz_Peluqueria
{
    public partial class frmGenerico : Form
    {

        Conexion c = new Conexion();
        public frmGenerico()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.CenterToScreen();
            abrirFormHija(new frmInicio());
            btnSeleccionado(1);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        #region MetodosAuxiliares
            private void abrirFormHija(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

            private void btnSeleccionado(int elegido)
        {
            switch (elegido)
            {
                case 1:
                    btnInicio.BackColor = Color.DarkRed;       //On
                    btnCargar.BackColor = Color.Transparent;
                    btnCargarTrat.BackColor = Color.Transparent;
                    break;
                case 2:
                    btnInicio.BackColor = Color.Transparent;
                    btnCargar.BackColor = Color.DarkRed;    //On
                    btnCargarTrat.BackColor = Color.Transparent;
                    break;
                case 3:
                    btnInicio.BackColor = Color.Transparent;
                    btnCargar.BackColor = Color.Transparent;
                    btnCargarTrat.BackColor = Color.DarkRed;    //On
                    break;
                default:
                    btnInicio.BackColor = Color.DarkRed;       //On
                    btnCargar.BackColor = Color.Transparent;
                    btnCargarTrat.BackColor = Color.Transparent;
                    break;
            }
        }

        #endregion

        #region Navegacion
            private void btnCargar_Click(object sender, EventArgs e)
            {
                abrirFormHija(new frmCargarCliente());
                btnSeleccionado(2);
            }

            private void button1_Click(object sender, EventArgs e)
            {
                abrirFormHija(new frmInicio());
                btnSeleccionado(1);
            
            }

            private void btnCargarTrat_Click(object sender, EventArgs e)
            {
                abrirFormHija(new frmCargarConsulta());
                btnSeleccionado(3);
            }

            private void btnCerrar_Click(object sender, EventArgs e)
            {
                c.CloseConexion();
                Application.Exit();
            }







        #endregion

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
