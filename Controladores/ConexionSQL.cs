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
        private SqlConnection conexion;

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
                string cadena = "select Usuario, Password, Tipo_Acceso, Nombre from Usuarios " +
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

        public int agregar_usuario(string usuario, string pass, string nivel, string nombre, string apellido)
        {
            int b = 0;
            try
            {
                this.conexion.Open();

                SqlCommand comando = new SqlCommand("sp_agregar_usuarios", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@User", usuario);
                comando.Parameters.AddWithValue("@Pass", pass);
                comando.Parameters.AddWithValue("@Tip", nivel);
                comando.Parameters.AddWithValue("@Name", nombre);
                comando.Parameters.AddWithValue("@Ape", apellido);

                comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;


                /*
                this.conexion.Open();
                string cadena = "insert into Usuarios(Usuario,Password,Tipo_Acceso,Nombre,Apellido) " +
                    "values (@usuario,@pass,@nivel,@nombre,@ape)";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@usuario", SqlDbType.NVarChar);
                comando.Parameters.Add("@pass", SqlDbType.NVarChar);
                comando.Parameters.Add("@nivel", SqlDbType.NVarChar);
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar);
                comando.Parameters.Add("@ape", SqlDbType.NVarChar);
                //le asignamos el valor al parametro que mandaremos al sql server
                comando.Parameters["@usuario"].Value = usuario;
                comando.Parameters["@pass"].Value = pass;
                comando.Parameters["@nivel"].Value = nivel;
                comando.Parameters["@nombre"].Value = nombre;
                comando.Parameters["@ape"].Value = apellido;
                //ejecutamos todas las instrucciones sql
                */
               
                if (comando.ExecuteNonQuery() != 0 && comando.Parameters["@salida"].Value.ToString().Equals("1"))
                {
                    b = 1;
                    Console.WriteLine("Los datos se guardaron correctamente");
                }
                else if (comando.Parameters["@salida"].Value.ToString().Equals("0"))
                {
                    b = 2;
                    Console.WriteLine("El usuario no se puede repetir");
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al agregar datos: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return b;
        }

        public object ver_usuarios(string buscar)
        {
            DataSet ds = new DataSet();
            DataView dv = new DataView();
            SqlDataAdapter da;

            try
            {
                this.conexion.Open();
                // cadena con select para mostrar los registros
                string cadenaSQL = "select * from Usuarios";
                da = new SqlDataAdapter(cadenaSQL, this.conexion);
                da.Fill(ds);
                dv = new DataView();
                dv.Table = ds.Tables[0];
                //esta linea facilitara la busqueda de los datos
                dv.RowFilter = "nombre LIKE '%" + buscar + "%'";
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR en la conexion: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return dv;
        }
        
        public int borrar_usuario(int id)
        {
            int aux = 0;
            try
            {
                this.conexion.Open();
                string cadena = "delete from Usuarios where ID_Usuario = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = id;
                
                if (comando.ExecuteNonQuery() == 1)
                {
                    aux = 1;
                }
                else
                {
                    Console.WriteLine("No se ha podido eliminar el registro");
                    aux = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al ejecutar las sentecias SQL en el metodo borrar_usuario");
            }
            finally
            {
                this.conexion.Close();
                Console.WriteLine("Se cerro la conexion");
            }

            return aux;
        }

        public int modificar_usuario(string usuario, string pass, string nivel, string nombre, string apellido, int id)
        {
            int b = 0;
            try
            {
                this.conexion.Open();
                string cadena = "update Usuarios set " +
                    "Usuario = @usuario, " +
                    "Password = @pass, " +
                    "Tipo_Acceso = @nivel, " +
                    "Nombre = @nombre, " +
                    "Apellido = @ape " +
                    "where ID_Usuario = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@usuario", SqlDbType.NVarChar);
                comando.Parameters.Add("@pass", SqlDbType.NVarChar);
                comando.Parameters.Add("@nivel", SqlDbType.NVarChar);
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar);
                comando.Parameters.Add("@ape", SqlDbType.NVarChar);
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                //le asignamos el valor al parametro que mandaremos al sql server
                comando.Parameters["@usuario"].Value = usuario;
                comando.Parameters["@pass"].Value = pass;
                comando.Parameters["@nivel"].Value = nivel;
                comando.Parameters["@nombre"].Value = nombre;
                comando.Parameters["@ape"].Value = apellido;
                comando.Parameters["@codigo"].Value = id;
                //ejecutamos todas las instrucciones sql

                if (comando.ExecuteNonQuery() != 0)
                {
                    b = 1;
                    Console.WriteLine("Los datos se guardaron correctamente");
                }
                else
                {
                    Console.WriteLine("Los datos no se guardaron");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error con el Update: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return b;
        }

        public string mostrar_usuario(int id)
        {
            string aux = "";
            try
            {
                this.conexion.Open();
                string cadena = "select * from Usuarios where ID_Usuario = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = id;
                
                //vaciar el registro en un objeto para poder verlos
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    aux = registro["Usuario"].ToString() + "," +
                    registro["Password"].ToString() + "," +
                    registro["Tipo_Acceso"].ToString() + "," +
                    registro["Nombre"].ToString() + "," +
                    registro["Apellido"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al mostrar los datos: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return aux;
        }

        public object ver_proveedores(string buscar)
        {
            DataSet ds = new DataSet();
            DataView dv = new DataView();
            SqlDataAdapter da;

            try
            {
                this.conexion.Open();
                // cadena con select para mostrar los registros
                string cadenaSQL = "select * from Proveedores";
                da = new SqlDataAdapter(cadenaSQL, this.conexion);
                da.Fill(ds);
                dv = new DataView();
                dv.Table = ds.Tables[0];
                //esta linea facilitara la busqueda de los datos
                dv.RowFilter = "Nombre LIKE '%" + buscar + "%'";
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR en la conexion: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return dv;
        }

        public int agregar_proveedor(string nombre,string agencia,string telefono,string correo)
        {
            int b = 0;
            try
            {
                this.conexion.Open();

                SqlCommand comando = new SqlCommand("sp_agregar_proveedor", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@name", nombre);
                comando.Parameters.AddWithValue("@agencia", agencia);
                comando.Parameters.AddWithValue("@tel", telefono);
                comando.Parameters.AddWithValue("@email", correo);

                comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;


                if (comando.ExecuteNonQuery() != 0 && comando.Parameters["@salida"].Value.ToString().Equals("1"))
                {
                    b = 1;
                    Console.WriteLine("Los datos se guardaron correctamente");
                }
                else if (comando.Parameters["@salida"].Value.ToString().Equals("0"))
                {
                    b = 2;
                    Console.WriteLine("El Proveedor no se puede repetir");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al agregar datos: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return b;
        }

        public int borrar_proveedor(int id)
        {
            int aux = 0;
            try
            {
                this.conexion.Open();
                string cadena = "delete from Proveedores where ID_Proveedor = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = id;

                if (comando.ExecuteNonQuery() == 1)
                {
                    aux = 1;
                }
                else
                {
                    Console.WriteLine("No se ha podido eliminar el registro");
                    aux = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al ejecutar las sentecias SQL en el metodo borrar_proveedor");
            }
            finally
            {
                this.conexion.Close();
                Console.WriteLine("Se cerro la conexion");
            }

            return aux;
        }

        public string mostrar_proveedor(int id)
        {
            string aux = "";
            try
            {
                this.conexion.Open();
                string cadena = "select * from Proveedores where ID_Proveedor = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = id;

                //vaciar el registro en un objeto para poder verlos
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    aux = registro["Nombre"].ToString() + "," +
                    registro["Agencia"].ToString() + "," +
                    registro["Telefono"].ToString() + "," +
                    registro["Correo"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al mostrar los datos: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return aux;
        }

        public int modificar_proveedor(string nombre,string agencia,string telefono,string correo,int id) 
        {
            int b = 0;
            try
            {
                this.conexion.Open();
                string cadena = "update Proveedores set " +
                    "Nombre = @nombre, " +
                    "Agencia = @agencia, " +
                    "Telefono = @telefono, " +
                    "Correo = @correo " +
                    "where ID_Proveedor = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@agencia", agencia);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@codigo", id);

                if (comando.ExecuteNonQuery() != 0)
                {
                    b = 1;
                    Console.WriteLine("Los datos se guardaron correctamente");
                }
                else
                {
                    Console.WriteLine("Los datos no se guardaron");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error con el Update: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return b;
        }
    }
}
