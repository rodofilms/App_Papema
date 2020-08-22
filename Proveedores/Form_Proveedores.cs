using App_Papema.Controladores;
using App_Papema.Proveedores;
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
    public partial class Form_Proveedores : Form
    {
        public Form_Proveedores()
        {
            InitializeComponent();
        }

        private Controlador_Proveedores conn = new Controlador_Proveedores();

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Form_Modificar_Proveedor form = new Form_Modificar_Proveedor(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_modificar.Enabled = false;
            button_eliminar.Enabled = false;
            Form_Proveedores_Load(null, null);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Form_Eliminar_Proveedor form = new Form_Eliminar_Proveedor(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_eliminar.Enabled = false;
            button_modificar.Enabled = false;
            Form_Proveedores_Load(null, null);
        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            grid_Proveedores.DataSource = conn.ver_proveedores("");
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            grid_Proveedores.DataSource = conn.ver_proveedores(textBox_buscar.Text);
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Form_Registrar_Proveedor form = new Form_Registrar_Proveedor();
            form.ShowDialog();
            Form_Proveedores_Load(null, null);
        }

        private void grid_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox_ID.Text = grid_Proveedores[0, e.RowIndex].Value.ToString();
                button_eliminar.Enabled = true;
                button_modificar.Enabled = true;
            }
        }
    }
}
