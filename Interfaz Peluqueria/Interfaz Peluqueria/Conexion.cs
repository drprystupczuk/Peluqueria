using System;
using System.ComponentModel;
using System.Drawing;
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

        string RutaBD;


        public Conexion()
        {
            try
            {
                RutaBD = Application.StartupPath + "/Peluqueria.mdb";
                conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+RutaBD);
                conexion.Open();
                //MessageBox.Show("Entraste a la base");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar al servidor: " + ex.ToString());

            }

        }

        #region Insertar en la BD
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

                return "Problemas al registrar la consulta: " + ex.ToString();
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
                comando.ExecuteNonQuery();
                return "Se registró la cliente correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al registrar la clienta: " + ex.Message.ToString();
            }
        }

        public string InsertarAvisos(int doc, DateTime fec_tra)
        {
            try
            {
                comando = new OleDbCommand
                    ("Insert into Avisos(Documento,fecha_aviso)" +
                    "values(" + doc + ",'" + fec_tra + "')", conexion
                    );

                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó un aviso para la fecha: "+fec_tra;

            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }

        #endregion

        #region traer valores al programa
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
                        comando.CommandText = "select nom_cliente+' '+ape_cliente as Clientas, correo_cliente as Correo,tel_cliente as Teléfono, fecha_aviso as 'Debe volver' from Clientes c, Avisos a where c.documento = a.documento";
                        break;
                    case "clientes":
                        comando.CommandText = "SELECT documento as DNI, nom_cliente+' '+ape_cliente as Clientas,direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono from clientes";
                        break;
                    case "transacciones":
                        comando.CommandText = "Select nom_cliente+' '+ape_cliente as Clientas, Fecha, Observaciones,Tratamiento,Color, Productos from Clientes c,Transacciones t where (c.documento = t.documento)";
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
        
        public void cargarClientes(ComboBox combo, string nomTabla)
        {
            // METODO que hace la conexion y muestra los datos de la base de datos en un combo box
            comando.Connection = conexion; //GENERAR la conexion
            comando.CommandType = CommandType.Text; //EL COMANDO SQL ES TEXTUAL 
            comando.CommandText = "select documento,nom_cliente+' '+ape_cliente+' - ('+str(documento)+')' from " + nomTabla; //COMANDO SQL de consulta 
            dtabla = new DataTable(); //INSTANCIAR tabla para cargar
            dtabla.Load(comando.ExecuteReader()); //CARGO LA TABLA leyendo la consulta anterior

            combo.DataSource = dtabla; //CARGO el combo con la tabla 
            combo.DisplayMember = dtabla.Columns[1].ColumnName.ToString(); // DISPLAY Lo visualiza
            combo.ValueMember = dtabla.Columns[0].ColumnName; // VALUE lo relaciona con los id
  
        }
        
        public void cargarTextBox(int doc,TextBox nom, TextBox ape, TextBox dire, TextBox correo, TextBox telefono, DateTimePicker cumple, TextBox txtdoc)
        {

            if (personaRegistrada(doc) != 0)
            {
                comando.Connection = conexion; //GENERAR la conexion
                comando.CommandType = CommandType.Text; //EL COMANDO SQL ES TEXTUAL 
                comando.CommandText = "Select * from Clientes where documento = " + doc;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtdoc.Text = Convert.ToString(dr.GetValue(0));
                    nom.Text = dr.GetString(1);
                    ape.Text = dr.GetString(2);
                    dire.Text = dr.GetString(3);
                    cumple.Value = dr.GetDateTime(4);
                    correo.Text = dr.GetString(5);
                    telefono.Text = dr.GetString(6);
                    
                }
                
                
                
                dr.Close();
            }
            else
            {
                MessageBox.Show("D.N.I no registrado");
            }
            
        }

        public Cliente cargarClase(int doc)
        {
            Cliente c = new Cliente();
            if (personaRegistrada(doc) != 0)
            {
                comando.Connection = conexion; //GENERAR la conexion
                comando.CommandType = CommandType.Text; //EL COMANDO SQL ES TEXTUAL 
                comando.CommandText = "Select * from Clientes where documento = " + doc;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    c.pDocumento = Convert.ToInt32(dr.GetValue(0));
                    c.pNombre = dr.GetString(1);
                    c.pApellido = dr.GetString(2);
                    c.pDireccion = dr.GetString(3);
                    c.pFecNacimiento = dr.GetDateTime(4);
                    c.pCorreo = dr.GetString(5);
                    c.pTelefono = dr.GetString(6);

                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("D.N.I no registrado");
            }
            return c;
        }


        #endregion

        #region Modificaciones y Bajas

        public string ModificarCliente(int viejodoc,int nuevodoc, string nom, string ape, string dir, DateTime feconexionac, string correo, string tel)
        {
            try
            {
                comando = new OleDbCommand
                    ("Update clientes set nom_cliente = '"+nom+"', ape_cliente = '"+ape+"',Direccion = '"+dir+"',fec_nac_C = '"+feconexionac+"',correo_cliente = '"+correo+"',tel_cliente = '"+tel+"',documento = "+nuevodoc+" where documento = "+viejodoc, conexion
                    );

                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se modificó el cliente de manera correcta";

            }

            catch (Exception ex)
            {

                return "Problemas al registrar la consulta: " + ex.ToString();
            }
        }

        public string EliminarCliente(int doc)
        {
            try
            {
                comando = new OleDbCommand
                    ("Delete from Clientes where documento ="+doc, conexion
                    );

                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se ha eliminado el cliente de la base de datos";

            }

            catch (Exception ex)
            {

                return "Problemas al eliminar el cliente: " + ex.ToString();
            }
        }



        #endregion
        #region validacion 
        public int personaRegistrada(int doc)
        {
            int contador = 0;
            try
            {
                comando.Connection = conexion; //GENERAR la conexion
                comando.CommandType = CommandType.Text; //EL COMANDO SQL ES TEXTUAL 
                comando.CommandText = "Select * from Clientes where documento = "+ doc;
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            return contador;
        }

        #endregion
    }
}



