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
    public partial class Form_Modificar_Articulo : Form
    {
        private int id;
        public Form_Modificar_Articulo(string id)
        {
            InitializeComponent();
            this.id = int.Parse(id);
        }

        private ConexionSQL conn = new ConexionSQL();

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Equals("") || textBox_Descripcion.Text.Equals("") || textBox_Precio.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por llenar, favor de verificar", "Advertencia !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id_proveedor = int.Parse(comboBox_Proveedor.SelectedValue.ToString());
                if (conn.modificar_articulo(textBox_Nombre.Text,textBox_Descripcion.Text,float.Parse(textBox_Precio.Text),id_proveedor,id) == 1)
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

        private void Form_Modificar_Articulo_Load(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)conn.llenar_combo_proveedores();
            comboBox_Proveedor.DataSource = ds.Tables[0];
            comboBox_Proveedor.ValueMember = "ID_Proveedor";
            comboBox_Proveedor.DisplayMember = "Nombre";
            // llenar todos los campos
            char delimitador = ',';
            string[] aux = conn.mostrar_articulo(id).Split(delimitador);

            textBox_Nombre.Text = aux[0];
            textBox_Descripcion.Text = aux[1];
            textBox_Precio.Text = aux[2];
            //textBox_Correo.Text = aux[3];
        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString() == ".") //permitir el '.' para usar decimales
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
