using System;

namespace Interfaz_Peluqueria
{
    class Cliente
    {

        public const string NOMBRE_TABLA = "Clientes";

        int documento;
        string nombre;
        string apellido;
        string direccion;
        DateTime fechaNacimiento;
        string correo;
        string telefono;

        public Cliente()
        {
            documento = 0;
            nombre = "";
            apellido = "";
            direccion = "";
            fechaNacimiento = DateTime.Today;
            correo = "";
            telefono = "";
        }

        public int pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }
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

        public string pDireccion
        {
            set { direccion= value; }
            get { return direccion; }
        }
        public DateTime pFecNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public string pCorreo
        {
            set { correo = value; }
            get { return correo; }
        }

        public string pTelefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
    }
}
