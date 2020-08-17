using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Papema
{
    public partial class Form_Registrar_Proveedor : Form
    {
        public Form_Registrar_Proveedor()
        {
            InitializeComponent();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Equals("") || textBox_Agencia.Text.Equals("") || textBox_Telefono.Text.Equals("") || textBox_Correo.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por llenar, favor de verificar","Advertencia !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (ComprobarFormatoEmail(textBox_Correo.Text))
                {
                    int aux = 0;
                    ConexionSQL conn = new ConexionSQL();
                    try
                    {
                        //ejecutar metodo para agregar datos
                        aux = conn.agregar_proveedor(textBox_Nombre.Text, textBox_Agencia.Text, textBox_Telefono.Text, textBox_Correo.Text);

                        if (aux == 1)
                        {
                            MessageBox.Show("EL Proveedor se agrego correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (aux == 2)
                        {
                            MessageBox.Show("El Proveedor no se puede repetir", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("El Correo esta incorrecto", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion para limitar solo numeros en 
        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        //Exprecion regular para comprobar el formato de un email
        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
