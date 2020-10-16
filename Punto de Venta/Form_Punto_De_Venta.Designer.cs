namespace App_Papema.Punto_de_Venta
{
    partial class Form_Punto_De_Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_canasta = new System.Windows.Forms.DataGridView();
            this.grid_articulos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verArticulosToolStripMenuItem_ver_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID_Venta = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_finalizar_compra = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_canasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_canasta
            // 
            this.grid_canasta.AllowUserToAddRows = false;
            this.grid_canasta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Aqua;
            this.grid_canasta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_canasta.BackgroundColor = System.Drawing.Color.White;
            this.grid_canasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_canasta.Location = new System.Drawing.Point(682, 54);
            this.grid_canasta.Name = "grid_canasta";
            this.grid_canasta.ReadOnly = true;
            this.grid_canasta.RowHeadersWidth = 51;
            this.grid_canasta.RowTemplate.Height = 24;
            this.grid_canasta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_canasta.Size = new System.Drawing.Size(709, 463);
            this.grid_canasta.TabIndex = 0;
            this.grid_canasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_canasta_CellClick);
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            this.grid_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_articulos.BackgroundColor = System.Drawing.Color.White;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(23, 106);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.RowHeadersWidth = 51;
            this.grid_articulos.RowTemplate.Height = 24;
            this.grid_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_articulos.Size = new System.Drawing.Size(611, 243);
            this.grid_articulos.TabIndex = 1;
            this.grid_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_articulos_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verArticulosToolStripMenuItem_ver_articulos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verArticulosToolStripMenuItem_ver_articulos
            // 
            this.verArticulosToolStripMenuItem_ver_articulos.Name = "verArticulosToolStripMenuItem_ver_articulos";
            this.verArticulosToolStripMenuItem_ver_articulos.Size = new System.Drawing.Size(136, 32);
            this.verArticulosToolStripMenuItem_ver_articulos.Text = "Ver Articulos";
            this.verArticulosToolStripMenuItem_ver_articulos.Click += new System.EventHandler(this.verArticulosToolStripMenuItem_ver_articulos_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar.Location = new System.Drawing.Point(288, 59);
            this.textBox_buscar.Multiline = true;
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(346, 39);
            this.textBox_buscar.TabIndex = 3;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Artiuculo";
            // 
            // button_agregar
            // 
            this.button_agregar.Enabled = false;
            this.button_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.Location = new System.Drawing.Point(682, 562);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(144, 80);
            this.button_agregar.TabIndex = 5;
            this.button_agregar.Text = "Agregar a Carrito";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de Venta:";
            // 
            // textBox_ID_Venta
            // 
            this.textBox_ID_Venta.Enabled = false;
            this.textBox_ID_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_Venta.Location = new System.Drawing.Point(403, 478);
            this.textBox_ID_Venta.Multiline = true;
            this.textBox_ID_Venta.Name = "textBox_ID_Venta";
            this.textBox_ID_Venta.Size = new System.Drawing.Size(114, 39);
            this.textBox_ID_Venta.TabIndex = 6;
            this.textBox_ID_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(1018, 571);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(373, 64);
            this.textBox_total.TabIndex = 8;
            this.textBox_total.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 69);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // button_finalizar_compra
            // 
            this.button_finalizar_compra.Enabled = false;
            this.button_finalizar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finalizar_compra.Location = new System.Drawing.Point(70, 557);
            this.button_finalizar_compra.Name = "button_finalizar_compra";
            this.button_finalizar_compra.Size = new System.Drawing.Size(232, 89);
            this.button_finalizar_compra.TabIndex = 10;
            this.button_finalizar_compra.Text = "Finalizar Compra";
            this.button_finalizar_compra.UseVisualStyleBackColor = true;
            this.button_finalizar_compra.Click += new System.EventHandler(this.button_finalizar_compra_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Enabled = false;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(366, 557);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(232, 89);
            this.button_cancelar.TabIndex = 11;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_iniciar
            // 
            this.button_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar.Location = new System.Drawing.Point(209, 368);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(136, 80);
            this.button_iniciar.TabIndex = 12;
            this.button_iniciar.Text = "Iniciar Venta";
            this.button_iniciar.UseVisualStyleBackColor = true;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 390);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 34);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cantidad.Location = new System.Drawing.Point(498, 389);
            this.textBox_Cantidad.Multiline = true;
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(136, 47);
            this.textBox_Cantidad.TabIndex = 14;
            this.textBox_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad:";
            // 
            // Form_Punto_De_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1418, 690);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_finalizar_compra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID_Venta);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.grid_canasta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Punto_De_Venta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Punto_De_Venta";
            this.Load += new System.EventHandler(this.Form_Punto_De_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_canasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_canasta;
        private System.Windows.Forms.DataGridView grid_articulos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verArticulosToolStripMenuItem_ver_articulos;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID_Venta;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_finalizar_compra;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label4;
    }
}