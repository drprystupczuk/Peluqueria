using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace pryPeluquería
{
    class Cliente
    {

        //atributos
        string nombre;
        string apellido;
        DateTime fecNacimiento;
        string color;
        string tratamiento;
        string productos;
        string observaciones;


        //Constructor de la clase
        public Cliente()
        {
            nombre = "";
            apellido = "";
            fecNacimiento = DateTime.Today;
            color = "";
            tratamiento = "";
            productos = "";
            observaciones = "";
        }

        //Public SET//GET//
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string pApellido
        {
            set { apellido= value; }
            get { return apellido; }
        }

        public DateTime pFecNacimiento
        {
            set { fecNacimiento = value; }
            get { return fecNacimiento; }
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





    }
}
