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

namespace App_Papema.Proveedores
{
    public partial class Form_Eliminar_Proveedor : Form
    {
        private int id;
        public Form_Eliminar_Proveedor()
        {
            InitializeComponent();
        }
        public Form_Eliminar_Proveedor(string id)
        {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            Controlador_Proveedores conn = new Controlador_Proveedores();
            if (conn.borrar_proveedor(id) == 1)
            {
                Console.WriteLine("Proveedor Eliminado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar el proveedor, revise que no existan conexiones " +
                    "con el mismo antes de borrar el registro", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
