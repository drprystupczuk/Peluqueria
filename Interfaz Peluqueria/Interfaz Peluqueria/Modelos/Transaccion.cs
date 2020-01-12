using System;

namespace Interfaz_Peluqueria
{
    class Transaccion
    {
        public const string NOMBRE_TABLA = "Transacciones";

        Cliente cliente;
        //Empleado emp;
        string color;
        string tratamiento;
        string productos;
        string observaciones;
        DateTime fecTransaccion;

        public Transaccion()
        {
            cliente = null;
            color = "";
            tratamiento ="";
            productos = "";
            observaciones = "";
            fecTransaccion = DateTime.Today;
        }

        public Cliente cCliente
        {
            set { cliente = value; }
            get { return cliente; }
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
