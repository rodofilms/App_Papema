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
    public partial class Form_Eliminar_Usuario : Form
    {
        private int id;
        public Form_Eliminar_Usuario()
        {
            InitializeComponent();
        }
        public Form_Eliminar_Usuario(string id)
        {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            Controlador_Usuarios conn = new Controlador_Usuarios();
            if (conn.borrar_usuario(id) == 1)
            {
                Console.WriteLine("Usuario Eliminado");
                this.Close();
            } 
            else
            {
                MessageBox.Show("Error al eliminar el usuario, revise que no existan conexiones " +
                    "con el mismo antes de borrar el registro", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
