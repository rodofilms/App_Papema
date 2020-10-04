using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Papema.Controladores
{
    class Controlador_Ventas : ConexionSQL
    {
        public Controlador_Ventas()
        {

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
                string cadenaSQL = "select Articulos.ID_Articulos,Articulos.Nombre,Articulos.Precio,Proveedores.Nombre as 'Proveedor'" +
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
        public int iniciar_venta(string fecha,float total)
        {
            int id_venta = 0;
            try
            {
                this.conexion.Open();
                SqlCommand comando = new SqlCommand("sp_agregar_venta", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date)).Value = fecha;
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.Add("@id_venta", SqlDbType.Int).Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                id_venta = int.Parse(comando.Parameters["@id_venta"].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al iniciar la venta: " + ex.Message);
            }
            finally
            {
                this.conexion.Close();
            }
            
            return id_venta;
        }
        public int actulizar_venta()
        {
            return 0;
        }

        public int eliminar_venta(int id)
        {
            int aux = 0;
            try
            {
                this.conexion.Open();
                string cadena = "delete from Ventas where ID_Venta = @codigo";
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
                Console.WriteLine("Error al ejecutar las sentecias SQL en el metodo eliminar venta");
            }
            finally
            {
                this.conexion.Close();
                Console.WriteLine("Se cerro la conexion");
            }

            return aux;
        }

        public int terminar_venta()
        {
            return 0;
        }
    }
}
