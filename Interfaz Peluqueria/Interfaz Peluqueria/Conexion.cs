using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;        //Bases de datos en general
using System.Windows.Forms;     //para poder usar el message box dentro de la clase


namespace Interfaz_Peluqueria
{
    class Conexion
    {
        OleDbConnection conexion;   //conexion
        OleDbCommand comando;       //consulta sql
        OleDbDataAdapter da;
        OleDbDataReader dr;


        DataTable dtabla;
        DataColumn dc;



        public Conexion()
        {
            try
            {
                conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Users\diegoprystu\PROYECTOS\Visual Studio\pryPeluquería\pryPeluqueria V1.0\Peluqueria.mdb");
                conexion.Open();
                MessageBox.Show("Entraste a la base");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());

            }

        }


        public string InsertarConsulta(int doc, DateTime fec_tra, string obs, string trat, string col, string prod)
        {
            try
            {
                comando = new OleDbCommand
                    ("Insert into Transacciones(documento,fecha,observaciones,tratamiento,color,productos)" +
                    "values(" + doc + ",'" + fec_tra + "','" + obs + "','" + trat + "','" + col + "','" + prod + "')", conexion
                    );

                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }


        public string InsertarClienta(int doc, string nom, string ape, string dir, DateTime feconexionac, string correo, string tel)
        {
            try
            {
                comando = new OleDbCommand
                    (
                    "Insert into Clientes(documento,nom_cliente,ape_cliente,direccion,fec_nac_C,correo_cliente,tel_cliente)" +
                    "values('" + doc + "','" + nom + "','" + ape + "','" + dir + "','" + feconexionac + "','" + correo + "','" + tel + "')", conexion
                    );
                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }

        public void cargarTabla(DataGridView dgv, string tabla)
        {
            comando = new OleDbCommand();
            comando.Connection = conexion;
            try
            {
                comando.CommandType = CommandType.Text; //EL COMANDO SQL ES TEXTUAL 
                switch (tabla)
                {
                    case "avisos":
                        comando.CommandText = "select nom_cliente+' '+ape_cliente as Clientas, correo_cliente Correo,tel_cliente Teléfono, fecha_aviso 'Debe volver' from Clientes c, Avisos a where c.documento = a.documento";
                        break;
                    case "clientes":
                        comando.CommandText = "SELECT documento as DNI, nom_cliente+' '+ape_cliente as Clientas,direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono from clientes";
                        break;
                    case "transacciones":
                        comando.CommandText = "Select nom_cliente+' '+ape_cliente as Clientas, correo_cliente as Correo,tel_cliente as Teléfono, fecha_aviso as 'Debe volver'from Clientes c, Avisos a where (c.documento = a.documento)";
                        break;
                    case "cumpleaños":
                        comando.CommandText = "Select nom_cliente + ' ' + ape_cliente as Clientas, Direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono from clientes where (day(fec_nac_C) = DAY(date())) and (MONTH(fec_nac_C) = MONTH(DATE()))";
                        break;
                    default:
                        break;
                }

                dtabla = new DataTable();
                dtabla.Load(comando.ExecuteReader()); //CARGO LA TABLA leyendo la consulta anterior                
                dgv.DataSource = dtabla;               //se pasa a la grilla el datatable
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden obtener los datos de la base de datos: " + ex.Message.ToString());
            }
        }



        public void llenarTextBox(TextBox txtName, TextBox txtApe, TextBox dire, TextBox correo, TextBox tel, DateTimePicker nacim)
        {
            try
            {
                comando = new OleDbCommand("Select * from Clientes where ", conexion);
            }
            catch (Exception ex)
            {

                throw;
            }
        }






        #region validacion 
        public int personaRegistrada(int doc)
        {
            int contador = 0;
            try
            {
                comando = new OleDbCommand("Select * from Clientes where documento=" + doc + "", conexion);
                comando.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo hacer la consulta: " + ex.ToString());
            }
            return contador;
        }

        #endregion
    }
}



