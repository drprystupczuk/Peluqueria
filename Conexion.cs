using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;              //para SQL
using System.Data.Sql;          //para SQL
using System.Data.SqlClient;    //para SQL
using System.Windows.Forms; //para poder usar el message box dentro de la clase

namespace Interfaz_Peluqueria
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        DataColumn dc;
        SqlDataAdapter da;
        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Peluqueria;Integrated Security=True");
                cn.Open();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: "+ex.ToString());
                
            }
        }


        public string InsertarConsulta(int doc,DateTime fec_tra,string obs,string trat,string col,string prod)
        {
            try
            {
                cmd = new SqlCommand
                    (
                    "Insert into Transacciones(documento,fecha,observaciones,tratamiento,color,productos)" +
                    "values("+doc+",'"+fec_tra+"','"+obs+ "','" + trat + "','" + col + "','" + prod + "')",cn
                    );
                cmd.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }


        public string InsertarClienta(int doc,string nom,string ape,string dir,DateTime fecnac,string correo,string tel)
        {
            try
            {
                cmd = new SqlCommand
                    (
                    "Insert into Clientes(documento,nom_cliente,ape_cliente,direccion,fec_nac_C,correo_cliente,tel_cliente)" +
                    "values('"+doc+"','" + nom + "','" + ape + "','" +dir + "','" + fecnac + "','" + correo + "','"+tel+"')", cn
                    );
                cmd.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }

        public void cargarTabla(DataGridView dgv,string tabla)
        {
            try
            {
                switch (tabla)
                {
                    case "avisos":
                        da = new SqlDataAdapter("select nom_cliente+' '+ape_cliente as Clientas, correo_cliente Correo,tel_cliente Teléfono, fecha_aviso 'Debe volver' from Clientes c, Avisos a where c.documento = a.documento", cn);   
                        break;
                    case "clientes":
                        da = new SqlDataAdapter("select documento DNI, nom_cliente+' '+ape_cliente as Clientas,direccion Direccion,fec_nac_C Nacimiento,correo_cliente Correo,tel_cliente Teléfono from clientes", cn);   
                        break;
                    case "transacciones":
                        da = new SqlDataAdapter("select c.documento DNI, nom_cliente+' '+ape_cliente as Clientas, fecha 'Última vez',observaciones Observaciones,tratamiento Tratamiento,color Color,productos Productos from Clientes c,Transacciones t where c.documento= t.documento", cn);  
                        break;
                    case "cumpleaños":
                        da = new SqlDataAdapter("select nom_cliente + ' ' + ape_cliente as Clientas, direccion Direccion, fec_nac_C Nacimiento, correo_cliente Correo, tel_cliente Teléfono from clientes where day(fec_nac_C) = DAY(getdate()) and MONTH(fec_nac_C) = MONTH(GETDATE())",cn);
                        break;
                    default:
                        break;
                }
                
                dt = new DataTable();
                da.Fill(dt);                    //se pasa la consulta al datatable
                dgv.DataSource = dt;            //se pasa a la grilla el datatable
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pueden cargar los avisos: "+ex.Message.ToString());
            }
        }



        public void llenarTextBox(TextBox txtName, TextBox txtApe, TextBox dire, TextBox correo, TextBox tel, DateTimePicker nacim)
        {
            try
            {
                cmd = new SqlCommand("Select * from Clientes where ", cn);
            }
            catch (Exception ex)
            {

                throw;
            }
        }






        #region validacion 
        public int personaRegistrada (int doc)
         {
             int contador = 0;
             try
             {
                 cmd = new SqlCommand("Select * from Clientes where documento=" + doc + "", cn);
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     contador++;
                 }
                 dr.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No se puedo hacer la consulta: "+ex.ToString());
             }
             return contador;
         }
         
        #endregion
    }
}
