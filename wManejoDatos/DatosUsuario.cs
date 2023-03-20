using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using wManejoLogica;
using System.Xml;
using System.Xml.Linq;

namespace wManejoDatos
{
    public class DatosUsuario
    {
        public static int logear(string _user, string _clave) 
        {
            int idUsuario = 0;
            //uso del sp
            using (SqlConnection cn = new SqlConnection(Conexion.cn)) 
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_Login", cn);
                    cmd.Parameters.AddWithValue("Usuario", _user);
                    cmd.Parameters.AddWithValue("Clave", _clave);
                    cmd.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    idUsuario = Convert.ToInt32(cmd.Parameters["IdUsuario"].Value);
                }
                catch (Exception e) 
                {
                    idUsuario = 0;
                }
            }


                return idUsuario;
        }
        public static List<Menu> obtenerPermisos(int _PidUsuario)
        {
            List<Menu> Permisos = new List<Menu>();
            //uso del sp
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerPermisos", cn);
                    cmd.Parameters.AddWithValue("IdUsuario", _PidUsuario);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    XmlReader leerXml = cmd.ExecuteXmlReader();
                    while (leerXml.Read()) 
                    {
                        XDocument doc = XDocument.Load(leerXml);
                        if (doc.Element("PERMISOS") !=null )
                        {
                            Permisos = doc.Element("PERMISOS").Element("DetalleMenu") == null ? new List<Menu>() :
                                (from menu in doc.Element("PERMISOS").Element("DetalleMenu").Elements("Menu")
                                 select new Menu()
                                 {
                                     Nombre = menu.Element("Nombre").Value,
                                     Icono = menu.Element("Icono").Value,
                                     Formulario = menu.Element("NombreFormulario").Value
                                 }).ToList();
                        }
                    }
                }
                catch (Exception e)
                {
                    Permisos = new List<Menu>();
                }
            }


            return Permisos;
        }


        public static int guardarRiesgo(string _descrip, string _causa, string _consecuencia, string _estado,int _probabilidad, int _impacto)
        {
            int result = 0;
            //uso del sp
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GuardarRiesgo", cn);
                    cmd.Parameters.AddWithValue("Descripcion", _descrip);
                    cmd.Parameters.AddWithValue("Causa", _causa);
                    cmd.Parameters.AddWithValue("Consecuencias", _consecuencia);
                    cmd.Parameters.AddWithValue("Estado", _estado);
                    cmd.Parameters.AddWithValue("Probabilidad ", _probabilidad);
                    cmd.Parameters.AddWithValue("Impacto", _impacto);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    result = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e)
                {
                    result = 0;
                }
            }


            return result;
        }

        public static DataTable Priorizacion() 
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                //Crear una instancia de la clase SqlCommand
                using (SqlCommand cmd = new SqlCommand("sp_Priorizacion", cn))
                {
                    try
                    {
                        //Indicar que el tipo de comando a ejecutar es un procediento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        //adapter para llenar la datatble con el resultado del storeprocedure
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //abrir conexion
                        cn.Open();
                        //rellenar el objeto datable con el resultado del sp
                        da.Fill(dataTable);
                    }
                    catch (Exception e) 
                    {
                        dataTable = null;
                    }
                   
                }
               
            }


            return dataTable;
        }

    }
}
