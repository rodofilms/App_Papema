using App_Papema.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Papema
{
    class ConexionSQL
    {
        protected SqlConnection conexion;
        protected int ID_Session;
        public ConexionSQL()
        {
            conexion = new SqlConnection("server=G77588; database=papema; integrated security = true");
        }

        public string acceder(string user, string pass)
        {
            int b = 0;
            string salida = "Fail";
            string tipo_acceso = "", nombre = "";

            try
            {
                this.conexion.Open();
                string cadena = "select ID_Usuario, Usuario, Password, Tipo_Acceso, Nombre from Usuarios " +
                    "where Usuario = @user and Password = @pass";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@user", SqlDbType.NVarChar);
                comando.Parameters["@user"].Value = user;
                comando.Parameters.Add("@pass", SqlDbType.NVarChar);
                comando.Parameters["@pass"].Value = pass;

                //vaciar el registro en un objeto para poder verlos
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    //tomar el valor del tipo de acceso para poder acceder al correspondiente
                    Session_ID.Set_ID_Session(int.Parse(registro["ID_Usuario"].ToString()));
                    tipo_acceso = registro["Tipo_Acceso"].ToString();
                    nombre = registro["Nombre"].ToString();
                    
                    //comprobar el usuario y contraseña
                    if (registro["Usuario"].ToString() == user && registro["Password"].ToString() == pass)
                    {
                        b = 1;
                        break;
                    }
                }
                
                if (b == 1 && tipo_acceso == "Administrador")
                {
                    salida = "Admin" + "," + nombre; 
                }
                else if (b == 1 && tipo_acceso.Equals("Usuario"))
                {
                    salida = "User" + "," + nombre;
                } 
                else if (b==0)
                {
                    salida = "Fail_Pass";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error con el login: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();

            }

            return salida;

        }
        
    }
}
