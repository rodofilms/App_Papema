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
    public partial class Form_Registrar_Usuario : Form
    {
        private ErrorProvider validarError = new ErrorProvider();
        public Form_Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volverAIniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                int aux = 0;
                //si todo es correcto, guardamos los datos
                ConexionSQL conn = new ConexionSQL();
                //vaciar el contenido del formulario en variables
                try
                {
                    string nivel = comboBox_TipoAcceso.SelectedItem.ToString();
                    //ejecutar metodo para agregar datos
                    aux = conn.agregar_usuario(textBox_Usuario.Text, textBox_Password.Text, nivel, textBox_Nombre.Text, textBox_Apellido.Text);

                    if (aux == 1)
                    {
                        MessageBox.Show("EL Usuario se agrego correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (aux == 2)
                    {
                        MessageBox.Show("El Usuario no se puede repetir", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }


        }

        private void textBox_Usuario_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                e.Cancel = true;
                textBox_Usuario.Select(0, textBox_Usuario.Text.Length);
                validarError.SetError(textBox_Usuario, "Debe introducir el nombre de usuario");
            }
        }

        private void textBox_Password_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                e.Cancel = true;
                textBox_Password.Select(0, textBox_Password.Text.Length);
                validarError.SetError(textBox_Password, "Debe introducir una contraseña");
            }
        }

        private void comboBox_TipoAcceso_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox_TipoAcceso.Text == "")
            {
                e.Cancel = true;
                comboBox_TipoAcceso.Select(0, comboBox_TipoAcceso.Text.Length);
                validarError.SetError(comboBox_TipoAcceso, "Debe introducir una contraseña");
            }
        }

        private void textBox_Nombre_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Nombre.Text == "")
            {
                e.Cancel = true;
                textBox_Nombre.Select(0, textBox_Nombre.Text.Length);
                validarError.SetError(textBox_Nombre, "Debe introducir una contraseña");
            }
        }
    }
}
