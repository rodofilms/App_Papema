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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button_Acceder_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();
            if(textBox_User.Text == "" || textBox_Pass.Text == "")
            {
                MessageBox.Show("Debe Introducir su Usuario y Contraseña","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                char delimitador = ',';
                string[] aux = conn.acceder(textBox_User.Text, textBox_Pass.Text).Split(delimitador);
                if (aux[0].Equals("Admin"))
                {
                    //MessageBox.Show("Accedio Administrador: "+aux[0]+"  "+aux[1]);
                    Form_Acceso_Administrador form = new Form_Acceso_Administrador(aux[1]);
                    form.Show();
                    this.Close();
                }
                else if (aux[0].Equals("User"))
                {
                    MessageBox.Show("Accedio Usuario");
                }
                else if (aux[0].Equals("Fail_Pass"))
                {
                    MessageBox.Show("Contraseña/Usuario Incorrectos!", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(aux[0].Equals("Fail"))
                {
                    MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario form = new Form_RegistrarUsuario();
            form.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca form = new Acerca();
            form.Show();
        }
    }
}
