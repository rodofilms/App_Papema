using App_Papema.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Papema
{
    public partial class Form_Modificar_Usuario : Form
    {
        private int id;
        private Controlador_Usuarios conn = new Controlador_Usuarios();
        public Form_Modificar_Usuario()
        {
            InitializeComponent();
        }
        public Form_Modificar_Usuario(string id)
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
            string nivel = comboBox_TipoAcceso.SelectedItem.ToString();
            if (conn.modificar_usuario(textBox_Usuario.Text, textBox_Password.Text, nivel, textBox_Nombre.Text, textBox_Apellido.Text, id)==1)
            {
                MessageBox.Show("los datos se modificarion correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha Ocurrido un error", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Modificar_Usuario_Load(object sender, EventArgs e)
        {
            char delimitador = ',';
            string[] aux = conn.mostrar_usuario(id).Split(delimitador);

            textBox_Usuario.Text = aux[0];
            textBox_Password.Text = aux[1];
            comboBox_TipoAcceso.Text = aux[2];
            textBox_Nombre.Text = aux[3];
            textBox_Apellido.Text = aux[4];
            
        }
    }
}
