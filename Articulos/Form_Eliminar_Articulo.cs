using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Papema.Articulos
{
    public partial class Form_Eliminar_Articulo : Form
    {
        private int id;
        public Form_Eliminar_Articulo()
        {
            InitializeComponent();
        }
        public Form_Eliminar_Articulo(string id)
        {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();
            if (conn.borrar_articulo(id) == 1)
            {
                Console.WriteLine("Articulo Eliminado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar el articulo, revise que no existan conexiones " +
                    "con el mismo antes de borrar el registro", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
