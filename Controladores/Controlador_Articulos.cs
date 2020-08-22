using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Papema.Controladores
{
    class Controlador_Articulos : ConexionSQL
    {
        public Controlador_Articulos()
        {

        }
        public object llenar_combo_proveedores()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                this.conexion.Open();
                // cadena con select para mostrar los registros
                string cadenaSQL = "select * from Proveedores order by ID_Proveedor";
                da = new SqlDataAdapter(cadenaSQL, this.conexion);
                da.Fill(ds, "Proveedores");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR en la conexion: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }

            return ds;
        }

        public object ver_articulos(string buscar)
        {
            DataSet ds = new DataSet();
            DataView dv = new DataView();
            SqlDataAdapter da;

            try
            {
                this.conexion.Open();
                // cadena con select para mostrar los registros
                string cadenaSQL = "select Articulos.*,Proveedores.Nombre as 'Proveedor'" +
                    "from Articulos join Proveedores " +
                    "on Articulos.ID_Proveedor = Proveedores.ID_Proveedor";
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

        public int agregar_articulo(string nombre, string descr, float precio, int id_proveedor)
        {
            int b = 0;
            try
            {
                this.conexion.Open();

                SqlCommand comando = new SqlCommand("sp_agregar_articulo", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descr", descr);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@id_prov", id_proveedor);

                comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;


                if (comando.ExecuteNonQuery() != 0 && comando.Parameters["@salida"].Value.ToString().Equals("1"))
                {
                    b = 1;
                    Console.WriteLine("Los datos se guardaron correctamente");
                }
                else if (comando.Parameters["@salida"].Value.ToString().Equals("0"))
                {
                    b = 2;
                    Console.WriteLine("El Articulo no se puede repetir");
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

        public int borrar_articulo(int id)
        {
            int aux = 0;
            try
            {
                this.conexion.Open();
                string cadena = "delete from Articulos where ID_Articulos = @codigo";
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
                Console.WriteLine("Error al ejecutar las sentecias SQL en el metodo borrar_articulo");
            }
            finally
            {
                this.conexion.Close();
                Console.WriteLine("Se cerro la conexion");
            }

            return aux;
        }

        public string mostrar_articulo(int id)
        {
            string aux = "";
            try
            {
                this.conexion.Open();
                string cadena = "select * from Articulos where ID_Articulos = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //definimos el tipo de dato para cada parametro 
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = id;

                //vaciar el registro en un objeto para poder verlos
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    aux = registro["Nombre"].ToString() + "," +
                    registro["Descripcion"].ToString() + "," +
                    registro["Precio"].ToString() + "," +
                    registro["ID_Proveedor"].ToString();
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

        public int modificar_articulo(string nombre, string descripcion, float precio, int id_proveedor, int id)
        {
            int b = 0;
            try
            {
                this.conexion.Open();
                string cadena = "update Articulos set " +
                    "Nombre = @nombre, " +
                    "Descripcion = @descripcion, " +
                    "Precio = @precio, " +
                    "ID_Proveedor = @id_prov " +
                    "where ID_Articulos = @codigo";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@id_prov", id_proveedor);
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
