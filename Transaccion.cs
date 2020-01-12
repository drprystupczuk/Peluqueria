using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Peluqueria
{
    class Transaccion
    {
        //atributos

        Cliente cli;
        //Empleado emp;
        string color;
        string tratamiento;
        string productos;
        string observaciones;
        DateTime fecTransaccion;


        //Constructor de la clase
        public Transaccion()
        {
            cli = null;
            color = "";
            tratamiento ="";
            productos = "";
            observaciones = "";
            fecTransaccion = DateTime.Today;
        }

        //Public SET//GET//
        public Cliente cCli
        {
            set { cli = value; }
            get { return cli; }
        }
        public string pColor
        {
            set { color = value; }
            get { return color; }
        }

        public string pTratamiento
        {
            set { tratamiento = value; }
            get { return tratamiento; }
        }

        public string pProductos
        {
            set { productos = value; }
            get { return productos; }
        }

        public string pObservaciones
        {
            set { observaciones = value; }
            get { return observaciones; }
        }

        public DateTime pFecTransaccion
        {
            set { fecTransaccion = value; }
            get { return fecTransaccion; }
        }

    }
}
