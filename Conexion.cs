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

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Peluqueria;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Ingresó a la base de datos");
                  
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: "+ex.ToString());
                
            }
        }


        public string InsertarConsulta(int id_cli,DateTime fec_tra,string obs,string trat,string col,string prod)
        {
            try
            {
                cmd = new SqlCommand
                    (
                    "Insert into Transacciones(id_cliente,fecha,observaciones,tratamiento,color,productos)" +
                    "values("+id_cli+",'"+fec_tra+"','"+obs+ "','" + trat + "','" + col + "','" + prod + "')",cn
                    );
                cmd.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }


        public string InsertarClienta(string nom,string ape,string dir,DateTime fecnac,string correo,string tel)
        {
            try
            {
                cmd = new SqlCommand
                    (
                    "Insert into Clientes(nom_cliente,ape_cliente,direcion,fec_nac_C,correo_cliente,tel_cliente)" +
                    "values('" + nom + "','" + ape + "','" +dir + "','" + fecnac + "','" + correo + "','"+tel+"')", cn
                    );
                cmd.ExecuteNonQuery(); //para que se realice la sentencia sql
                return "Se cargó correctamente";
            }

            catch (Exception ex)
            {

                return "Problemas al cargar: " + ex.ToString();
            }
        }

        #region validacion innecesaria del tutorial
        /* public int personaRegistrada (int id)
         {
             int contador = 0;
             try
             {
                 cmd = new SqlCommand("Select * from Clientes where id_cliente=" + id + "", cn);
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
         */
        #endregion
    }
}
