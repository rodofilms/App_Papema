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

namespace App_Papema.Articulos
{
    public partial class Form_Registrar_Articulo : Form
    {
        public Form_Registrar_Articulo()
        {
            InitializeComponent();
        }

        private Controlador_Articulos conn = new Controlador_Articulos();

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Equals("") || textBox_Descripcion.Text.Equals("") || textBox_Precio.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por llenar, favor de verificar", "Advertencia !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int aux = 0;

                //Obtener ID del comboBox proveedores
                int id_proveedor = int.Parse(comboBox_Proveedor.SelectedValue.ToString());
                try
                {
                    //ejecutar metodo para agregar datos
                    aux = conn.agregar_articulo(textBox_Nombre.Text,textBox_Descripcion.Text,float.Parse(textBox_Precio.Text),id_proveedor);

                    if (aux == 1)
                    {
                        MessageBox.Show("EL Articulo se agrego correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (aux == 2)
                    {
                        MessageBox.Show("El Articulo no se puede repetir", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Ha Ocurrido un error", "Peligro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique todos los campos", "Peligro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Registrar_Articulo_Load(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)conn.llenar_combo_proveedores();
            comboBox_Proveedor.DataSource = ds.Tables[0];
            comboBox_Proveedor.ValueMember = "ID_Proveedor";
            comboBox_Proveedor.DisplayMember = "Nombre";
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
