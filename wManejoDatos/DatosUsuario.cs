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
    }
}
