using App_Papema.Articulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Papema
{
    public partial class Form_Articulos : Form
    {
        public Form_Articulos()
        {
            InitializeComponent();
        }

        private ConexionSQL conn = new ConexionSQL();

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Form_Modificar_Articulo form = new Form_Modificar_Articulo(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_modificar.Enabled = false;
            button_eliminar.Enabled = false;
            Form_Articulos_Load(null, null);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Form_Eliminar_Articulo form = new Form_Eliminar_Articulo(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_eliminar.Enabled = false;
            button_modificar.Enabled = false;
            Form_Articulos_Load(null, null);
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Form_Registrar_Articulo form = new Form_Registrar_Articulo();
            form.ShowDialog();
            Form_Articulos_Load(null, null);
        }

        private void Form_Articulos_Load(object sender, EventArgs e)
        {
            grid_Articulos.DataSource = conn.ver_articulos("");
        }

        private void grid_Articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox_ID.Text = grid_Articulos[0, e.RowIndex].Value.ToString();
                button_eliminar.Enabled = true;
                button_modificar.Enabled = true;
            }
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            grid_Articulos.DataSource = conn.ver_articulos(textBox_buscar.Text);
        }
    }
}
