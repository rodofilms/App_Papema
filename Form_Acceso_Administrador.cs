using App_Papema.Punto_de_Venta;
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
    public partial class Form_Acceso_Administrador : Form
    {
        public Form_Acceso_Administrador()
        {
            InitializeComponent();
        }
        public Form_Acceso_Administrador(string nom)
        {
            InitializeComponent();
            this.label_nombre.Text = nom;
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuarios form = new Form_Usuarios();
            form.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Articulos form = new Form_Articulos();
            form.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Proveedores form = new Form_Proveedores();
            form.ShowDialog();
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Punto_De_Venta form = new Form_Punto_De_Venta();
            form.ShowDialog();
        }
    }
}
