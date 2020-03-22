using Interfaz_Peluqueria.Modelos;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Interfaz_Peluqueria
{
    class Conexion
    {
        //github test
        OleDbConnection conexion;   
        OleDbCommand comando;
        OleDbDataReader dr;
        DataTable dtabla;        

        string rutaBD;
        bool conectado;

        public Conexion()
        {
            try
            {
                rutaBD = Application.StartupPath + "/Peluqueria.accdb";
                conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaBD);
                conexion.Open();
                conectado = true;
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar al servidor: " + ex.Message.ToString());
            }
        }

        public void CloseConexion()
        {
            try
            {
                if (conectado)
                {
                    conexion.Close();
                    conectado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cierre de base de datos: " +ex.Message.ToString());
            }
        }
        public string InsertarConsulta(int documento, DateTime fechaTransaccion, string observaciones, string tratamiento, string color, string productos)
        {
            try
            {
                comando.CommandText = $"INSERT INTO {Transaccion.NOMBRE_TABLA} (documento,fecha,observaciones,tratamiento,color,productos) " +
                                        $"VALUES ({ documento}, '{fechaTransaccion}','{observaciones}','{tratamiento}','{color}','{productos}')";
                comando.ExecuteNonQuery();
                return "Se cargó correctamente";
                
            }
            catch (Exception ex)
            {
                return "Problemas al registrar la consulta: " + ex.Message.ToString();
            }
        }

        public string InsertarCliente(int documento, string nombreCliente, string apellidoCliente, string direccion, DateTime fechaNacimiento, string correo, string telefono)
        {
            try
            {
                comando.CommandText= $"INSERT INTO {Cliente.NOMBRE_TABLA} (documento,nom_cliente,ape_cliente,direccion,fec_nac_C,correo_cliente,tel_cliente)" +
                                       $"VALUES({documento},'{nombreCliente}','{apellidoCliente}','{direccion}','{fechaNacimiento}','{correo}','{telefono}')";
                comando.ExecuteNonQuery();

                return "Se registró el cliente correctamente";
            }
            catch (Exception ex)
            {
                return "Problemas al registrar el cliente: " + ex.Message.ToString();
            }
        }

        public string InsertarAvisos(int doc, DateTime fec_tra)
        {
            try
            {
                comando.CommandText = $"INSERT INTO {Aviso.NOMBRE_TABLA} (Documento,fecha_aviso) VALUES ({doc},'{fec_tra}')";
                comando.ExecuteNonQuery();
                return "Se cargó un aviso para la fecha: "+fec_tra;

            }
            catch (Exception ex)
            {
                return "Problemas al cargar: " + ex.Message.ToString();
            }
        }

        public void CargarTabla(DataGridView dgv, string tabla)
        {
            try
            {
                switch (tabla)
                {
                    case "avisos":
                        comando.CommandText = $"SELECT nom_cliente+' '+ape_cliente as Clientes,  correo_cliente as Correo, tel_cliente as Teléfono, fecha_aviso as 'Debe volver el día:' FROM {Cliente.NOMBRE_TABLA} c, {Aviso.NOMBRE_TABLA} a WHERE (c.documento = a.documento) and (day(fecha_aviso) = DAY(date()))";
                        break;
                    case Cliente.NOMBRE_TABLA:
                        comando.CommandText = $"SELECT documento as DNI, nom_cliente+' '+ape_cliente as Clientes,direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono FROM {Cliente.NOMBRE_TABLA}";
                        break;
                    case Transaccion.NOMBRE_TABLA:
                        comando.CommandText = $"SELECT nom_cliente+' '+ape_cliente as Clientes, Fecha, Observaciones,Tratamiento,Color, Productos FROM {Cliente.NOMBRE_TABLA} C,{Transaccion.NOMBRE_TABLA} T WHERE (c.documento = t.documento) order by fecha desc";
                        break;
                    case "cumpleaños":
                        comando.CommandText = $"SELECT nom_cliente + ' ' + ape_cliente as Clientes, Direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono FROM {Cliente.NOMBRE_TABLA} WHERE (day(fec_nac_C) = DAY(date())) and (MONTH(fec_nac_C) = MONTH(DATE()))";
                        break;
					case "cumpleañosManana":
						comando.CommandText = $"SELECT nom_cliente + ' ' + ape_cliente as Clientes, Direccion,fec_nac_C as Nacimiento,correo_cliente as Correo,tel_cliente as Teléfono FROM {Cliente.NOMBRE_TABLA} WHERE (day(fec_nac_C) = DAY(date())+1) and (MONTH(fec_nac_C) = MONTH(DATE()))";
						break;
					case "avisosManana":
						comando.CommandText = $"SELECT nom_cliente+' '+ape_cliente as Clientes,  correo_cliente as Correo, tel_cliente as Teléfono, fecha_aviso as 'Debe volver el día:' FROM {Cliente.NOMBRE_TABLA} c, {Aviso.NOMBRE_TABLA} a WHERE (c.documento = a.documento) and (day(fecha_aviso) = DAY(date())+1)";
						break;                   
                    default:
                        break;
                }

                dtabla = new DataTable();
                dtabla.Load(comando.ExecuteReader());                 
                dgv.DataSource = dtabla; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden obtener los datos de la base de datos: " + ex.Message.ToString());
            }
        }
        public void CargarTablaConParametros(DataGridView dgv,int dni)
        {
            if (PersonaRegistrada(dni))
            {
                comando.CommandText = $"SELECT nom_cliente+' '+ape_cliente as Clientes, Fecha, Observaciones, Tratamiento, Color, Productos FROM {Cliente.NOMBRE_TABLA} c, {Transaccion.NOMBRE_TABLA} t WHERE (c.documento = t.documento) and "+dni+" = t.documento ORDER BY fecha desc";
                dtabla = new DataTable();
                dtabla.Load(comando.ExecuteReader());
                dgv.DataSource = dtabla;
            }
            else            
                MessageBox.Show("D.N.I no registrado");
            
        }

        public void CargarClientes(ComboBox combo, string nombreTabla)
        {
            
            comando.CommandText = "SELECT documento,nom_cliente+' '+ape_cliente+' - ('+str(documento)+')' FROM " + nombreTabla;

            dtabla = new DataTable();
            dtabla.Load(comando.ExecuteReader()); 

            combo.DataSource = dtabla;
            combo.DisplayMember = dtabla.Columns[1].ColumnName.ToString(); 
            combo.ValueMember = dtabla.Columns[0].ColumnName;
        }
        
        public void CargarTextBox(int documento,TextBox txtNombre, TextBox txtApellido, TextBox txtDireccion, TextBox txtCorreo, TextBox txtTelefono, DateTimePicker cumple, TextBox txtDocumento)
        {

            if (PersonaRegistrada(documento))
            {
                comando.CommandText = $"SELECT * FROM {Cliente.NOMBRE_TABLA} WHERE documento = {documento}";
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtDocumento.Text = Convert.ToString(dr.GetValue(0));
                    txtNombre.Text = dr.GetString(1);
                    txtApellido.Text = dr.GetString(2);
                    txtDireccion.Text = dr.GetString(3);
                    cumple.Value = dr.GetDateTime(4);
                    txtCorreo.Text = dr.GetString(5);
                    txtTelefono.Text = dr.GetString(6);                    
                }
                dr.Close();
            }
            else            
                MessageBox.Show("D.N.I no registrado");             
        }

        public Cliente CargarClase(int documento)
        {
            Cliente cliente = new Cliente();
            if (PersonaRegistrada(documento))
            {
                comando.CommandText = "Select * from Clientes where documento = " + documento;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cliente.pDocumento = Convert.ToInt32(dr.GetValue(0));
                    cliente.pNombre = dr.GetString(1);
                    cliente.pApellido = dr.GetString(2);
                    cliente.pDireccion = dr.GetString(3);
                    cliente.pFecNacimiento = dr.GetDateTime(4);
                    cliente.pCorreo = dr.GetString(5);
                    cliente.pTelefono = dr.GetString(6);

                }
                dr.Close();
            }
            else            
                MessageBox.Show("D.N.I no registrado");
            
            return cliente;
        }

        public string ModificarCliente(int viejoDoc,int nuevodoc, string nom, string ape, string dir, DateTime feconexionac, string correo, string tel)
        {
            try
            {
                comando.CommandText = "Update clientes set nom_cliente = '" + nom+"', ape_cliente = '"+ape+"',Direccion = '"+dir+"',fec_nac_C = '"+feconexionac+"',correo_cliente = '"+correo+"',tel_cliente = '"+tel+"',documento = "+nuevodoc+" where documento = "+viejoDoc;

                comando.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se modificó el cliente de manera correcta";

            }

            catch (Exception ex)
            {
                return "Problemas al registrar la consulta: " + ex.Message.ToString();
            }
        }

        public string EliminarCliente(int documento)
        {
            try
            {
                comando.CommandText = $"DELETE FROM Clientes WHERE documento = {documento}";
                comando.ExecuteNonQuery();
                return "Se ha eliminado el cliente de la base de datos";

            }
            catch (Exception ex)
            {
                return "Problemas al eliminar el cliente: " + ex.Message.ToString();
            }
        }


        public bool PersonaRegistrada(int documento)
        {
            bool registrada = false;
            try
            {
                comando.CommandText = $"SELECT * FROM  {Cliente.NOMBRE_TABLA} WHERE documento = {documento}";
                dr = comando.ExecuteReader();
                if (dr.Read())
                    registrada = true;
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            return registrada;
        }
    }
}