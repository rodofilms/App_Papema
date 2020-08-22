using App_Papema.Controladores;
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
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private Controlador_Usuarios conn = new Controlador_Usuarios();

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Form_Modificar_Usuario form = new Form_Modificar_Usuario(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_modificar.Enabled = false;
            button_eliminar.Enabled = false;
            Form_Ver_Usuarios_Load(null, null);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Form_Eliminar_Usuario form = new Form_Eliminar_Usuario(textBox_ID.Text);
            form.ShowDialog();
            textBox_ID.Text = "";
            button_eliminar.Enabled = false;
            button_modificar.Enabled = false;
            Form_Ver_Usuarios_Load(null, null);
        }

        private void Form_Ver_Usuarios_Load(object sender, EventArgs e)
        {
            grid_Usuarios.DataSource = conn.ver_usuarios("");
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            grid_Usuarios.DataSource = conn.ver_usuarios(textBox_buscar.Text);
        }

        private void grid_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox_ID.Text = grid_Usuarios[0, e.RowIndex].Value.ToString();
                button_eliminar.Enabled = true;
                button_modificar.Enabled = true;
            }
        }
    }
}
