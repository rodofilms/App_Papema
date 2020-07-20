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

        private ConexionSQL conn = new ConexionSQL();

        private void button_modificar_Click(object sender, EventArgs e)
        {

        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            grid_Proveedores.DataSource = conn.ver_proveedores("");
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
