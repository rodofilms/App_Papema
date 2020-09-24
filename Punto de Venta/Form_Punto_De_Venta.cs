using App_Papema.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Papema.Punto_de_Venta
{
    public partial class Form_Punto_De_Venta : Form
    {
        private Controlador_Ventas conn = new Controlador_Ventas();
        private string nombre;
        private float precio;
        private int cantidad;
        private int id_articulo;

        public Form_Punto_De_Venta()
        {
            InitializeComponent();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {

            grid_canasta.Rows.Add(id_articulo, nombre, precio, cantidad, precio*cantidad);
        }

        private void verArticulosToolStripMenuItem_ver_articulos_Click(object sender, EventArgs e)
        {

        }

        private void button_finalizar_compra_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Form_Punto_De_Venta_Load(object sender, EventArgs e)
        {
            grid_articulos.DataSource = conn.ver_articulos("");
            grid_canasta.Columns.Add("id", "ID");
            grid_canasta.Columns.Add("nombre", "Articulo");
            grid_canasta.Columns.Add("precio", "Precio");
            grid_canasta.Columns.Add("cantidad", "Cantidad");
            grid_canasta.Columns.Add("total", "Total");
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            grid_articulos.DataSource = conn.ver_articulos(textBox_buscar.Text);
        }

        private void grid_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_articulo = int.Parse(grid_articulos[0, e.RowIndex].Value.ToString());
                nombre = grid_articulos[1, e.RowIndex].Value.ToString();
                precio = float.Parse(grid_articulos[2, e.RowIndex].Value.ToString());
            }
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToShortDateString();
            int id_venta = conn.iniciar_venta(fecha, 0);
            if (id_venta != 0)
            {   
                button_agregar.Enabled = true;
                button_finalizar_compra.Enabled = true;
                MessageBox.Show("Venta Iniciada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_ID_Venta.Text = ""+id_venta;
            }
            else
            {
                MessageBox.Show("La venta no se inicio !", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void grid_canasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
