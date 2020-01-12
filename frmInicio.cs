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
    public partial class frmInicio : Form
    {
        //atributos
        
        Form frmConsultas = new Form();
        

        static public int altoPantalla;
        static public int anchoPantalla;

        //constructor
        public frmInicio()
        {
            anchoPantalla = Screen.PrimaryScreen.Bounds.Width;
            altoPantalla = Screen.PrimaryScreen.Bounds.Height;

            
            
            InitializeComponent();
        }




        //metodos
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            
            frmCarga fCarga = new frmCarga();
            fCarga.Show();
            fCarga.SetBounds(0, 0,anchoPantalla,altoPantalla);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, anchoPantalla,altoPantalla);
        }
    }
}
