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
    public partial class Form_Modificar_Proveedor : Form
    {
        private int id;
        private ConexionSQL conn = new ConexionSQL();
        public Form_Modificar_Proveedor()
        {
            InitializeComponent();
        }
        public Form_Modificar_Proveedor(string id)
        {
            InitializeComponent();
            this.id = int.Parse(id);
        }
        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Equals("") || textBox_Agencia.Text.Equals("") || textBox_Telefono.Text.Equals("") || textBox_Correo.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por llenar, favor de verificar", "Advertencia !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                if (conn.modificar_proveedor(textBox_Nombre.Text, textBox_Agencia.Text, textBox_Telefono.Text, textBox_Correo.Text, id) == 1)
                {
                    MessageBox.Show("los datos se modificarion correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ejecuto el metodo para actualizar !", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Modificar_Proveedor_Load(object sender, EventArgs e)
        {
            char delimitador = ',';
            string[] aux = conn.mostrar_proveedor(id).Split(delimitador);

            textBox_Nombre.Text = aux[0];
            textBox_Agencia.Text = aux[1];
            textBox_Telefono.Text = aux[2];
            textBox_Correo.Text = aux[3];
        }
    }
}
