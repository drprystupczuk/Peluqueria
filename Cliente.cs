using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Interfaz_Peluqueria
{
    class Cliente
    {

        //atributos
        int idCliente;
        string nombre;
        string apellido;
        string direccion;
        DateTime fecNac;
        string correo;
        string tel;



        //Constructor de la clase
        public Cliente()
        {
            idCliente = 0;
            nombre = "";
            apellido = "";
            direccion = "";
            fecNac = DateTime.Today;
            correo = "";
            tel = "";
        }

        //Public SET//GET//

        public int pIdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
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
            set { fecNac = value; }
            get { return fecNac; }
        }

        public string pCorreo
        {
            set { correo = value; }
            get { return correo; }
        }

        public string pTelefono
        {
            set { tel = value; }
            get { return tel; }
        }


    }
}
